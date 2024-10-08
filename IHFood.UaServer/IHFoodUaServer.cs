using Opc.Ua;
using Opc.Ua.Server;

namespace IHFood.UaServer
{
    public class IHFoodUaServer : StandardServer
    {
        public IHFoodNodeManager? IhFoodNodeManager { get; private set; }

        /// <summary>
        /// Creates the node managers for the server.
        /// </summary>
        /// <remarks>
        /// This method allows the sub-class create any additional node managers which it uses. The SDK
        /// always creates a CoreNodeManager which handles the built-in nodes defined by the specification.
        /// Any additional NodeManagers are expected to handle application specific nodes.
        /// </remarks>
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            Utils.Trace("Creating the Node Managers.");

            // add the types defined in the omronnx information model library to the factory.
            server.Factory.AddEncodeableTypes(typeof(OmronNx.DataTypes).Assembly);
            server.Factory.AddEncodeableTypes(GetType().Assembly);

            var nodeManagers = new List<INodeManager?>();

            // create the IHFood Node Manager.
            IhFoodNodeManager = new IHFoodNodeManager(server, configuration);
            nodeManagers.Add(IhFoodNodeManager);

            // create master node manager.
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }

        /// <summary>
        /// Loads the non-configurable properties for the application.
        /// </summary>
        /// <remarks>
        /// These properties are exposed by the server but cannot be changed by administrators.
        /// </remarks>
        protected override ServerProperties LoadServerProperties()
        {
            ServerProperties properties = new ServerProperties();

            properties.ManufacturerName = "IHFood";
            properties.ProductName      = "IHFoodUaServer";
            properties.ProductUri       = "http://ihfood.dk/IHFoodUaServer/";
            properties.SoftwareVersion  = Utils.GetAssemblySoftwareVersion();
            properties.BuildNumber      = Utils.GetAssemblyBuildNumber();
            properties.BuildDate        = Utils.GetAssemblyTimestamp();

            // TBD - All applications have software certificates that need to added to the properties.

            return properties;
        }
    }
}
