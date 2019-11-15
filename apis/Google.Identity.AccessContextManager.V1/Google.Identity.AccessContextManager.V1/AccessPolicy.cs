// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/identity/accesscontextmanager/v1/access_policy.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Identity.AccessContextManager.V1 {

  /// <summary>Holder for reflection information generated from google/identity/accesscontextmanager/v1/access_policy.proto</summary>
  public static partial class AccessPolicyReflection {

    #region Descriptor
    /// <summary>File descriptor for google/identity/accesscontextmanager/v1/access_policy.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AccessPolicyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvaWRlbnRpdHkvYWNjZXNzY29udGV4dG1hbmFnZXIvdjEvYWNj",
            "ZXNzX3BvbGljeS5wcm90bxInZ29vZ2xlLmlkZW50aXR5LmFjY2Vzc2NvbnRl",
            "eHRtYW5hZ2VyLnYxGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3Rv",
            "Ghxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIp0BCgxBY2Nlc3NQb2xp",
            "Y3kSDAoEbmFtZRgBIAEoCRIOCgZwYXJlbnQYAiABKAkSDQoFdGl0bGUYAyAB",
            "KAkSLwoLY3JlYXRlX3RpbWUYBCABKAsyGi5nb29nbGUucHJvdG9idWYuVGlt",
            "ZXN0YW1wEi8KC3VwZGF0ZV90aW1lGAUgASgLMhouZ29vZ2xlLnByb3RvYnVm",
            "LlRpbWVzdGFtcELKAQorY29tLmdvb2dsZS5pZGVudGl0eS5hY2Nlc3Njb250",
            "ZXh0bWFuYWdlci52MUILUG9saWN5UHJvdG9QAVpbZ29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9pZGVudGl0eS9hY2Nlc3Njb250ZXh0",
            "bWFuYWdlci92MTthY2Nlc3Njb250ZXh0bWFuYWdlcqICBEdBQ02qAidHb29n",
            "bGUuSWRlbnRpdHkuQWNjZXNzQ29udGV4dE1hbmFnZXIuVjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Identity.AccessContextManager.V1.AccessPolicy), global::Google.Identity.AccessContextManager.V1.AccessPolicy.Parser, new[]{ "Name", "Parent", "Title", "CreateTime", "UpdateTime" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// `AccessPolicy` is a container for `AccessLevels` (which define the necessary
  /// attributes to use GCP services) and `ServicePerimeters` (which define regions
  /// of services able to freely pass data within a perimeter). An access policy is
  /// globally visible within an organization, and the restrictions it specifies
  /// apply to all projects within an organization.
  /// </summary>
  public sealed partial class AccessPolicy : pb::IMessage<AccessPolicy> {
    private static readonly pb::MessageParser<AccessPolicy> _parser = new pb::MessageParser<AccessPolicy>(() => new AccessPolicy());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AccessPolicy> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Identity.AccessContextManager.V1.AccessPolicyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccessPolicy() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccessPolicy(AccessPolicy other) : this() {
      name_ = other.name_;
      parent_ = other.parent_;
      title_ = other.title_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccessPolicy Clone() {
      return new AccessPolicy(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. Resource name of the `AccessPolicy`. Format:
    /// `accessPolicies/{policy_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "parent" field.</summary>
    public const int ParentFieldNumber = 2;
    private string parent_ = "";
    /// <summary>
    /// Required. The parent of this `AccessPolicy` in the Cloud Resource
    /// Hierarchy. Currently immutable once created. Format:
    /// `organizations/{organization_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Parent {
      get { return parent_; }
      set {
        parent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 3;
    private string title_ = "";
    /// <summary>
    /// Required. Human readable title. Does not affect behavior.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Time the `AccessPolicy` was created in UTC.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. Time the `AccessPolicy` was updated in UTC.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AccessPolicy);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AccessPolicy other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Parent != other.Parent) return false;
      if (Title != other.Title) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Parent.Length != 0) hash ^= Parent.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
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
      if (Parent.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Parent);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Title);
      }
      if (createTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(UpdateTime);
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
      if (Parent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Parent);
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AccessPolicy other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Parent.Length != 0) {
        Parent = other.Parent;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
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
            Parent = input.ReadString();
            break;
          }
          case 26: {
            Title = input.ReadString();
            break;
          }
          case 34: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 42: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
