// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/automl/v1/prediction_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AutoML.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/automl/v1/prediction_service.proto</summary>
  public static partial class PredictionServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/automl/v1/prediction_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PredictionServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvY2xvdWQvYXV0b21sL3YxL3ByZWRpY3Rpb25fc2VydmljZS5w",
            "cm90bxIWZ29vZ2xlLmNsb3VkLmF1dG9tbC52MRocZ29vZ2xlL2FwaS9hbm5v",
            "dGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8aL2dvb2ds",
            "ZS9jbG91ZC9hdXRvbWwvdjEvYW5ub3RhdGlvbl9wYXlsb2FkLnByb3RvGidn",
            "b29nbGUvY2xvdWQvYXV0b21sL3YxL2RhdGFfaXRlbXMucHJvdG8aH2dvb2ds",
            "ZS9jbG91ZC9hdXRvbWwvdjEvaW8ucHJvdG8aJ2dvb2dsZS9jbG91ZC9hdXRv",
            "bWwvdjEvb3BlcmF0aW9ucy5wcm90bxojZ29vZ2xlL2xvbmdydW5uaW5nL29w",
            "ZXJhdGlvbnMucHJvdG8iygEKDlByZWRpY3RSZXF1ZXN0EgwKBG5hbWUYASAB",
            "KAkSNwoHcGF5bG9hZBgCIAEoCzImLmdvb2dsZS5jbG91ZC5hdXRvbWwudjEu",
            "RXhhbXBsZVBheWxvYWQSQgoGcGFyYW1zGAMgAygLMjIuZ29vZ2xlLmNsb3Vk",
            "LmF1dG9tbC52MS5QcmVkaWN0UmVxdWVzdC5QYXJhbXNFbnRyeRotCgtQYXJh",
            "bXNFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAk6AjgBIscBCg9Q",
            "cmVkaWN0UmVzcG9uc2USOgoHcGF5bG9hZBgBIAMoCzIpLmdvb2dsZS5jbG91",
            "ZC5hdXRvbWwudjEuQW5ub3RhdGlvblBheWxvYWQSRwoIbWV0YWRhdGEYAiAD",
            "KAsyNS5nb29nbGUuY2xvdWQuYXV0b21sLnYxLlByZWRpY3RSZXNwb25zZS5N",
            "ZXRhZGF0YUVudHJ5Gi8KDU1ldGFkYXRhRW50cnkSCwoDa2V5GAEgASgJEg0K",
            "BXZhbHVlGAIgASgJOgI4ATL6AQoRUHJlZGljdGlvblNlcnZpY2USmQEKB1By",
            "ZWRpY3QSJi5nb29nbGUuY2xvdWQuYXV0b21sLnYxLlByZWRpY3RSZXF1ZXN0",
            "GicuZ29vZ2xlLmNsb3VkLmF1dG9tbC52MS5QcmVkaWN0UmVzcG9uc2UiPYLT",
            "5JMCNyIyL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovbW9kZWxz",
            "Lyp9OnByZWRpY3Q6ASoaScpBFWF1dG9tbC5nb29nbGVhcGlzLmNvbdJBLmh0",
            "dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1dGgvY2xvdWQtcGxhdGZvcm1C",
            "wgEKGmNvbS5nb29nbGUuY2xvdWQuYXV0b21sLnYxQhZQcmVkaWN0aW9uU2Vy",
            "dmljZVByb3RvUAFaPGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvY2xvdWQvYXV0b21sL3YxO2F1dG9tbKoCFkdvb2dsZS5DbG91ZC5B",
            "dXRvTUwuVjHKAhZHb29nbGVcQ2xvdWRcQXV0b01MXFYx6gIZR29vZ2xlOjpD",
            "bG91ZDo6QXV0b01MOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Cloud.AutoML.V1.AnnotationPayloadReflection.Descriptor, global::Google.Cloud.AutoML.V1.DataItemsReflection.Descriptor, global::Google.Cloud.AutoML.V1.IoReflection.Descriptor, global::Google.Cloud.AutoML.V1.OperationsReflection.Descriptor, global::Google.LongRunning.OperationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.PredictRequest), global::Google.Cloud.AutoML.V1.PredictRequest.Parser, new[]{ "Name", "Payload", "Params" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.PredictResponse), global::Google.Cloud.AutoML.V1.PredictResponse.Parser, new[]{ "Payload", "Metadata" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for
  /// [PredictionService.Predict][google.cloud.automl.v1.PredictionService.Predict].
  /// </summary>
  public sealed partial class PredictRequest : pb::IMessage<PredictRequest> {
    private static readonly pb::MessageParser<PredictRequest> _parser = new pb::MessageParser<PredictRequest>(() => new PredictRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PredictRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.PredictionServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictRequest(PredictRequest other) : this() {
      name_ = other.name_;
      payload_ = other.payload_ != null ? other.payload_.Clone() : null;
      params_ = other.params_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictRequest Clone() {
      return new PredictRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Name of the model requested to serve the prediction.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 2;
    private global::Google.Cloud.AutoML.V1.ExamplePayload payload_;
    /// <summary>
    /// Required. Payload to perform a prediction on. The payload must match the
    /// problem type that the model was trained to solve.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.ExamplePayload Payload {
      get { return payload_; }
      set {
        payload_ = value;
      }
    }

    /// <summary>Field number for the "params" field.</summary>
    public const int ParamsFieldNumber = 3;
    private static readonly pbc::MapField<string, string>.Codec _map_params_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 26);
    private readonly pbc::MapField<string, string> params_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Additional domain-specific parameters, any string must be up to 25000
    /// characters long.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Params {
      get { return params_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PredictRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PredictRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(Payload, other.Payload)) return false;
      if (!Params.Equals(other.Params)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (payload_ != null) hash ^= Payload.GetHashCode();
      hash ^= Params.GetHashCode();
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
      if (payload_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Payload);
      }
      params_.WriteTo(output, _map_params_codec);
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
      if (payload_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Payload);
      }
      size += params_.CalculateSize(_map_params_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PredictRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.payload_ != null) {
        if (payload_ == null) {
          Payload = new global::Google.Cloud.AutoML.V1.ExamplePayload();
        }
        Payload.MergeFrom(other.Payload);
      }
      params_.Add(other.params_);
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
            if (payload_ == null) {
              Payload = new global::Google.Cloud.AutoML.V1.ExamplePayload();
            }
            input.ReadMessage(Payload);
            break;
          }
          case 26: {
            params_.AddEntriesFrom(input, _map_params_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Response message for
  /// [PredictionService.Predict][google.cloud.automl.v1.PredictionService.Predict].
  /// </summary>
  public sealed partial class PredictResponse : pb::IMessage<PredictResponse> {
    private static readonly pb::MessageParser<PredictResponse> _parser = new pb::MessageParser<PredictResponse>(() => new PredictResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PredictResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.PredictionServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictResponse(PredictResponse other) : this() {
      payload_ = other.payload_.Clone();
      metadata_ = other.metadata_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictResponse Clone() {
      return new PredictResponse(this);
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Cloud.AutoML.V1.AnnotationPayload> _repeated_payload_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Cloud.AutoML.V1.AnnotationPayload.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.AutoML.V1.AnnotationPayload> payload_ = new pbc::RepeatedField<global::Google.Cloud.AutoML.V1.AnnotationPayload>();
    /// <summary>
    /// Prediction result.
    /// Translation and Text Sentiment will return precisely one payload.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.AutoML.V1.AnnotationPayload> Payload {
      get { return payload_; }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 2;
    private static readonly pbc::MapField<string, string>.Codec _map_metadata_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 18);
    private readonly pbc::MapField<string, string> metadata_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Additional domain-specific prediction response metadata.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Metadata {
      get { return metadata_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PredictResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PredictResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!payload_.Equals(other.payload_)) return false;
      if (!Metadata.Equals(other.Metadata)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= payload_.GetHashCode();
      hash ^= Metadata.GetHashCode();
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
      payload_.WriteTo(output, _repeated_payload_codec);
      metadata_.WriteTo(output, _map_metadata_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += payload_.CalculateSize(_repeated_payload_codec);
      size += metadata_.CalculateSize(_map_metadata_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PredictResponse other) {
      if (other == null) {
        return;
      }
      payload_.Add(other.payload_);
      metadata_.Add(other.metadata_);
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
            payload_.AddEntriesFrom(input, _repeated_payload_codec);
            break;
          }
          case 18: {
            metadata_.AddEntriesFrom(input, _map_metadata_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
