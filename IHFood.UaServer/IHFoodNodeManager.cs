using System.Buffers.Binary;
using System.Text;
using OmronNx;
using Opc.Ua;
using Opc.Ua.Server;
using ObjectIds = Opc.Ua.ObjectIds;

// TODO:
// * Strange error message URI not found when connecting with SecurityPolicyNone
// * Test with simulator to verify it works

namespace IHFood.UaServer
{
    /// <summary>
    /// A node manager for a server that exposes several variables.
    /// </summary>
    public class IHFoodNodeManager : CustomNodeManager2
    {
        private uint _nextNodeId;
        private FolderState _nxControllerFolder;

        /// <summary>
        /// Initializes the node manager.
        /// </summary>
        public IHFoodNodeManager(IServerInternal server, ApplicationConfiguration configuration)
            : base(server, configuration)
        {
            SystemContext.NodeIdFactory = this;
            SetNamespaces(OmronNx.Namespaces.OmronNx);
        }

        /// <summary>
        /// Creates the NodeId for the specified node.
        /// </summary>
        public override NodeId New(ISystemContext context, NodeState node)
        {
            // generate a numeric node id if the node has a parent and no node id assigned.

            if (node is BaseInstanceState instance && instance.Parent != null)
            {
                return GenerateNodeId();
            }

            return node.NodeId;
        }

        /// <summary>
        /// Does any initialization required before the address space can be used.
        /// </summary>
        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                base.CreateAddressSpace(externalReferences);
            }

            // create the NxController folder.
            var objectsNode = FindNodeInAddressSpace(ObjectIds.ObjectsFolder);
            _nxControllerFolder = new FolderState(objectsNode);

            // initialize it from the type model and assign unique node ids.
            _nxControllerFolder.Create(
                SystemContext,
                new NodeId("NxController.GlobalVars", NamespaceIndex),
                new QualifiedName("GlobalVars", NamespaceIndex),
                null,
                false);

            IList<IReference> references = null;
            if (!externalReferences.TryGetValue(ObjectIds.ObjectsFolder, out references))
            {
                externalReferences[ObjectIds.ObjectsFolder] = references = new List<IReference>();
            }

            references.Add(new NodeStateReference(ReferenceTypeIds.Organizes, false, _nxControllerFolder.NodeId));
            AddPredefinedNode(SystemContext, _nxControllerFolder);
        }

        public void AddNextLotVariable(string variableName)
        {
            var nextLotNode = new MeynConnectLotChangeState(_nxControllerFolder);

            // initialize it from the type model and assign unique node ids.
            nextLotNode.Create(
                SystemContext,
                new NodeId(variableName, NamespaceIndex),
                new QualifiedName(variableName, NamespaceIndex),
                null,
                false);

            _nxControllerFolder.AddReference(ReferenceTypeIds.HasComponent, false, nextLotNode.NodeId);
            nextLotNode.AddReference(ReferenceTypeIds.HasComponent, true, _nxControllerFolder.NodeId);

            var next = new MeynConnectNext
            {
                VersionID = 0,
                Next = new MeynConnectNextLotData
                {
                    LotName = new MeynConnectName
                    {
                        Name = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
                    },
                    LotID = [0, 0, 0, 0]
                }
            };
            nextLotNode.Value = next;
            nextLotNode.AccessLevel = AccessLevels.CurrentRead | AccessLevels.CurrentWrite;
            nextLotNode.UserAccessLevel = AccessLevels.CurrentRead | AccessLevels.CurrentWrite;
            nextLotNode.OnWriteValue = OnNextLotWriteValue;

            AddPredefinedNode(SystemContext, nextLotNode);
        }

        private static ServiceResult OnNextLotWriteValue(ISystemContext context, NodeState node,
            NumericRange indexRange,
            QualifiedName dataEncoding, ref object value, ref StatusCode statusCode, ref DateTime timestamp)
        {
            if (ExtensionObject.ToEncodeable(value as ExtensionObject) is MeynConnectNext newValue)
            {
                // IHFood needs to hook into this callback. It is triggered when a new Lot information is received
                Console.WriteLine($"New VersionId written for {node.BrowseName.Name}: {newValue.VersionID}");
                Console.WriteLine($"Next Lot Id: {UnpackLotId(newValue.Next.LotID)}");
                Console.WriteLine($"The next lot name is: {UnpackLotName(newValue.Next.LotName.Name)}");
            }
            else
            {
                return StatusCodes.BadTypeMismatch;
            }

            return ServiceResult.Good;
        }

        /// <summary>
        /// Loads a node set from a file or resource and addes them to the set of predefined nodes.
        /// </summary>
        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            var predefinedNodes = new NodeStateCollection();

            predefinedNodes.LoadFromResource(context,
                "IHFood.UaServer.Model.OmronNx.PredefinedNodes.xml",
                typeof(OmronNx.MeynConnectName).Assembly,
                true);

            return predefinedNodes;
        }

        /// <summary>
        /// Frees any resources allocated for the address space.
        /// </summary>
        public override void DeleteAddressSpace()
        {
            lock (Lock)
            {
                // TBD
            }
        }

        /// <summary>
        /// Returns a unique handle for the node.
        /// </summary>
        protected override NodeHandle GetManagerHandle(ServerSystemContext context, NodeId nodeId,
            IDictionary<NodeId, NodeState>? cache)
        {
            lock (Lock)
            {
                // quickly exclude nodes that are not in the namespace.
                if (!IsNodeIdInNamespace(nodeId))
                {
                    return null;
                }

                NodeState node = null;

                // check cache (the cache is used because the same node id can appear many times in a single request).
                if (cache != null)
                {
                    if (cache.TryGetValue(nodeId, out node))
                    {
                        return new NodeHandle(nodeId, node);
                    }
                }

                // look up predefined node.
                if (PredefinedNodes.TryGetValue(nodeId, out node))
                {
                    NodeHandle handle = new NodeHandle(nodeId, node);

                    if (cache != null)
                    {
                        cache.Add(nodeId, node);
                    }

                    return handle;
                }

                // node not found.
                return null;
            }
        }

        /// <summary>
        /// Verifies that the specified node exists.
        /// </summary>
        protected override NodeState ValidateNode(
            ServerSystemContext context,
            NodeHandle? handle,
            IDictionary<NodeId, NodeState> cache)
        {
            // not valid if no root.
            if (handle == null)
            {
                return null;
            }

            // check if previously validated.
            if (handle.Validated)
            {
                return handle.Node;
            }

            // lookup in operation cache.
            NodeState target = FindNodeInCache(context, handle, cache);

            if (target != null)
            {
                handle.Node = target;
                handle.Validated = true;
                return handle.Node;
            }

            // put root into operation cache.
            if (cache != null)
            {
                cache[handle.NodeId] = target;
            }

            handle.Node = target;
            handle.Validated = true;
            return handle.Node;
        }

        /// <summary>
        /// Generates a new node id.
        /// </summary>
        private NodeId GenerateNodeId()
        {
            return new NodeId(++_nextNodeId, NamespaceIndex);
        }

        // <summary>
        // Unpacks a lot ID as stored in the OPC-UA address space into a Guid object.
        // The data starts as an 128 bit UUID (described in RFC4122) in the area service, and is laid out in memory
        // as described in section 4.1.2 of that RFC. It's bytes are then manipulated and transferred to the OPC-UA server
        // as follows 
        // 1. The area service interprets the 128 bits as 4 32-bit integers. The first two integers are interpreted
        // as big-endian integers. The last two are interpreted as little-endian integers.
        // (God knows why, this is not part of the RFC).
        // 2. These 4 integers are written by the area service to the OPC-UA service address space of our lot tracking server.
        // 3. At this point, we need to reverse the interpretation of step 2:
        //    1. Lay out the first two integers as big-endian in memory.
        //    2. Lay out the last two integers as little-endian in memory.
        //
        // These last two steps is what this function does, as well as constructing an uuid.UUID (Python's implementation
        // of RFC4122 UUIDs) object from the bytes.
        private static Guid UnpackLotId(UInt32Collection data)
        {
            // Check if the data contains exactly 4 elements
            if (data == null || data.Count != 4)
            {
                throw new ArgumentException("The input data must contain exactly 4 32-bit integers.");
            }

            // Extract the 4 integers from the UInt32Collection
            uint first = data[0];
            uint second = data[1];
            uint third = data[2];
            uint fourth = data[3];

            // Convert the integers to byte arrays with appropriate endianness
            first = BitConverter.IsLittleEndian ? first : BinaryPrimitives.ReverseEndianness(first);
            second = BitConverter.IsLittleEndian ? second : BinaryPrimitives.ReverseEndianness(second);
            third = BitConverter.IsLittleEndian ? BinaryPrimitives.ReverseEndianness(third) : third;
            fourth = BitConverter.IsLittleEndian ? BinaryPrimitives.ReverseEndianness(fourth) : fourth;
            byte[] firstBytes = BitConverter.GetBytes(first);
            byte[] secondBytes = BitConverter.GetBytes(second);
            byte[] thirdBytes = BitConverter.GetBytes(third);
            byte[] fourthBytes = BitConverter.GetBytes(fourth);

            // Concatenate the byte arrays to form the UUID byte sequence
            byte[] uuidBytes = firstBytes
                .Concat(secondBytes)
                .Concat(thirdBytes)
                .Concat(fourthBytes)
                .ToArray();

            // Create a GUID from the byte array
            return new Guid(uuidBytes);
        }

        private static string UnpackLotName(UInt16Collection lotName)
        {
            if (lotName == null || lotName.Count == 0)
            {
                return string.Empty;
            }

            // Use a StringBuilder for efficient string concatenation
            var stringBuilder = new StringBuilder(lotName.Count);

            // Convert each UInt16 to a char and append to the StringBuilder
            foreach (var value in lotName)
            {
                stringBuilder.Append((char) value);
            }

            // Return the concatenated string
            return stringBuilder.ToString();
        }
    }
}