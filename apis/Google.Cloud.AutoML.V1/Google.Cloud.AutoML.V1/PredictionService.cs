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
            "dGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8aGWdvb2ds",
            "ZS9hcGkvcmVzb3VyY2UucHJvdG8aL2dvb2dsZS9jbG91ZC9hdXRvbWwvdjEv",
            "YW5ub3RhdGlvbl9wYXlsb2FkLnByb3RvGidnb29nbGUvY2xvdWQvYXV0b21s",
            "L3YxL2RhdGFfaXRlbXMucHJvdG8aH2dvb2dsZS9jbG91ZC9hdXRvbWwvdjEv",
            "aW8ucHJvdG8aI2dvb2dsZS9sb25ncnVubmluZy9vcGVyYXRpb25zLnByb3Rv",
            "IsoBCg5QcmVkaWN0UmVxdWVzdBIMCgRuYW1lGAEgASgJEjcKB3BheWxvYWQY",
            "AiABKAsyJi5nb29nbGUuY2xvdWQuYXV0b21sLnYxLkV4YW1wbGVQYXlsb2Fk",
            "EkIKBnBhcmFtcxgDIAMoCzIyLmdvb2dsZS5jbG91ZC5hdXRvbWwudjEuUHJl",
            "ZGljdFJlcXVlc3QuUGFyYW1zRW50cnkaLQoLUGFyYW1zRW50cnkSCwoDa2V5",
            "GAEgASgJEg0KBXZhbHVlGAIgASgJOgI4ASKLAgoPUHJlZGljdFJlc3BvbnNl",
            "EjoKB3BheWxvYWQYASADKAsyKS5nb29nbGUuY2xvdWQuYXV0b21sLnYxLkFu",
            "bm90YXRpb25QYXlsb2FkEkIKEnByZXByb2Nlc3NlZF9pbnB1dBgDIAEoCzIm",
            "Lmdvb2dsZS5jbG91ZC5hdXRvbWwudjEuRXhhbXBsZVBheWxvYWQSRwoIbWV0",
            "YWRhdGEYAiADKAsyNS5nb29nbGUuY2xvdWQuYXV0b21sLnYxLlByZWRpY3RS",
            "ZXNwb25zZS5NZXRhZGF0YUVudHJ5Gi8KDU1ldGFkYXRhRW50cnkSCwoDa2V5",
            "GAEgASgJEg0KBXZhbHVlGAIgASgJOgI4ASKrAgoTQmF0Y2hQcmVkaWN0UmVx",
            "dWVzdBIMCgRuYW1lGAEgASgJEkUKDGlucHV0X2NvbmZpZxgDIAEoCzIvLmdv",
            "b2dsZS5jbG91ZC5hdXRvbWwudjEuQmF0Y2hQcmVkaWN0SW5wdXRDb25maWcS",
            "RwoNb3V0cHV0X2NvbmZpZxgEIAEoCzIwLmdvb2dsZS5jbG91ZC5hdXRvbWwu",
            "djEuQmF0Y2hQcmVkaWN0T3V0cHV0Q29uZmlnEkcKBnBhcmFtcxgFIAMoCzI3",
            "Lmdvb2dsZS5jbG91ZC5hdXRvbWwudjEuQmF0Y2hQcmVkaWN0UmVxdWVzdC5Q",
            "YXJhbXNFbnRyeRotCgtQYXJhbXNFbnRyeRILCgNrZXkYASABKAkSDQoFdmFs",
            "dWUYAiABKAk6AjgBIpEBChJCYXRjaFByZWRpY3RSZXN1bHQSSgoIbWV0YWRh",
            "dGEYASADKAsyOC5nb29nbGUuY2xvdWQuYXV0b21sLnYxLkJhdGNoUHJlZGlj",
            "dFJlc3VsdC5NZXRhZGF0YUVudHJ5Gi8KDU1ldGFkYXRhRW50cnkSCwoDa2V5",
            "GAEgASgJEg0KBXZhbHVlGAIgASgJOgI4ATKbAwoRUHJlZGljdGlvblNlcnZp",
            "Y2USmQEKB1ByZWRpY3QSJi5nb29nbGUuY2xvdWQuYXV0b21sLnYxLlByZWRp",
            "Y3RSZXF1ZXN0GicuZ29vZ2xlLmNsb3VkLmF1dG9tbC52MS5QcmVkaWN0UmVz",
            "cG9uc2UiPYLT5JMCNyIyL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25z",
            "LyovbW9kZWxzLyp9OnByZWRpY3Q6ASoSngEKDEJhdGNoUHJlZGljdBIrLmdv",
            "b2dsZS5jbG91ZC5hdXRvbWwudjEuQmF0Y2hQcmVkaWN0UmVxdWVzdBodLmdv",
            "b2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24iQoLT5JMCPCI3L3YxL3tuYW1l",
            "PXByb2plY3RzLyovbG9jYXRpb25zLyovbW9kZWxzLyp9OmJhdGNoUHJlZGlj",
            "dDoBKhpJykEVYXV0b21sLmdvb2dsZWFwaXMuY29t0kEuaHR0cHM6Ly93d3cu",
            "Z29vZ2xlYXBpcy5jb20vYXV0aC9jbG91ZC1wbGF0Zm9ybULCAQoaY29tLmdv",
            "b2dsZS5jbG91ZC5hdXRvbWwudjFCFlByZWRpY3Rpb25TZXJ2aWNlUHJvdG9Q",
            "AVo8Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91",
            "ZC9hdXRvbWwvdjE7YXV0b21sqgIWR29vZ2xlLkNsb3VkLkF1dG9NTC5WMcoC",
            "Fkdvb2dsZVxDbG91ZFxBdXRvTWxcVjHqAhlHb29nbGU6OkNsb3VkOjpBdXRv",
            "TUw6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.AutoML.V1.AnnotationPayloadReflection.Descriptor, global::Google.Cloud.AutoML.V1.DataItemsReflection.Descriptor, global::Google.Cloud.AutoML.V1.IoReflection.Descriptor, global::Google.LongRunning.OperationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.PredictRequest), global::Google.Cloud.AutoML.V1.PredictRequest.Parser, new[]{ "Name", "Payload", "Params" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.PredictResponse), global::Google.Cloud.AutoML.V1.PredictResponse.Parser, new[]{ "Payload", "PreprocessedInput", "Metadata" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.BatchPredictRequest), global::Google.Cloud.AutoML.V1.BatchPredictRequest.Parser, new[]{ "Name", "InputConfig", "OutputConfig", "Params" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.BatchPredictResult), global::Google.Cloud.AutoML.V1.BatchPredictResult.Parser, new[]{ "Metadata" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
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
    ///
    /// *  For Image Classification:
    ///
    ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
    ///     makes predictions for an image, it will only produce results that have
    ///     at least this confidence score. The default is 0.5.
    ///
    ///  *  For Image Object Detection:
    ///    `score_threshold` - (float) When Model detects objects on the image,
    ///        it will only produce bounding boxes which have at least this
    ///        confidence score. Value in 0 to 1 range, default is 0.5.
    ///    `max_bounding_box_count` - (int64) No more than this number of bounding
    ///        boxes will be returned in the response. Default is 100, the
    ///        requested value may be limited by server.
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
      preprocessedInput_ = other.preprocessedInput_ != null ? other.preprocessedInput_.Clone() : null;
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

    /// <summary>Field number for the "preprocessed_input" field.</summary>
    public const int PreprocessedInputFieldNumber = 3;
    private global::Google.Cloud.AutoML.V1.ExamplePayload preprocessedInput_;
    /// <summary>
    /// The preprocessed example that AutoML actually makes prediction on.
    /// Empty if AutoML does not preprocess the input example.
    /// * For Text Extraction:
    ///   If the input is a .pdf file, the OCR'ed text will be provided in
    ///   [document_text][google.cloud.automl.v1.Document.document_text].
    ///
    /// * For Text Classification:
    ///   If the input is a .pdf file, the OCR'ed trucated text will be provided in
    ///   [document_text][google.cloud.automl.v1.Document.document_text].
    ///
    /// * For Text Sentiment:
    ///   If the input is a .pdf file, the OCR'ed trucated text will be provided in
    ///   [document_text][google.cloud.automl.v1.Document.document_text].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.ExamplePayload PreprocessedInput {
      get { return preprocessedInput_; }
      set {
        preprocessedInput_ = value;
      }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 2;
    private static readonly pbc::MapField<string, string>.Codec _map_metadata_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 18);
    private readonly pbc::MapField<string, string> metadata_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Additional domain-specific prediction response metadata.
    ///
    /// * For Image Object Detection:
    ///  `max_bounding_box_count` - (int64) At most that many bounding boxes per
    ///      image could have been returned.
    ///
    /// * For Text Sentiment:
    ///  `sentiment_score` - (float, deprecated) A value between -1 and 1,
    ///      -1 maps to least positive sentiment, while 1 maps to the most positive
    ///      one and the higher the score, the more positive the sentiment in the
    ///      document is. Yet these values are relative to the training data, so
    ///      e.g. if all data was positive then -1 will be also positive (though
    ///      the least).
    ///      The sentiment_score shouldn't be confused with "score" or "magnitude"
    ///      from the previous Natural Language Sentiment Analysis API.
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
      if (!object.Equals(PreprocessedInput, other.PreprocessedInput)) return false;
      if (!Metadata.Equals(other.Metadata)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= payload_.GetHashCode();
      if (preprocessedInput_ != null) hash ^= PreprocessedInput.GetHashCode();
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
      if (preprocessedInput_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PreprocessedInput);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += payload_.CalculateSize(_repeated_payload_codec);
      if (preprocessedInput_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PreprocessedInput);
      }
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
      if (other.preprocessedInput_ != null) {
        if (preprocessedInput_ == null) {
          PreprocessedInput = new global::Google.Cloud.AutoML.V1.ExamplePayload();
        }
        PreprocessedInput.MergeFrom(other.PreprocessedInput);
      }
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
          case 26: {
            if (preprocessedInput_ == null) {
              PreprocessedInput = new global::Google.Cloud.AutoML.V1.ExamplePayload();
            }
            input.ReadMessage(PreprocessedInput);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Request message for
  /// [PredictionService.BatchPredict][google.cloud.automl.v1.PredictionService.BatchPredict].
  /// </summary>
  public sealed partial class BatchPredictRequest : pb::IMessage<BatchPredictRequest> {
    private static readonly pb::MessageParser<BatchPredictRequest> _parser = new pb::MessageParser<BatchPredictRequest>(() => new BatchPredictRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BatchPredictRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.PredictionServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BatchPredictRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BatchPredictRequest(BatchPredictRequest other) : this() {
      name_ = other.name_;
      inputConfig_ = other.inputConfig_ != null ? other.inputConfig_.Clone() : null;
      outputConfig_ = other.outputConfig_ != null ? other.outputConfig_.Clone() : null;
      params_ = other.params_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BatchPredictRequest Clone() {
      return new BatchPredictRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Name of the model requested to serve the batch prediction.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "input_config" field.</summary>
    public const int InputConfigFieldNumber = 3;
    private global::Google.Cloud.AutoML.V1.BatchPredictInputConfig inputConfig_;
    /// <summary>
    /// Required. The input configuration for batch prediction.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.BatchPredictInputConfig InputConfig {
      get { return inputConfig_; }
      set {
        inputConfig_ = value;
      }
    }

    /// <summary>Field number for the "output_config" field.</summary>
    public const int OutputConfigFieldNumber = 4;
    private global::Google.Cloud.AutoML.V1.BatchPredictOutputConfig outputConfig_;
    /// <summary>
    /// Required. The Configuration specifying where output predictions should
    /// be written.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.BatchPredictOutputConfig OutputConfig {
      get { return outputConfig_; }
      set {
        outputConfig_ = value;
      }
    }

    /// <summary>Field number for the "params" field.</summary>
    public const int ParamsFieldNumber = 5;
    private static readonly pbc::MapField<string, string>.Codec _map_params_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 42);
    private readonly pbc::MapField<string, string> params_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Additional domain-specific parameters for the predictions, any string must
    /// be up to 25000 characters long.
    ///
    /// *  For Text Classification:
    ///
    ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
    ///         makes predictions for a text snippet, it will only produce results
    ///         that have at least this confidence score. The default is 0.5.
    ///
    /// *  For Image Classification:
    ///
    ///    `score_threshold` - (float) A value from 0.0 to 1.0. When the model
    ///         makes predictions for an image, it will only produce results that
    ///         have at least this confidence score. The default is 0.5.
    ///
    /// *  For Image Object Detection:
    ///
    ///    `score_threshold` - (float) When Model detects objects on the image,
    ///        it will only produce bounding boxes which have at least this
    ///        confidence score. Value in 0 to 1 range, default is 0.5.
    ///    `max_bounding_box_count` - (int64) No more than this number of bounding
    ///        boxes will be produced per image. Default is 100, the
    ///        requested value may be limited by server.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Params {
      get { return params_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BatchPredictRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BatchPredictRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(InputConfig, other.InputConfig)) return false;
      if (!object.Equals(OutputConfig, other.OutputConfig)) return false;
      if (!Params.Equals(other.Params)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (inputConfig_ != null) hash ^= InputConfig.GetHashCode();
      if (outputConfig_ != null) hash ^= OutputConfig.GetHashCode();
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
      if (inputConfig_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(InputConfig);
      }
      if (outputConfig_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(OutputConfig);
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
      if (inputConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InputConfig);
      }
      if (outputConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OutputConfig);
      }
      size += params_.CalculateSize(_map_params_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BatchPredictRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.inputConfig_ != null) {
        if (inputConfig_ == null) {
          InputConfig = new global::Google.Cloud.AutoML.V1.BatchPredictInputConfig();
        }
        InputConfig.MergeFrom(other.InputConfig);
      }
      if (other.outputConfig_ != null) {
        if (outputConfig_ == null) {
          OutputConfig = new global::Google.Cloud.AutoML.V1.BatchPredictOutputConfig();
        }
        OutputConfig.MergeFrom(other.OutputConfig);
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
          case 26: {
            if (inputConfig_ == null) {
              InputConfig = new global::Google.Cloud.AutoML.V1.BatchPredictInputConfig();
            }
            input.ReadMessage(InputConfig);
            break;
          }
          case 34: {
            if (outputConfig_ == null) {
              OutputConfig = new global::Google.Cloud.AutoML.V1.BatchPredictOutputConfig();
            }
            input.ReadMessage(OutputConfig);
            break;
          }
          case 42: {
            params_.AddEntriesFrom(input, _map_params_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Result of the Batch Predict. This message is returned in
  /// [response][google.longrunning.Operation.response] of the operation returned
  /// by the
  /// [PredictionService.BatchPredict][google.cloud.automl.v1.PredictionService.BatchPredict].
  /// </summary>
  public sealed partial class BatchPredictResult : pb::IMessage<BatchPredictResult> {
    private static readonly pb::MessageParser<BatchPredictResult> _parser = new pb::MessageParser<BatchPredictResult>(() => new BatchPredictResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BatchPredictResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.PredictionServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BatchPredictResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BatchPredictResult(BatchPredictResult other) : this() {
      metadata_ = other.metadata_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BatchPredictResult Clone() {
      return new BatchPredictResult(this);
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 1;
    private static readonly pbc::MapField<string, string>.Codec _map_metadata_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 10);
    private readonly pbc::MapField<string, string> metadata_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Additional domain-specific prediction response metadata.
    ///
    /// *  For Image Object Detection:
    ///  `max_bounding_box_count` - (int64) At most that many bounding boxes per
    ///      image could have been returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Metadata {
      get { return metadata_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BatchPredictResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BatchPredictResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Metadata.Equals(other.Metadata)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      metadata_.WriteTo(output, _map_metadata_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += metadata_.CalculateSize(_map_metadata_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BatchPredictResult other) {
      if (other == null) {
        return;
      }
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
