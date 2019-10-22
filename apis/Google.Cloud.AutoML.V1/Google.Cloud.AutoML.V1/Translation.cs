// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/automl/v1/translation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AutoML.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/automl/v1/translation.proto</summary>
  public static partial class TranslationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/automl/v1/translation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TranslationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvY2xvdWQvYXV0b21sL3YxL3RyYW5zbGF0aW9uLnByb3RvEhZn",
            "b29nbGUuY2xvdWQuYXV0b21sLnYxGhxnb29nbGUvYXBpL2Fubm90YXRpb25z",
            "LnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGidnb29n",
            "bGUvY2xvdWQvYXV0b21sL3YxL2RhdGFfaXRlbXMucHJvdG8iYgoaVHJhbnNs",
            "YXRpb25EYXRhc2V0TWV0YWRhdGESIQoUc291cmNlX2xhbmd1YWdlX2NvZGUY",
            "ASABKAlCA+BBAhIhChR0YXJnZXRfbGFuZ3VhZ2VfY29kZRgCIAEoCUID4EEC",
            "IksKHFRyYW5zbGF0aW9uRXZhbHVhdGlvbk1ldHJpY3MSEgoKYmxldV9zY29y",
            "ZRgBIAEoARIXCg9iYXNlX2JsZXVfc2NvcmUYAiABKAEiagoYVHJhbnNsYXRp",
            "b25Nb2RlbE1ldGFkYXRhEhIKCmJhc2VfbW9kZWwYASABKAkSHAoUc291cmNl",
            "X2xhbmd1YWdlX2NvZGUYAiABKAkSHAoUdGFyZ2V0X2xhbmd1YWdlX2NvZGUY",
            "AyABKAkiWAoVVHJhbnNsYXRpb25Bbm5vdGF0aW9uEj8KEnRyYW5zbGF0ZWRf",
            "Y29udGVudBgBIAEoCzIjLmdvb2dsZS5jbG91ZC5hdXRvbWwudjEuVGV4dFNu",
            "aXBwZXRCvAEKGmNvbS5nb29nbGUuY2xvdWQuYXV0b21sLnYxQhBUcmFuc2xh",
            "dGlvblByb3RvUAFaPGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvY2xvdWQvYXV0b21sL3YxO2F1dG9tbKoCFkdvb2dsZS5DbG91ZC5B",
            "dXRvTUwuVjHKAhZHb29nbGVcQ2xvdWRcQXV0b01MXFYx6gIZR29vZ2xlOjpD",
            "bG91ZDo6QXV0b01MOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Cloud.AutoML.V1.DataItemsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.TranslationDatasetMetadata), global::Google.Cloud.AutoML.V1.TranslationDatasetMetadata.Parser, new[]{ "SourceLanguageCode", "TargetLanguageCode" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.TranslationEvaluationMetrics), global::Google.Cloud.AutoML.V1.TranslationEvaluationMetrics.Parser, new[]{ "BleuScore", "BaseBleuScore" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.TranslationModelMetadata), global::Google.Cloud.AutoML.V1.TranslationModelMetadata.Parser, new[]{ "BaseModel", "SourceLanguageCode", "TargetLanguageCode" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.TranslationAnnotation), global::Google.Cloud.AutoML.V1.TranslationAnnotation.Parser, new[]{ "TranslatedContent" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Dataset metadata that is specific to translation.
  /// </summary>
  public sealed partial class TranslationDatasetMetadata : pb::IMessage<TranslationDatasetMetadata> {
    private static readonly pb::MessageParser<TranslationDatasetMetadata> _parser = new pb::MessageParser<TranslationDatasetMetadata>(() => new TranslationDatasetMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TranslationDatasetMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.TranslationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TranslationDatasetMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TranslationDatasetMetadata(TranslationDatasetMetadata other) : this() {
      sourceLanguageCode_ = other.sourceLanguageCode_;
      targetLanguageCode_ = other.targetLanguageCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TranslationDatasetMetadata Clone() {
      return new TranslationDatasetMetadata(this);
    }

    /// <summary>Field number for the "source_language_code" field.</summary>
    public const int SourceLanguageCodeFieldNumber = 1;
    private string sourceLanguageCode_ = "";
    /// <summary>
    /// Required. The BCP-47 language code of the source language.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SourceLanguageCode {
      get { return sourceLanguageCode_; }
      set {
        sourceLanguageCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target_language_code" field.</summary>
    public const int TargetLanguageCodeFieldNumber = 2;
    private string targetLanguageCode_ = "";
    /// <summary>
    /// Required. The BCP-47 language code of the target language.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TargetLanguageCode {
      get { return targetLanguageCode_; }
      set {
        targetLanguageCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TranslationDatasetMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TranslationDatasetMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SourceLanguageCode != other.SourceLanguageCode) return false;
      if (TargetLanguageCode != other.TargetLanguageCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SourceLanguageCode.Length != 0) hash ^= SourceLanguageCode.GetHashCode();
      if (TargetLanguageCode.Length != 0) hash ^= TargetLanguageCode.GetHashCode();
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
      if (SourceLanguageCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SourceLanguageCode);
      }
      if (TargetLanguageCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TargetLanguageCode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SourceLanguageCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceLanguageCode);
      }
      if (TargetLanguageCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TargetLanguageCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TranslationDatasetMetadata other) {
      if (other == null) {
        return;
      }
      if (other.SourceLanguageCode.Length != 0) {
        SourceLanguageCode = other.SourceLanguageCode;
      }
      if (other.TargetLanguageCode.Length != 0) {
        TargetLanguageCode = other.TargetLanguageCode;
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
            SourceLanguageCode = input.ReadString();
            break;
          }
          case 18: {
            TargetLanguageCode = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Evaluation metrics for the dataset.
  /// </summary>
  public sealed partial class TranslationEvaluationMetrics : pb::IMessage<TranslationEvaluationMetrics> {
    private static readonly pb::MessageParser<TranslationEvaluationMetrics> _parser = new pb::MessageParser<TranslationEvaluationMetrics>(() => new TranslationEvaluationMetrics());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TranslationEvaluationMetrics> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.TranslationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TranslationEvaluationMetrics() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TranslationEvaluationMetrics(TranslationEvaluationMetrics other) : this() {
      bleuScore_ = other.bleuScore_;
      baseBleuScore_ = other.baseBleuScore_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TranslationEvaluationMetrics Clone() {
      return new TranslationEvaluationMetrics(this);
    }

    /// <summary>Field number for the "bleu_score" field.</summary>
    public const int BleuScoreFieldNumber = 1;
    private double bleuScore_;
    /// <summary>
    /// Output only. BLEU score.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double BleuScore {
      get { return bleuScore_; }
      set {
        bleuScore_ = value;
      }
    }

    /// <summary>Field number for the "base_bleu_score" field.</summary>
    public const int BaseBleuScoreFieldNumber = 2;
    private double baseBleuScore_;
    /// <summary>
    /// Output only. BLEU score for base model.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double BaseBleuScore {
      get { return baseBleuScore_; }
      set {
        baseBleuScore_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TranslationEvaluationMetrics);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TranslationEvaluationMetrics other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BleuScore, other.BleuScore)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(BaseBleuScore, other.BaseBleuScore)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BleuScore != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BleuScore);
      if (BaseBleuScore != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(BaseBleuScore);
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
      if (BleuScore != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(BleuScore);
      }
      if (BaseBleuScore != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(BaseBleuScore);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BleuScore != 0D) {
        size += 1 + 8;
      }
      if (BaseBleuScore != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TranslationEvaluationMetrics other) {
      if (other == null) {
        return;
      }
      if (other.BleuScore != 0D) {
        BleuScore = other.BleuScore;
      }
      if (other.BaseBleuScore != 0D) {
        BaseBleuScore = other.BaseBleuScore;
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
          case 9: {
            BleuScore = input.ReadDouble();
            break;
          }
          case 17: {
            BaseBleuScore = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Model metadata that is specific to translation.
  /// </summary>
  public sealed partial class TranslationModelMetadata : pb::IMessage<TranslationModelMetadata> {
    private static readonly pb::MessageParser<TranslationModelMetadata> _parser = new pb::MessageParser<TranslationModelMetadata>(() => new TranslationModelMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TranslationModelMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.TranslationReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TranslationModelMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TranslationModelMetadata(TranslationModelMetadata other) : this() {
      baseModel_ = other.baseModel_;
      sourceLanguageCode_ = other.sourceLanguageCode_;
      targetLanguageCode_ = other.targetLanguageCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TranslationModelMetadata Clone() {
      return new TranslationModelMetadata(this);
    }

    /// <summary>Field number for the "base_model" field.</summary>
    public const int BaseModelFieldNumber = 1;
    private string baseModel_ = "";
    /// <summary>
    /// The resource name of the model to use as a baseline to train the custom
    /// model. If unset, we use the default base model provided by Google
    /// Translate. Format:
    /// `projects/{project_id}/locations/{location_id}/models/{model_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BaseModel {
      get { return baseModel_; }
      set {
        baseModel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "source_language_code" field.</summary>
    public const int SourceLanguageCodeFieldNumber = 2;
    private string sourceLanguageCode_ = "";
    /// <summary>
    /// Output only. Inferred from the dataset.
    /// The source languge (The BCP-47 language code) that is used for training.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SourceLanguageCode {
      get { return sourceLanguageCode_; }
      set {
        sourceLanguageCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target_language_code" field.</summary>
    public const int TargetLanguageCodeFieldNumber = 3;
    private string targetLanguageCode_ = "";
    /// <summary>
    /// Output only. The target languge (The BCP-47 language code) that is used for
    /// training.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TargetLanguageCode {
      get { return targetLanguageCode_; }
      set {
        targetLanguageCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TranslationModelMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TranslationModelMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BaseModel != other.BaseModel) return false;
      if (SourceLanguageCode != other.SourceLanguageCode) return false;
      if (TargetLanguageCode != other.TargetLanguageCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BaseModel.Length != 0) hash ^= BaseModel.GetHashCode();
      if (SourceLanguageCode.Length != 0) hash ^= SourceLanguageCode.GetHashCode();
      if (TargetLanguageCode.Length != 0) hash ^= TargetLanguageCode.GetHashCode();
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
      if (BaseModel.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BaseModel);
      }
      if (SourceLanguageCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SourceLanguageCode);
      }
      if (TargetLanguageCode.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(TargetLanguageCode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BaseModel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BaseModel);
      }
      if (SourceLanguageCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceLanguageCode);
      }
      if (TargetLanguageCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TargetLanguageCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TranslationModelMetadata other) {
      if (other == null) {
        return;
      }
      if (other.BaseModel.Length != 0) {
        BaseModel = other.BaseModel;
      }
      if (other.SourceLanguageCode.Length != 0) {
        SourceLanguageCode = other.SourceLanguageCode;
      }
      if (other.TargetLanguageCode.Length != 0) {
        TargetLanguageCode = other.TargetLanguageCode;
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
            BaseModel = input.ReadString();
            break;
          }
          case 18: {
            SourceLanguageCode = input.ReadString();
            break;
          }
          case 26: {
            TargetLanguageCode = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Annotation details specific to translation.
  /// </summary>
  public sealed partial class TranslationAnnotation : pb::IMessage<TranslationAnnotation> {
    private static readonly pb::MessageParser<TranslationAnnotation> _parser = new pb::MessageParser<TranslationAnnotation>(() => new TranslationAnnotation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TranslationAnnotation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.TranslationReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TranslationAnnotation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TranslationAnnotation(TranslationAnnotation other) : this() {
      translatedContent_ = other.translatedContent_ != null ? other.translatedContent_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TranslationAnnotation Clone() {
      return new TranslationAnnotation(this);
    }

    /// <summary>Field number for the "translated_content" field.</summary>
    public const int TranslatedContentFieldNumber = 1;
    private global::Google.Cloud.AutoML.V1.TextSnippet translatedContent_;
    /// <summary>
    /// Output only . The translated content.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.TextSnippet TranslatedContent {
      get { return translatedContent_; }
      set {
        translatedContent_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TranslationAnnotation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TranslationAnnotation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TranslatedContent, other.TranslatedContent)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (translatedContent_ != null) hash ^= TranslatedContent.GetHashCode();
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
      if (translatedContent_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TranslatedContent);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (translatedContent_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TranslatedContent);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TranslationAnnotation other) {
      if (other == null) {
        return;
      }
      if (other.translatedContent_ != null) {
        if (translatedContent_ == null) {
          TranslatedContent = new global::Google.Cloud.AutoML.V1.TextSnippet();
        }
        TranslatedContent.MergeFrom(other.TranslatedContent);
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
            if (translatedContent_ == null) {
              TranslatedContent = new global::Google.Cloud.AutoML.V1.TextSnippet();
            }
            input.ReadMessage(TranslatedContent);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
