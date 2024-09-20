/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace OmronNx
{
    #region DataType Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <summary>
        /// The identifier for the MeynConnectName DataType.
        /// </summary>
        public const uint MeynConnectName = 99;

        /// <summary>
        /// The identifier for the MeynConnectNextLotData DataType.
        /// </summary>
        public const uint MeynConnectNextLotData = 100;

        /// <summary>
        /// The identifier for the MeynConnectNext DataType.
        /// </summary>
        public const uint MeynConnectNext = 101;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the MeynConnectName_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint MeynConnectName_Encoding_DefaultBinary = 102;

        /// <summary>
        /// The identifier for the MeynConnectNextLotData_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint MeynConnectNextLotData_Encoding_DefaultBinary = 103;

        /// <summary>
        /// The identifier for the MeynConnectNext_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint MeynConnectNext_Encoding_DefaultBinary = 104;

        /// <summary>
        /// The identifier for the MeynConnectName_Encoding_DefaultXml Object.
        /// </summary>
        public const uint MeynConnectName_Encoding_DefaultXml = 114;

        /// <summary>
        /// The identifier for the MeynConnectNextLotData_Encoding_DefaultXml Object.
        /// </summary>
        public const uint MeynConnectNextLotData_Encoding_DefaultXml = 115;

        /// <summary>
        /// The identifier for the MeynConnectNext_Encoding_DefaultXml Object.
        /// </summary>
        public const uint MeynConnectNext_Encoding_DefaultXml = 116;

        /// <summary>
        /// The identifier for the MeynConnectName_Encoding_DefaultJson Object.
        /// </summary>
        public const uint MeynConnectName_Encoding_DefaultJson = 126;

        /// <summary>
        /// The identifier for the MeynConnectNextLotData_Encoding_DefaultJson Object.
        /// </summary>
        public const uint MeynConnectNextLotData_Encoding_DefaultJson = 127;

        /// <summary>
        /// The identifier for the MeynConnectNext_Encoding_DefaultJson Object.
        /// </summary>
        public const uint MeynConnectNext_Encoding_DefaultJson = 128;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the OmronNx_BinarySchema Variable.
        /// </summary>
        public const uint OmronNx_BinarySchema = 7;

        /// <summary>
        /// The identifier for the OmronNx_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint OmronNx_BinarySchema_NamespaceUri = 9;

        /// <summary>
        /// The identifier for the OmronNx_BinarySchema_Deprecated Variable.
        /// </summary>
        public const uint OmronNx_BinarySchema_Deprecated = 10;

        /// <summary>
        /// The identifier for the OmronNx_BinarySchema_MeynConnectName Variable.
        /// </summary>
        public const uint OmronNx_BinarySchema_MeynConnectName = 105;

        /// <summary>
        /// The identifier for the OmronNx_BinarySchema_MeynConnectNextLotData Variable.
        /// </summary>
        public const uint OmronNx_BinarySchema_MeynConnectNextLotData = 108;

        /// <summary>
        /// The identifier for the OmronNx_BinarySchema_MeynConnectNext Variable.
        /// </summary>
        public const uint OmronNx_BinarySchema_MeynConnectNext = 111;

        /// <summary>
        /// The identifier for the OmronNx_XmlSchema Variable.
        /// </summary>
        public const uint OmronNx_XmlSchema = 23;

        /// <summary>
        /// The identifier for the OmronNx_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint OmronNx_XmlSchema_NamespaceUri = 25;

        /// <summary>
        /// The identifier for the OmronNx_XmlSchema_Deprecated Variable.
        /// </summary>
        public const uint OmronNx_XmlSchema_Deprecated = 26;

        /// <summary>
        /// The identifier for the OmronNx_XmlSchema_MeynConnectName Variable.
        /// </summary>
        public const uint OmronNx_XmlSchema_MeynConnectName = 117;

        /// <summary>
        /// The identifier for the OmronNx_XmlSchema_MeynConnectNextLotData Variable.
        /// </summary>
        public const uint OmronNx_XmlSchema_MeynConnectNextLotData = 120;

        /// <summary>
        /// The identifier for the OmronNx_XmlSchema_MeynConnectNext Variable.
        /// </summary>
        public const uint OmronNx_XmlSchema_MeynConnectNext = 123;
    }
    #endregion

    #region VariableType Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypes
    {
        /// <summary>
        /// The identifier for the MeynConnectLotChangeType VariableType.
        /// </summary>
        public const uint MeynConnectLotChangeType = 129;
    }
    #endregion

    #region DataType Node Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <summary>
        /// The identifier for the MeynConnectName DataType.
        /// </summary>
        public static readonly ExpandedNodeId MeynConnectName = new ExpandedNodeId(OmronNx.DataTypes.MeynConnectName, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the MeynConnectNextLotData DataType.
        /// </summary>
        public static readonly ExpandedNodeId MeynConnectNextLotData = new ExpandedNodeId(OmronNx.DataTypes.MeynConnectNextLotData, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the MeynConnectNext DataType.
        /// </summary>
        public static readonly ExpandedNodeId MeynConnectNext = new ExpandedNodeId(OmronNx.DataTypes.MeynConnectNext, OmronNx.Namespaces.OmronNx);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the MeynConnectName_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId MeynConnectName_Encoding_DefaultBinary = new ExpandedNodeId(OmronNx.Objects.MeynConnectName_Encoding_DefaultBinary, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the MeynConnectNextLotData_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId MeynConnectNextLotData_Encoding_DefaultBinary = new ExpandedNodeId(OmronNx.Objects.MeynConnectNextLotData_Encoding_DefaultBinary, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the MeynConnectNext_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId MeynConnectNext_Encoding_DefaultBinary = new ExpandedNodeId(OmronNx.Objects.MeynConnectNext_Encoding_DefaultBinary, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the MeynConnectName_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId MeynConnectName_Encoding_DefaultXml = new ExpandedNodeId(OmronNx.Objects.MeynConnectName_Encoding_DefaultXml, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the MeynConnectNextLotData_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId MeynConnectNextLotData_Encoding_DefaultXml = new ExpandedNodeId(OmronNx.Objects.MeynConnectNextLotData_Encoding_DefaultXml, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the MeynConnectNext_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId MeynConnectNext_Encoding_DefaultXml = new ExpandedNodeId(OmronNx.Objects.MeynConnectNext_Encoding_DefaultXml, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the MeynConnectName_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId MeynConnectName_Encoding_DefaultJson = new ExpandedNodeId(OmronNx.Objects.MeynConnectName_Encoding_DefaultJson, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the MeynConnectNextLotData_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId MeynConnectNextLotData_Encoding_DefaultJson = new ExpandedNodeId(OmronNx.Objects.MeynConnectNextLotData_Encoding_DefaultJson, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the MeynConnectNext_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId MeynConnectNext_Encoding_DefaultJson = new ExpandedNodeId(OmronNx.Objects.MeynConnectNext_Encoding_DefaultJson, OmronNx.Namespaces.OmronNx);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the OmronNx_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OmronNx_BinarySchema = new ExpandedNodeId(OmronNx.Variables.OmronNx_BinarySchema, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the OmronNx_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OmronNx_BinarySchema_NamespaceUri = new ExpandedNodeId(OmronNx.Variables.OmronNx_BinarySchema_NamespaceUri, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the OmronNx_BinarySchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId OmronNx_BinarySchema_Deprecated = new ExpandedNodeId(OmronNx.Variables.OmronNx_BinarySchema_Deprecated, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the OmronNx_BinarySchema_MeynConnectName Variable.
        /// </summary>
        public static readonly ExpandedNodeId OmronNx_BinarySchema_MeynConnectName = new ExpandedNodeId(OmronNx.Variables.OmronNx_BinarySchema_MeynConnectName, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the OmronNx_BinarySchema_MeynConnectNextLotData Variable.
        /// </summary>
        public static readonly ExpandedNodeId OmronNx_BinarySchema_MeynConnectNextLotData = new ExpandedNodeId(OmronNx.Variables.OmronNx_BinarySchema_MeynConnectNextLotData, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the OmronNx_BinarySchema_MeynConnectNext Variable.
        /// </summary>
        public static readonly ExpandedNodeId OmronNx_BinarySchema_MeynConnectNext = new ExpandedNodeId(OmronNx.Variables.OmronNx_BinarySchema_MeynConnectNext, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the OmronNx_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OmronNx_XmlSchema = new ExpandedNodeId(OmronNx.Variables.OmronNx_XmlSchema, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the OmronNx_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OmronNx_XmlSchema_NamespaceUri = new ExpandedNodeId(OmronNx.Variables.OmronNx_XmlSchema_NamespaceUri, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the OmronNx_XmlSchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId OmronNx_XmlSchema_Deprecated = new ExpandedNodeId(OmronNx.Variables.OmronNx_XmlSchema_Deprecated, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the OmronNx_XmlSchema_MeynConnectName Variable.
        /// </summary>
        public static readonly ExpandedNodeId OmronNx_XmlSchema_MeynConnectName = new ExpandedNodeId(OmronNx.Variables.OmronNx_XmlSchema_MeynConnectName, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the OmronNx_XmlSchema_MeynConnectNextLotData Variable.
        /// </summary>
        public static readonly ExpandedNodeId OmronNx_XmlSchema_MeynConnectNextLotData = new ExpandedNodeId(OmronNx.Variables.OmronNx_XmlSchema_MeynConnectNextLotData, OmronNx.Namespaces.OmronNx);

        /// <summary>
        /// The identifier for the OmronNx_XmlSchema_MeynConnectNext Variable.
        /// </summary>
        public static readonly ExpandedNodeId OmronNx_XmlSchema_MeynConnectNext = new ExpandedNodeId(OmronNx.Variables.OmronNx_XmlSchema_MeynConnectNext, OmronNx.Namespaces.OmronNx);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypeIds
    {
        /// <summary>
        /// The identifier for the MeynConnectLotChangeType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId MeynConnectLotChangeType = new ExpandedNodeId(OmronNx.VariableTypes.MeynConnectLotChangeType, OmronNx.Namespaces.OmronNx);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the MeynConnectLotChangeType component.
        /// </summary>
        public const string MeynConnectLotChangeType = "MeynConnect\nLotChangeType";

        /// <summary>
        /// The BrowseName for the MeynConnectName component.
        /// </summary>
        public const string MeynConnectName = "MeynConnect\nName";

        /// <summary>
        /// The BrowseName for the MeynConnectNext component.
        /// </summary>
        public const string MeynConnectNext = "MeynConnect\nNext";

        /// <summary>
        /// The BrowseName for the MeynConnectNextLotData component.
        /// </summary>
        public const string MeynConnectNextLotData = "MeynConnect\nNextLotData";

        /// <summary>
        /// The BrowseName for the OmronNx_BinarySchema component.
        /// </summary>
        public const string OmronNx_BinarySchema = "OmronNx";

        /// <summary>
        /// The BrowseName for the OmronNx_XmlSchema component.
        /// </summary>
        public const string OmronNx_XmlSchema = "OmronNx";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OmronNx namespace (.NET code namespace is 'OmronNx').
        /// </summary>
        public const string OmronNx = "urn:OMRON:NxOpcUaServer:FactoryAutomation";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion

    #region MeynConnectName Class
    #if (!OPCUA_EXCLUDE_MeynConnectName)
    /// <summary>
    ///
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = OmronNx.Namespaces.OmronNx)]
    public partial class MeynConnectName : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public MeynConnectName()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_name = new UInt16Collection();
        }
        #endregion

        #region Public Properties
        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "Name", IsRequired = false, Order = 1)]
        public UInt16Collection Name
        {
            get
            {
                return m_name;
            }

            set
            {
                m_name = value;

                if (value == null)
                {
                    m_name = new UInt16Collection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.MeynConnectName; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.MeynConnectName_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.MeynConnectName_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(OmronNx.Namespaces.OmronNx);

            encoder.WriteUInt16Array("Name", Name);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(OmronNx.Namespaces.OmronNx);

            Name = decoder.ReadUInt16Array("Name");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            MeynConnectName value = encodeable as MeynConnectName;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_name, value.m_name)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (MeynConnectName)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MeynConnectName clone = (MeynConnectName)base.MemberwiseClone();

            clone.m_name = (UInt16Collection)Utils.Clone(this.m_name);

            return clone;
        }
        #endregion

        #region Private Fields
        private UInt16Collection m_name;
        #endregion
    }

    #region MeynConnectNameCollection Class
    /// <summary>
    /// A collection of MeynConnectName objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfMeynConnectName", Namespace = OmronNx.Namespaces.OmronNx, ItemName = "MeynConnectName")]
    #if !NET_STANDARD
    public partial class MeynConnectNameCollection : List<MeynConnectName>, ICloneable
    #else
    public partial class MeynConnectNameCollection : List<MeynConnectName>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public MeynConnectNameCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public MeynConnectNameCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public MeynConnectNameCollection(IEnumerable<MeynConnectName> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator MeynConnectNameCollection(MeynConnectName[] values)
        {
            if (values != null)
            {
                return new MeynConnectNameCollection(values);
            }

            return new MeynConnectNameCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator MeynConnectName[](MeynConnectNameCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (MeynConnectNameCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MeynConnectNameCollection clone = new MeynConnectNameCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((MeynConnectName)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region MeynConnectNextLotData Class
    #if (!OPCUA_EXCLUDE_MeynConnectNextLotData)
    /// <summary>
    ///
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = OmronNx.Namespaces.OmronNx)]
    public partial class MeynConnectNextLotData : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public MeynConnectNextLotData()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_lotID = new UInt32Collection();
            m_lotName = new MeynConnectName();
        }
        #endregion

        #region Public Properties
        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "LotID", IsRequired = false, Order = 1)]
        public UInt32Collection LotID
        {
            get
            {
                return m_lotID;
            }

            set
            {
                m_lotID = value;

                if (value == null)
                {
                    m_lotID = new UInt32Collection();
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "LotName", IsRequired = false, Order = 2)]
        public MeynConnectName LotName
        {
            get
            {
                return m_lotName;
            }

            set
            {
                m_lotName = value;

                if (value == null)
                {
                    m_lotName = new MeynConnectName();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.MeynConnectNextLotData; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.MeynConnectNextLotData_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.MeynConnectNextLotData_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(OmronNx.Namespaces.OmronNx);

            encoder.WriteUInt32Array("LotID", LotID);
            encoder.WriteEncodeable("LotName", LotName, typeof(MeynConnectName));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(OmronNx.Namespaces.OmronNx);

            LotID = decoder.ReadUInt32Array("LotID");
            LotName = (MeynConnectName)decoder.ReadEncodeable("LotName", typeof(MeynConnectName));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            MeynConnectNextLotData value = encodeable as MeynConnectNextLotData;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_lotID, value.m_lotID)) return false;
            if (!Utils.IsEqual(m_lotName, value.m_lotName)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (MeynConnectNextLotData)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MeynConnectNextLotData clone = (MeynConnectNextLotData)base.MemberwiseClone();

            clone.m_lotID = (UInt32Collection)Utils.Clone(this.m_lotID);
            clone.m_lotName = (MeynConnectName)Utils.Clone(this.m_lotName);

            return clone;
        }
        #endregion

        #region Private Fields
        private UInt32Collection m_lotID;
        private MeynConnectName m_lotName;
        #endregion
    }

    #region MeynConnectNextLotDataCollection Class
    /// <summary>
    /// A collection of MeynConnectNextLotData objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfMeynConnectNextLotData", Namespace = OmronNx.Namespaces.OmronNx, ItemName = "MeynConnectNextLotData")]
    #if !NET_STANDARD
    public partial class MeynConnectNextLotDataCollection : List<MeynConnectNextLotData>, ICloneable
    #else
    public partial class MeynConnectNextLotDataCollection : List<MeynConnectNextLotData>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public MeynConnectNextLotDataCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public MeynConnectNextLotDataCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public MeynConnectNextLotDataCollection(IEnumerable<MeynConnectNextLotData> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator MeynConnectNextLotDataCollection(MeynConnectNextLotData[] values)
        {
            if (values != null)
            {
                return new MeynConnectNextLotDataCollection(values);
            }

            return new MeynConnectNextLotDataCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator MeynConnectNextLotData[](MeynConnectNextLotDataCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (MeynConnectNextLotDataCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MeynConnectNextLotDataCollection clone = new MeynConnectNextLotDataCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((MeynConnectNextLotData)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region MeynConnectNext Class
    #if (!OPCUA_EXCLUDE_MeynConnectNext)
    /// <summary>
    ///
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = OmronNx.Namespaces.OmronNx)]
    public partial class MeynConnectNext : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// The default constructor.
        /// </summary>
        public MeynConnectNext()
        {
            Initialize();
        }

        /// <summary>
        /// Called by the .NET framework during deserialization.
        /// </summary>
        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
            m_versionID = (ushort)0;
            m_next = new MeynConnectNextLotData();
        }
        #endregion

        #region Public Properties
        /// <remarks />
        [DataMember(Name = "VersionID", IsRequired = false, Order = 1)]
        public ushort VersionID
        {
            get { return m_versionID;  }
            set { m_versionID = value; }
        }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "Next", IsRequired = false, Order = 2)]
        public MeynConnectNextLotData Next
        {
            get
            {
                return m_next;
            }

            set
            {
                m_next = value;

                if (value == null)
                {
                    m_next = new MeynConnectNextLotData();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.MeynConnectNext; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.MeynConnectNext_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.MeynConnectNext_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(OmronNx.Namespaces.OmronNx);

            encoder.WriteUInt16("VersionID", VersionID);
            encoder.WriteEncodeable("Next", Next, typeof(MeynConnectNextLotData));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(OmronNx.Namespaces.OmronNx);

            VersionID = decoder.ReadUInt16("VersionID");
            Next = (MeynConnectNextLotData)decoder.ReadEncodeable("Next", typeof(MeynConnectNextLotData));

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            MeynConnectNext value = encodeable as MeynConnectNext;

            if (value == null)
            {
                return false;
            }

            if (!Utils.IsEqual(m_versionID, value.m_versionID)) return false;
            if (!Utils.IsEqual(m_next, value.m_next)) return false;

            return true;
        }

        #if !NET_STANDARD
        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (MeynConnectNext)this.MemberwiseClone();
        }
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MeynConnectNext clone = (MeynConnectNext)base.MemberwiseClone();

            clone.m_versionID = (ushort)Utils.Clone(this.m_versionID);
            clone.m_next = (MeynConnectNextLotData)Utils.Clone(this.m_next);

            return clone;
        }
        #endregion

        #region Private Fields
        private ushort m_versionID;
        private MeynConnectNextLotData m_next;
        #endregion
    }

    #region MeynConnectNextCollection Class
    /// <summary>
    /// A collection of MeynConnectNext objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfMeynConnectNext", Namespace = OmronNx.Namespaces.OmronNx, ItemName = "MeynConnectNext")]
    #if !NET_STANDARD
    public partial class MeynConnectNextCollection : List<MeynConnectNext>, ICloneable
    #else
    public partial class MeynConnectNextCollection : List<MeynConnectNext>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public MeynConnectNextCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public MeynConnectNextCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public MeynConnectNextCollection(IEnumerable<MeynConnectNext> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator MeynConnectNextCollection(MeynConnectNext[] values)
        {
            if (values != null)
            {
                return new MeynConnectNextCollection(values);
            }

            return new MeynConnectNextCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator MeynConnectNext[](MeynConnectNextCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (MeynConnectNextCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MeynConnectNextCollection clone = new MeynConnectNextCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((MeynConnectNext)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region MeynConnectLotChangeState Class
    #if (!OPCUA_EXCLUDE_MeynConnectLotChangeState)
    /// <summary>
    /// Stores an instance of the MeynConnectLotChangeType VariableType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MeynConnectLotChangeState : BaseDataVariableState<MeynConnectNext>
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MeynConnectLotChangeState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OmronNx.VariableTypes.MeynConnectLotChangeType, OmronNx.Namespaces.OmronNx, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default data type node for the instance.
        /// </summary>
        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OmronNx.DataTypes.MeynConnectNext, OmronNx.Namespaces.OmronNx, namespaceUris);
        }

        /// <summary>
        /// Returns the id of the default value rank for the instance.
        /// </summary>
        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACkAAAB1cm46T01ST046TnhPcGNVYVNlcnZlcjpGYWN0b3J5QXV0b21hdGlvbv////8VYIkCAgAA" +
           "AAEAIAAAAE1leW5Db25uZWN0TG90Q2hhbmdlVHlwZUluc3RhbmNlAQGBAAEBgQCBAAAAAQFlAP////8B" +
           "Af////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}
