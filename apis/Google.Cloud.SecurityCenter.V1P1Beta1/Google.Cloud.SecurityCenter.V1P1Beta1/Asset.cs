// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1p1beta1/asset.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1P1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1p1beta1/asset.proto</summary>
  public static partial class AssetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1p1beta1/asset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjFwMWJldGExL2Fzc2V0",
            "LnByb3RvEiVnb29nbGUuY2xvdWQuc2VjdXJpdHljZW50ZXIudjFwMWJldGEx",
            "Ghxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvGhlnb29nbGUvYXBpL3Jl",
            "c291cmNlLnByb3RvGjpnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjFw",
            "MWJldGExL3NlY3VyaXR5X21hcmtzLnByb3RvGhxnb29nbGUvcHJvdG9idWYv",
            "c3RydWN0LnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3Rv",
            "Iq4HCgVBc3NldBIMCgRuYW1lGAEgASgJEmkKGnNlY3VyaXR5X2NlbnRlcl9w",
            "cm9wZXJ0aWVzGAIgASgLMkUuZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVy",
            "LnYxcDFiZXRhMS5Bc3NldC5TZWN1cml0eUNlbnRlclByb3BlcnRpZXMSYQoT",
            "cmVzb3VyY2VfcHJvcGVydGllcxgHIAMoCzJELmdvb2dsZS5jbG91ZC5zZWN1",
            "cml0eWNlbnRlci52MXAxYmV0YTEuQXNzZXQuUmVzb3VyY2VQcm9wZXJ0aWVz",
            "RW50cnkSTAoOc2VjdXJpdHlfbWFya3MYCCABKAsyNC5nb29nbGUuY2xvdWQu",
            "c2VjdXJpdHljZW50ZXIudjFwMWJldGExLlNlY3VyaXR5TWFya3MSLwoLY3Jl",
            "YXRlX3RpbWUYCSABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEi8K",
            "C3VwZGF0ZV90aW1lGAogASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFt",
            "cBJKCgppYW1fcG9saWN5GAsgASgLMjYuZ29vZ2xlLmNsb3VkLnNlY3VyaXR5",
            "Y2VudGVyLnYxcDFiZXRhMS5Bc3NldC5JYW1Qb2xpY3kagAIKGFNlY3VyaXR5",
            "Q2VudGVyUHJvcGVydGllcxIVCg1yZXNvdXJjZV9uYW1lGAEgASgJEhUKDXJl",
            "c291cmNlX3R5cGUYAiABKAkSFwoPcmVzb3VyY2VfcGFyZW50GAMgASgJEhgK",
            "EHJlc291cmNlX3Byb2plY3QYBCABKAkSFwoPcmVzb3VyY2Vfb3duZXJzGAUg",
            "AygJEh0KFXJlc291cmNlX2Rpc3BsYXlfbmFtZRgGIAEoCRIkChxyZXNvdXJj",
            "ZV9wYXJlbnRfZGlzcGxheV9uYW1lGAcgASgJEiUKHXJlc291cmNlX3Byb2pl",
            "Y3RfZGlzcGxheV9uYW1lGAggASgJGiAKCUlhbVBvbGljeRITCgtwb2xpY3lf",
            "YmxvYhgBIAEoCRpRChdSZXNvdXJjZVByb3BlcnRpZXNFbnRyeRILCgNrZXkY",
            "ASABKAkSJQoFdmFsdWUYAiABKAsyFi5nb29nbGUucHJvdG9idWYuVmFsdWU6",
            "AjgBOlXqQVIKI3NlY3VyaXR5Y2VudGVyLmdvb2dsZWFwaXMuY29tL0Fzc2V0",
            "Eitvcmdhbml6YXRpb25zL3tvcmdhbml6YXRpb259L2Fzc2V0cy97YXNzZXR9",
            "Qv0BCiljb20uZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnYxcDFiZXRh",
            "MVABWlNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Ns",
            "b3VkL3NlY3VyaXR5Y2VudGVyL3YxcDFiZXRhMTtzZWN1cml0eWNlbnRlcqoC",
            "JUdvb2dsZS5DbG91ZC5TZWN1cml0eUNlbnRlci5WMVAxQmV0YTHKAiVHb29n",
            "bGVcQ2xvdWRcU2VjdXJpdHlDZW50ZXJcVjFwMWJldGEx6gIoR29vZ2xlOjpD",
            "bG91ZDo6U2VjdXJpdHlDZW50ZXI6OlYxcDFiZXRhMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.SecurityCenter.V1P1Beta1.SecurityMarksReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1P1Beta1.Asset), global::Google.Cloud.SecurityCenter.V1P1Beta1.Asset.Parser, new[]{ "Name", "SecurityCenterProperties", "ResourceProperties", "SecurityMarks", "CreateTime", "UpdateTime", "IamPolicy" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1P1Beta1.Asset.Types.SecurityCenterProperties), global::Google.Cloud.SecurityCenter.V1P1Beta1.Asset.Types.SecurityCenterProperties.Parser, new[]{ "ResourceName", "ResourceType", "ResourceParent", "ResourceProject", "ResourceOwners", "ResourceDisplayName", "ResourceParentDisplayName", "ResourceProjectDisplayName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1P1Beta1.Asset.Types.IamPolicy), global::Google.Cloud.SecurityCenter.V1P1Beta1.Asset.Types.IamPolicy.Parser, new[]{ "PolicyBlob" }, null, null, null),
            null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Cloud Security Command Center's (Cloud SCC) representation of a Google Cloud
  /// Platform (GCP) resource.
  ///
  /// The Asset is a Cloud SCC resource that captures information about a single
  /// GCP resource. All modifications to an Asset are only within the context of
  /// Cloud SCC and don't affect the referenced GCP resource.
  /// </summary>
  public sealed partial class Asset : pb::IMessage<Asset> {
    private static readonly pb::MessageParser<Asset> _parser = new pb::MessageParser<Asset>(() => new Asset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Asset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1P1Beta1.AssetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Asset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Asset(Asset other) : this() {
      name_ = other.name_;
      securityCenterProperties_ = other.securityCenterProperties_ != null ? other.securityCenterProperties_.Clone() : null;
      resourceProperties_ = other.resourceProperties_.Clone();
      securityMarks_ = other.securityMarks_ != null ? other.securityMarks_.Clone() : null;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      iamPolicy_ = other.iamPolicy_ != null ? other.iamPolicy_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Asset Clone() {
      return new Asset(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The relative resource name of this asset. See:
    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name
    /// Example:
    /// "organizations/{organization_id}/assets/{asset_id}".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "security_center_properties" field.</summary>
    public const int SecurityCenterPropertiesFieldNumber = 2;
    private global::Google.Cloud.SecurityCenter.V1P1Beta1.Asset.Types.SecurityCenterProperties securityCenterProperties_;
    /// <summary>
    /// Cloud SCC managed properties. These properties are managed by
    /// Cloud SCC and cannot be modified by the user.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.SecurityCenter.V1P1Beta1.Asset.Types.SecurityCenterProperties SecurityCenterProperties {
      get { return securityCenterProperties_; }
      set {
        securityCenterProperties_ = value;
      }
    }

    /// <summary>Field number for the "resource_properties" field.</summary>
    public const int ResourcePropertiesFieldNumber = 7;
    private static readonly pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Value>.Codec _map_resourceProperties_codec
        = new pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Value>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::Google.Protobuf.WellKnownTypes.Value.Parser), 58);
    private readonly pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Value> resourceProperties_ = new pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Value>();
    /// <summary>
    /// Resource managed properties. These properties are managed and defined by
    /// the GCP resource and cannot be modified by the user.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Value> ResourceProperties {
      get { return resourceProperties_; }
    }

    /// <summary>Field number for the "security_marks" field.</summary>
    public const int SecurityMarksFieldNumber = 8;
    private global::Google.Cloud.SecurityCenter.V1P1Beta1.SecurityMarks securityMarks_;
    /// <summary>
    /// User specified security marks. These marks are entirely managed by the user
    /// and come from the SecurityMarks resource that belongs to the asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.SecurityCenter.V1P1Beta1.SecurityMarks SecurityMarks {
      get { return securityMarks_; }
      set {
        securityMarks_ = value;
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 9;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// The time at which the asset was created in Cloud SCC.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 10;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// The time at which the asset was last updated, added, or deleted in Cloud
    /// SCC.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "iam_policy" field.</summary>
    public const int IamPolicyFieldNumber = 11;
    private global::Google.Cloud.SecurityCenter.V1P1Beta1.Asset.Types.IamPolicy iamPolicy_;
    /// <summary>
    /// IAM Policy information associated with the GCP resource described by the
    /// Cloud SCC asset. This information is managed and defined by the GCP
    /// resource and cannot be modified by the user.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.SecurityCenter.V1P1Beta1.Asset.Types.IamPolicy IamPolicy {
      get { return iamPolicy_; }
      set {
        iamPolicy_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Asset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Asset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(SecurityCenterProperties, other.SecurityCenterProperties)) return false;
      if (!ResourceProperties.Equals(other.ResourceProperties)) return false;
      if (!object.Equals(SecurityMarks, other.SecurityMarks)) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (!object.Equals(IamPolicy, other.IamPolicy)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (securityCenterProperties_ != null) hash ^= SecurityCenterProperties.GetHashCode();
      hash ^= ResourceProperties.GetHashCode();
      if (securityMarks_ != null) hash ^= SecurityMarks.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (iamPolicy_ != null) hash ^= IamPolicy.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (securityCenterProperties_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SecurityCenterProperties);
      }
      resourceProperties_.WriteTo(output, _map_resourceProperties_codec);
      if (securityMarks_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(SecurityMarks);
      }
      if (createTime_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(UpdateTime);
      }
      if (iamPolicy_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(IamPolicy);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (securityCenterProperties_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SecurityCenterProperties);
      }
      size += resourceProperties_.CalculateSize(_map_resourceProperties_codec);
      if (securityMarks_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SecurityMarks);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (iamPolicy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IamPolicy);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Asset other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.securityCenterProperties_ != null) {
        if (securityCenterProperties_ == null) {
          SecurityCenterProperties = new global::Google.Cloud.SecurityCenter.V1P1Beta1.Asset.Types.SecurityCenterProperties();
        }
        SecurityCenterProperties.MergeFrom(other.SecurityCenterProperties);
      }
      resourceProperties_.Add(other.resourceProperties_);
      if (other.securityMarks_ != null) {
        if (securityMarks_ == null) {
          SecurityMarks = new global::Google.Cloud.SecurityCenter.V1P1Beta1.SecurityMarks();
        }
        SecurityMarks.MergeFrom(other.SecurityMarks);
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      if (other.iamPolicy_ != null) {
        if (iamPolicy_ == null) {
          IamPolicy = new global::Google.Cloud.SecurityCenter.V1P1Beta1.Asset.Types.IamPolicy();
        }
        IamPolicy.MergeFrom(other.IamPolicy);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (securityCenterProperties_ == null) {
              SecurityCenterProperties = new global::Google.Cloud.SecurityCenter.V1P1Beta1.Asset.Types.SecurityCenterProperties();
            }
            input.ReadMessage(SecurityCenterProperties);
            break;
          }
          case 58: {
            resourceProperties_.AddEntriesFrom(input, _map_resourceProperties_codec);
            break;
          }
          case 66: {
            if (securityMarks_ == null) {
              SecurityMarks = new global::Google.Cloud.SecurityCenter.V1P1Beta1.SecurityMarks();
            }
            input.ReadMessage(SecurityMarks);
            break;
          }
          case 74: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 82: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 90: {
            if (iamPolicy_ == null) {
              IamPolicy = new global::Google.Cloud.SecurityCenter.V1P1Beta1.Asset.Types.IamPolicy();
            }
            input.ReadMessage(IamPolicy);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Asset message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Cloud SCC managed properties. These properties are managed by Cloud SCC and
      /// cannot be modified by the user.
      /// </summary>
      public sealed partial class SecurityCenterProperties : pb::IMessage<SecurityCenterProperties> {
        private static readonly pb::MessageParser<SecurityCenterProperties> _parser = new pb::MessageParser<SecurityCenterProperties>(() => new SecurityCenterProperties());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<SecurityCenterProperties> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.SecurityCenter.V1P1Beta1.Asset.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public SecurityCenterProperties() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public SecurityCenterProperties(SecurityCenterProperties other) : this() {
          resourceName_ = other.resourceName_;
          resourceType_ = other.resourceType_;
          resourceParent_ = other.resourceParent_;
          resourceProject_ = other.resourceProject_;
          resourceOwners_ = other.resourceOwners_.Clone();
          resourceDisplayName_ = other.resourceDisplayName_;
          resourceParentDisplayName_ = other.resourceParentDisplayName_;
          resourceProjectDisplayName_ = other.resourceProjectDisplayName_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public SecurityCenterProperties Clone() {
          return new SecurityCenterProperties(this);
        }

        /// <summary>Field number for the "resource_name" field.</summary>
        public const int ResourceNameFieldNumber = 1;
        private string resourceName_ = "";
        /// <summary>
        /// The full resource name of the GCP resource this asset
        /// represents. This field is immutable after create time. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string ResourceName {
          get { return resourceName_; }
          set {
            resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "resource_type" field.</summary>
        public const int ResourceTypeFieldNumber = 2;
        private string resourceType_ = "";
        /// <summary>
        /// The type of the GCP resource. Examples include: APPLICATION,
        /// PROJECT, and ORGANIZATION. This is a case insensitive field defined by
        /// Cloud SCC and/or the producer of the resource and is immutable
        /// after create time.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string ResourceType {
          get { return resourceType_; }
          set {
            resourceType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "resource_parent" field.</summary>
        public const int ResourceParentFieldNumber = 3;
        private string resourceParent_ = "";
        /// <summary>
        /// The full resource name of the immediate parent of the resource. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string ResourceParent {
          get { return resourceParent_; }
          set {
            resourceParent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "resource_project" field.</summary>
        public const int ResourceProjectFieldNumber = 4;
        private string resourceProject_ = "";
        /// <summary>
        /// The full resource name of the project the resource belongs to. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string ResourceProject {
          get { return resourceProject_; }
          set {
            resourceProject_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "resource_owners" field.</summary>
        public const int ResourceOwnersFieldNumber = 5;
        private static readonly pb::FieldCodec<string> _repeated_resourceOwners_codec
            = pb::FieldCodec.ForString(42);
        private readonly pbc::RepeatedField<string> resourceOwners_ = new pbc::RepeatedField<string>();
        /// <summary>
        /// Owners of the Google Cloud resource.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<string> ResourceOwners {
          get { return resourceOwners_; }
        }

        /// <summary>Field number for the "resource_display_name" field.</summary>
        public const int ResourceDisplayNameFieldNumber = 6;
        private string resourceDisplayName_ = "";
        /// <summary>
        /// The user defined display name for this resource.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string ResourceDisplayName {
          get { return resourceDisplayName_; }
          set {
            resourceDisplayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "resource_parent_display_name" field.</summary>
        public const int ResourceParentDisplayNameFieldNumber = 7;
        private string resourceParentDisplayName_ = "";
        /// <summary>
        /// The user defined display name for the parent of this resource.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string ResourceParentDisplayName {
          get { return resourceParentDisplayName_; }
          set {
            resourceParentDisplayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "resource_project_display_name" field.</summary>
        public const int ResourceProjectDisplayNameFieldNumber = 8;
        private string resourceProjectDisplayName_ = "";
        /// <summary>
        /// The user defined display name for the project of this resource.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string ResourceProjectDisplayName {
          get { return resourceProjectDisplayName_; }
          set {
            resourceProjectDisplayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as SecurityCenterProperties);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(SecurityCenterProperties other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (ResourceName != other.ResourceName) return false;
          if (ResourceType != other.ResourceType) return false;
          if (ResourceParent != other.ResourceParent) return false;
          if (ResourceProject != other.ResourceProject) return false;
          if(!resourceOwners_.Equals(other.resourceOwners_)) return false;
          if (ResourceDisplayName != other.ResourceDisplayName) return false;
          if (ResourceParentDisplayName != other.ResourceParentDisplayName) return false;
          if (ResourceProjectDisplayName != other.ResourceProjectDisplayName) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
          if (ResourceType.Length != 0) hash ^= ResourceType.GetHashCode();
          if (ResourceParent.Length != 0) hash ^= ResourceParent.GetHashCode();
          if (ResourceProject.Length != 0) hash ^= ResourceProject.GetHashCode();
          hash ^= resourceOwners_.GetHashCode();
          if (ResourceDisplayName.Length != 0) hash ^= ResourceDisplayName.GetHashCode();
          if (ResourceParentDisplayName.Length != 0) hash ^= ResourceParentDisplayName.GetHashCode();
          if (ResourceProjectDisplayName.Length != 0) hash ^= ResourceProjectDisplayName.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (ResourceName.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(ResourceName);
          }
          if (ResourceType.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(ResourceType);
          }
          if (ResourceParent.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(ResourceParent);
          }
          if (ResourceProject.Length != 0) {
            output.WriteRawTag(34);
            output.WriteString(ResourceProject);
          }
          resourceOwners_.WriteTo(output, _repeated_resourceOwners_codec);
          if (ResourceDisplayName.Length != 0) {
            output.WriteRawTag(50);
            output.WriteString(ResourceDisplayName);
          }
          if (ResourceParentDisplayName.Length != 0) {
            output.WriteRawTag(58);
            output.WriteString(ResourceParentDisplayName);
          }
          if (ResourceProjectDisplayName.Length != 0) {
            output.WriteRawTag(66);
            output.WriteString(ResourceProjectDisplayName);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (ResourceName.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
          }
          if (ResourceType.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceType);
          }
          if (ResourceParent.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceParent);
          }
          if (ResourceProject.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceProject);
          }
          size += resourceOwners_.CalculateSize(_repeated_resourceOwners_codec);
          if (ResourceDisplayName.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceDisplayName);
          }
          if (ResourceParentDisplayName.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceParentDisplayName);
          }
          if (ResourceProjectDisplayName.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceProjectDisplayName);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(SecurityCenterProperties other) {
          if (other == null) {
            return;
          }
          if (other.ResourceName.Length != 0) {
            ResourceName = other.ResourceName;
          }
          if (other.ResourceType.Length != 0) {
            ResourceType = other.ResourceType;
          }
          if (other.ResourceParent.Length != 0) {
            ResourceParent = other.ResourceParent;
          }
          if (other.ResourceProject.Length != 0) {
            ResourceProject = other.ResourceProject;
          }
          resourceOwners_.Add(other.resourceOwners_);
          if (other.ResourceDisplayName.Length != 0) {
            ResourceDisplayName = other.ResourceDisplayName;
          }
          if (other.ResourceParentDisplayName.Length != 0) {
            ResourceParentDisplayName = other.ResourceParentDisplayName;
          }
          if (other.ResourceProjectDisplayName.Length != 0) {
            ResourceProjectDisplayName = other.ResourceProjectDisplayName;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                ResourceName = input.ReadString();
                break;
              }
              case 18: {
                ResourceType = input.ReadString();
                break;
              }
              case 26: {
                ResourceParent = input.ReadString();
                break;
              }
              case 34: {
                ResourceProject = input.ReadString();
                break;
              }
              case 42: {
                resourceOwners_.AddEntriesFrom(input, _repeated_resourceOwners_codec);
                break;
              }
              case 50: {
                ResourceDisplayName = input.ReadString();
                break;
              }
              case 58: {
                ResourceParentDisplayName = input.ReadString();
                break;
              }
              case 66: {
                ResourceProjectDisplayName = input.ReadString();
                break;
              }
            }
          }
        }

      }

      /// <summary>
      /// IAM Policy information associated with the GCP resource described by the
      /// Cloud SCC asset. This information is managed and defined by the GCP
      /// resource and cannot be modified by the user.
      /// </summary>
      public sealed partial class IamPolicy : pb::IMessage<IamPolicy> {
        private static readonly pb::MessageParser<IamPolicy> _parser = new pb::MessageParser<IamPolicy>(() => new IamPolicy());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<IamPolicy> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.SecurityCenter.V1P1Beta1.Asset.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public IamPolicy() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public IamPolicy(IamPolicy other) : this() {
          policyBlob_ = other.policyBlob_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public IamPolicy Clone() {
          return new IamPolicy(this);
        }

        /// <summary>Field number for the "policy_blob" field.</summary>
        public const int PolicyBlobFieldNumber = 1;
        private string policyBlob_ = "";
        /// <summary>
        /// The JSON representation of the Policy associated with the asset.
        /// See https://cloud.google.com/iam/reference/rest/v1p1beta1/Policy for
        /// format details.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string PolicyBlob {
          get { return policyBlob_; }
          set {
            policyBlob_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as IamPolicy);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(IamPolicy other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (PolicyBlob != other.PolicyBlob) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (PolicyBlob.Length != 0) hash ^= PolicyBlob.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (PolicyBlob.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(PolicyBlob);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (PolicyBlob.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(PolicyBlob);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(IamPolicy other) {
          if (other == null) {
            return;
          }
          if (other.PolicyBlob.Length != 0) {
            PolicyBlob = other.PolicyBlob;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                PolicyBlob = input.ReadString();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
