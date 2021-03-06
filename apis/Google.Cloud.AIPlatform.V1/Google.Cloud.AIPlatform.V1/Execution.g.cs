// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/execution.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/execution.proto</summary>
  public static partial class ExecutionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/execution.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExecutionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cipnb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9leGVjdXRpb24ucHJvdG8S",
            "Gmdvb2dsZS5jbG91ZC5haXBsYXRmb3JtLnYxGh9nb29nbGUvYXBpL2ZpZWxk",
            "X2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGiZn",
            "b29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS92YWx1ZS5wcm90bxocZ29vZ2xl",
            "L3Byb3RvYnVmL3N0cnVjdC5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVz",
            "dGFtcC5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLTBAoJ",
            "RXhlY3V0aW9uEhEKBG5hbWUYASABKAlCA+BBAxIUCgxkaXNwbGF5X25hbWUY",
            "AiABKAkSOgoFc3RhdGUYBiABKA4yKy5nb29nbGUuY2xvdWQuYWlwbGF0Zm9y",
            "bS52MS5FeGVjdXRpb24uU3RhdGUSDAoEZXRhZxgJIAEoCRJBCgZsYWJlbHMY",
            "CiADKAsyMS5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MS5FeGVjdXRpb24u",
            "TGFiZWxzRW50cnkSNAoLY3JlYXRlX3RpbWUYCyABKAsyGi5nb29nbGUucHJv",
            "dG9idWYuVGltZXN0YW1wQgPgQQMSNAoLdXBkYXRlX3RpbWUYDCABKAsyGi5n",
            "b29nbGUucHJvdG9idWYuVGltZXN0YW1wQgPgQQMaLQoLTGFiZWxzRW50cnkS",
            "CwoDa2V5GAEgASgJEg0KBXZhbHVlGAIgASgJOgI4ASJpCgVTdGF0ZRIVChFT",
            "VEFURV9VTlNQRUNJRklFRBAAEgcKA05FVxABEgsKB1JVTk5JTkcQAhIMCghD",
            "T01QTEVURRADEgoKBkZBSUxFRBAEEgoKBkNBQ0hFRBAFEg0KCUNBTkNFTExF",
            "RBAGOokB6kGFAQojYWlwbGF0Zm9ybS5nb29nbGVhcGlzLmNvbS9FeGVjdXRp",
            "b24SXnByb2plY3RzL3twcm9qZWN0fS9sb2NhdGlvbnMve2xvY2F0aW9ufS9t",
            "ZXRhZGF0YVN0b3Jlcy97bWV0YWRhdGFfc3RvcmV9L2V4ZWN1dGlvbnMve2V4",
            "ZWN1dGlvbn1C0gEKHmNvbS5nb29nbGUuY2xvdWQuYWlwbGF0Zm9ybS52MUIO",
            "RXhlY3V0aW9uUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9jbG91ZC9haXBsYXRmb3JtL3YxO2FpcGxhdGZvcm2qAhpH",
            "b29nbGUuQ2xvdWQuQUlQbGF0Zm9ybS5WMcoCGkdvb2dsZVxDbG91ZFxBSVBs",
            "YXRmb3JtXFYx6gIdR29vZ2xlOjpDbG91ZDo6QUlQbGF0Zm9ybTo6VjFiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.AIPlatform.V1.ValueReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Execution), global::Google.Cloud.AIPlatform.V1.Execution.Parser, new[]{ "Name", "DisplayName", "State", "Etag", "Labels", "CreateTime", "UpdateTime" }, null, new[]{ typeof(global::Google.Cloud.AIPlatform.V1.Execution.Types.State) }, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Instance of a general execution.
  /// </summary>
  public sealed partial class Execution : pb::IMessage<Execution>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Execution> _parser = new pb::MessageParser<Execution>(() => new Execution());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Execution> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.ExecutionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Execution() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Execution(Execution other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      state_ = other.state_;
      etag_ = other.etag_;
      labels_ = other.labels_.Clone();
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Execution Clone() {
      return new Execution(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. The resource name of the Execution.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// User provided display name of the Execution.
    /// May be up to 128 Unicode characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 6;
    private global::Google.Cloud.AIPlatform.V1.Execution.Types.State state_ = global::Google.Cloud.AIPlatform.V1.Execution.Types.State.Unspecified;
    /// <summary>
    /// The state of this Execution. This is a property of the Execution, and does
    /// not imply or capture any ongoing process. This property is managed by
    /// clients (such as Vertex Pipelines) and the system does not prescribe
    /// or check the validity of state transitions.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AIPlatform.V1.Execution.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 9;
    private string etag_ = "";
    /// <summary>
    /// An eTag used to perform consistent read-modify-write updates. If not set, a
    /// blind "overwrite" update happens.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Etag {
      get { return etag_; }
      set {
        etag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 10;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 82);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// The labels with user-defined metadata to organize your Executions.
    ///
    /// Label keys and values can be no longer than 64 characters
    /// (Unicode codepoints), can only contain lowercase letters, numeric
    /// characters, underscores and dashes. International characters are allowed.
    /// No more than 64 user labels can be associated with one Execution (System
    /// labels are excluded).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 11;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when this Execution was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 12;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. Timestamp when this Execution was last updated.
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
      return Equals(other as Execution);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Execution other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (State != other.State) return false;
      if (Etag != other.Etag) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (State != global::Google.Cloud.AIPlatform.V1.Execution.Types.State.Unspecified) hash ^= State.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
      hash ^= Labels.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (State != global::Google.Cloud.AIPlatform.V1.Execution.Types.State.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) State);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Etag);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (createTime_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(UpdateTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (State != global::Google.Cloud.AIPlatform.V1.Execution.Types.State.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) State);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Etag);
      }
      labels_.WriteTo(ref output, _map_labels_codec);
      if (createTime_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(UpdateTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (State != global::Google.Cloud.AIPlatform.V1.Execution.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (Etag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Etag);
      }
      size += labels_.CalculateSize(_map_labels_codec);
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
    public void MergeFrom(Execution other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.State != global::Google.Cloud.AIPlatform.V1.Execution.Types.State.Unspecified) {
        State = other.State;
      }
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
      }
      labels_.Add(other.labels_);
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
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
            DisplayName = input.ReadString();
            break;
          }
          case 48: {
            State = (global::Google.Cloud.AIPlatform.V1.Execution.Types.State) input.ReadEnum();
            break;
          }
          case 74: {
            Etag = input.ReadString();
            break;
          }
          case 82: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 90: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 98: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 48: {
            State = (global::Google.Cloud.AIPlatform.V1.Execution.Types.State) input.ReadEnum();
            break;
          }
          case 74: {
            Etag = input.ReadString();
            break;
          }
          case 82: {
            labels_.AddEntriesFrom(ref input, _map_labels_codec);
            break;
          }
          case 90: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 98: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Execution message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Describes the state of the Execution.
      /// </summary>
      public enum State {
        /// <summary>
        /// Unspecified Execution state
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The Execution is new
        /// </summary>
        [pbr::OriginalName("NEW")] New = 1,
        /// <summary>
        /// The Execution is running
        /// </summary>
        [pbr::OriginalName("RUNNING")] Running = 2,
        /// <summary>
        /// The Execution has finished running
        /// </summary>
        [pbr::OriginalName("COMPLETE")] Complete = 3,
        /// <summary>
        /// The Execution has failed
        /// </summary>
        [pbr::OriginalName("FAILED")] Failed = 4,
        /// <summary>
        /// The Execution completed through Cache hit.
        /// </summary>
        [pbr::OriginalName("CACHED")] Cached = 5,
        /// <summary>
        /// The Execution was cancelled.
        /// </summary>
        [pbr::OriginalName("CANCELLED")] Cancelled = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
