// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/appengine/v1/service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AppEngine.V1 {

  /// <summary>Holder for reflection information generated from google/appengine/v1/service.proto</summary>
  public static partial class ServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/appengine/v1/service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFnb29nbGUvYXBwZW5naW5lL3YxL3NlcnZpY2UucHJvdG8SE2dvb2dsZS5h",
            "cHBlbmdpbmUudjEaKmdvb2dsZS9hcHBlbmdpbmUvdjEvbmV0d29ya19zZXR0",
            "aW5ncy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKVAQoH",
            "U2VydmljZRIMCgRuYW1lGAEgASgJEgoKAmlkGAIgASgJEjAKBXNwbGl0GAMg",
            "ASgLMiEuZ29vZ2xlLmFwcGVuZ2luZS52MS5UcmFmZmljU3BsaXQSPgoQbmV0",
            "d29ya19zZXR0aW5ncxgGIAEoCzIkLmdvb2dsZS5hcHBlbmdpbmUudjEuTmV0",
            "d29ya1NldHRpbmdzIoQCCgxUcmFmZmljU3BsaXQSOwoIc2hhcmRfYnkYASAB",
            "KA4yKS5nb29nbGUuYXBwZW5naW5lLnYxLlRyYWZmaWNTcGxpdC5TaGFyZEJ5",
            "EkcKC2FsbG9jYXRpb25zGAIgAygLMjIuZ29vZ2xlLmFwcGVuZ2luZS52MS5U",
            "cmFmZmljU3BsaXQuQWxsb2NhdGlvbnNFbnRyeRoyChBBbGxvY2F0aW9uc0Vu",
            "dHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoAToCOAEiOgoHU2hhcmRC",
            "eRIPCgtVTlNQRUNJRklFRBAAEgoKBkNPT0tJRRABEgYKAklQEAISCgoGUkFO",
            "RE9NEANCvgEKF2NvbS5nb29nbGUuYXBwZW5naW5lLnYxQgxTZXJ2aWNlUHJv",
            "dG9QAVo8Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9h",
            "cHBlbmdpbmUvdjE7YXBwZW5naW5lqgIZR29vZ2xlLkNsb3VkLkFwcEVuZ2lu",
            "ZS5WMcoCGUdvb2dsZVxDbG91ZFxBcHBFbmdpbmVcVjHqAhxHb29nbGU6OkNs",
            "b3VkOjpBcHBFbmdpbmU6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.AppEngine.V1.NetworkSettingsReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AppEngine.V1.Service), global::Google.Cloud.AppEngine.V1.Service.Parser, new[]{ "Name", "Id", "Split", "NetworkSettings" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AppEngine.V1.TrafficSplit), global::Google.Cloud.AppEngine.V1.TrafficSplit.Parser, new[]{ "ShardBy", "Allocations" }, null, new[]{ typeof(global::Google.Cloud.AppEngine.V1.TrafficSplit.Types.ShardBy) }, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Service resource is a logical component of an application that can share
  /// state and communicate in a secure fashion with other services.
  /// For example, an application that handles customer requests might
  /// include separate services to handle tasks such as backend data
  /// analysis or API requests from mobile devices. Each service has a
  /// collection of versions that define a specific set of code used to
  /// implement the functionality of that service.
  /// </summary>
  public sealed partial class Service : pb::IMessage<Service>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Service> _parser = new pb::MessageParser<Service>(() => new Service());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Service> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AppEngine.V1.ServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Service() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Service(Service other) : this() {
      name_ = other.name_;
      id_ = other.id_;
      split_ = other.split_ != null ? other.split_.Clone() : null;
      networkSettings_ = other.networkSettings_ != null ? other.networkSettings_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Service Clone() {
      return new Service(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Full path to the Service resource in the API.
    /// Example: `apps/myapp/services/default`.
    ///
    /// @OutputOnly
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private string id_ = "";
    /// <summary>
    /// Relative name of the service within the application.
    /// Example: `default`.
    ///
    /// @OutputOnly
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "split" field.</summary>
    public const int SplitFieldNumber = 3;
    private global::Google.Cloud.AppEngine.V1.TrafficSplit split_;
    /// <summary>
    /// Mapping that defines fractional HTTP traffic diversion to
    /// different versions within the service.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AppEngine.V1.TrafficSplit Split {
      get { return split_; }
      set {
        split_ = value;
      }
    }

    /// <summary>Field number for the "network_settings" field.</summary>
    public const int NetworkSettingsFieldNumber = 6;
    private global::Google.Cloud.AppEngine.V1.NetworkSettings networkSettings_;
    /// <summary>
    /// Ingress settings for this service. Will apply to all versions.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AppEngine.V1.NetworkSettings NetworkSettings {
      get { return networkSettings_; }
      set {
        networkSettings_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Service);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Service other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Id != other.Id) return false;
      if (!object.Equals(Split, other.Split)) return false;
      if (!object.Equals(NetworkSettings, other.NetworkSettings)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (split_ != null) hash ^= Split.GetHashCode();
      if (networkSettings_ != null) hash ^= NetworkSettings.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (split_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Split);
      }
      if (networkSettings_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(NetworkSettings);
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
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (split_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Split);
      }
      if (networkSettings_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(NetworkSettings);
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
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (split_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Split);
      }
      if (networkSettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NetworkSettings);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Service other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.split_ != null) {
        if (split_ == null) {
          Split = new global::Google.Cloud.AppEngine.V1.TrafficSplit();
        }
        Split.MergeFrom(other.Split);
      }
      if (other.networkSettings_ != null) {
        if (networkSettings_ == null) {
          NetworkSettings = new global::Google.Cloud.AppEngine.V1.NetworkSettings();
        }
        NetworkSettings.MergeFrom(other.NetworkSettings);
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
            Id = input.ReadString();
            break;
          }
          case 26: {
            if (split_ == null) {
              Split = new global::Google.Cloud.AppEngine.V1.TrafficSplit();
            }
            input.ReadMessage(Split);
            break;
          }
          case 50: {
            if (networkSettings_ == null) {
              NetworkSettings = new global::Google.Cloud.AppEngine.V1.NetworkSettings();
            }
            input.ReadMessage(NetworkSettings);
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
            Id = input.ReadString();
            break;
          }
          case 26: {
            if (split_ == null) {
              Split = new global::Google.Cloud.AppEngine.V1.TrafficSplit();
            }
            input.ReadMessage(Split);
            break;
          }
          case 50: {
            if (networkSettings_ == null) {
              NetworkSettings = new global::Google.Cloud.AppEngine.V1.NetworkSettings();
            }
            input.ReadMessage(NetworkSettings);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Traffic routing configuration for versions within a single service. Traffic
  /// splits define how traffic directed to the service is assigned to versions.
  /// </summary>
  public sealed partial class TrafficSplit : pb::IMessage<TrafficSplit>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TrafficSplit> _parser = new pb::MessageParser<TrafficSplit>(() => new TrafficSplit());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TrafficSplit> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AppEngine.V1.ServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrafficSplit() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrafficSplit(TrafficSplit other) : this() {
      shardBy_ = other.shardBy_;
      allocations_ = other.allocations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrafficSplit Clone() {
      return new TrafficSplit(this);
    }

    /// <summary>Field number for the "shard_by" field.</summary>
    public const int ShardByFieldNumber = 1;
    private global::Google.Cloud.AppEngine.V1.TrafficSplit.Types.ShardBy shardBy_ = global::Google.Cloud.AppEngine.V1.TrafficSplit.Types.ShardBy.Unspecified;
    /// <summary>
    /// Mechanism used to determine which version a request is sent to.
    /// The traffic selection algorithm will
    /// be stable for either type until allocations are changed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AppEngine.V1.TrafficSplit.Types.ShardBy ShardBy {
      get { return shardBy_; }
      set {
        shardBy_ = value;
      }
    }

    /// <summary>Field number for the "allocations" field.</summary>
    public const int AllocationsFieldNumber = 2;
    private static readonly pbc::MapField<string, double>.Codec _map_allocations_codec
        = new pbc::MapField<string, double>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForDouble(17, 0D), 18);
    private readonly pbc::MapField<string, double> allocations_ = new pbc::MapField<string, double>();
    /// <summary>
    /// Mapping from version IDs within the service to fractional
    /// (0.000, 1] allocations of traffic for that version. Each version can
    /// be specified only once, but some versions in the service may not
    /// have any traffic allocation. Services that have traffic allocated
    /// cannot be deleted until either the service is deleted or
    /// their traffic allocation is removed. Allocations must sum to 1.
    /// Up to two decimal place precision is supported for IP-based splits and
    /// up to three decimal places is supported for cookie-based splits.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, double> Allocations {
      get { return allocations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TrafficSplit);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TrafficSplit other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ShardBy != other.ShardBy) return false;
      if (!Allocations.Equals(other.Allocations)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ShardBy != global::Google.Cloud.AppEngine.V1.TrafficSplit.Types.ShardBy.Unspecified) hash ^= ShardBy.GetHashCode();
      hash ^= Allocations.GetHashCode();
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
      if (ShardBy != global::Google.Cloud.AppEngine.V1.TrafficSplit.Types.ShardBy.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ShardBy);
      }
      allocations_.WriteTo(output, _map_allocations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ShardBy != global::Google.Cloud.AppEngine.V1.TrafficSplit.Types.ShardBy.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ShardBy);
      }
      allocations_.WriteTo(ref output, _map_allocations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ShardBy != global::Google.Cloud.AppEngine.V1.TrafficSplit.Types.ShardBy.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ShardBy);
      }
      size += allocations_.CalculateSize(_map_allocations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TrafficSplit other) {
      if (other == null) {
        return;
      }
      if (other.ShardBy != global::Google.Cloud.AppEngine.V1.TrafficSplit.Types.ShardBy.Unspecified) {
        ShardBy = other.ShardBy;
      }
      allocations_.Add(other.allocations_);
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
          case 8: {
            ShardBy = (global::Google.Cloud.AppEngine.V1.TrafficSplit.Types.ShardBy) input.ReadEnum();
            break;
          }
          case 18: {
            allocations_.AddEntriesFrom(input, _map_allocations_codec);
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
          case 8: {
            ShardBy = (global::Google.Cloud.AppEngine.V1.TrafficSplit.Types.ShardBy) input.ReadEnum();
            break;
          }
          case 18: {
            allocations_.AddEntriesFrom(ref input, _map_allocations_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the TrafficSplit message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Available sharding mechanisms.
      /// </summary>
      public enum ShardBy {
        /// <summary>
        /// Diversion method unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Diversion based on a specially named cookie, "GOOGAPPUID." The cookie
        /// must be set by the application itself or no diversion will occur.
        /// </summary>
        [pbr::OriginalName("COOKIE")] Cookie = 1,
        /// <summary>
        /// Diversion based on applying the modulus operation to a fingerprint
        /// of the IP address.
        /// </summary>
        [pbr::OriginalName("IP")] Ip = 2,
        /// <summary>
        /// Diversion based on weighted random assignment. An incoming request is
        /// randomly routed to a version in the traffic split, with probability
        /// proportional to the version's traffic share.
        /// </summary>
        [pbr::OriginalName("RANDOM")] Random = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
