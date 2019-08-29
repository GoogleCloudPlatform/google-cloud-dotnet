// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/automl/v1/model_evaluation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Automl.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/automl/v1/model_evaluation.proto</summary>
  public static partial class ModelEvaluationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/automl/v1/model_evaluation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ModelEvaluationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvY2xvdWQvYXV0b21sL3YxL21vZGVsX2V2YWx1YXRpb24ucHJv",
            "dG8SFmdvb2dsZS5jbG91ZC5hdXRvbWwudjEaKGdvb2dsZS9jbG91ZC9hdXRv",
            "bWwvdjEvdHJhbnNsYXRpb24ucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1l",
            "c3RhbXAucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i+AEK",
            "D01vZGVsRXZhbHVhdGlvbhJeCh50cmFuc2xhdGlvbl9ldmFsdWF0aW9uX21l",
            "dHJpY3MYCSABKAsyNC5nb29nbGUuY2xvdWQuYXV0b21sLnYxLlRyYW5zbGF0",
            "aW9uRXZhbHVhdGlvbk1ldHJpY3NIABIMCgRuYW1lGAEgASgJEhoKEmFubm90",
            "YXRpb25fc3BlY19pZBgCIAEoCRIvCgtjcmVhdGVfdGltZRgFIAEoCzIaLmdv",
            "b2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASHwoXZXZhbHVhdGVkX2V4YW1wbGVf",
            "Y291bnQYBiABKAVCCQoHbWV0cmljc0KRAQoaY29tLmdvb2dsZS5jbG91ZC5h",
            "dXRvbWwudjFQAVo8Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9jbG91ZC9hdXRvbWwvdjE7YXV0b21sygIWR29vZ2xlXENsb3VkXEF1",
            "dG9NbFxWMeoCGUdvb2dsZTo6Q2xvdWQ6OkF1dG9NTDo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.Automl.V1.TranslationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Automl.V1.ModelEvaluation), global::Google.Cloud.Automl.V1.ModelEvaluation.Parser, new[]{ "TranslationEvaluationMetrics", "Name", "AnnotationSpecId", "CreateTime", "EvaluatedExampleCount" }, new[]{ "Metrics" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Evaluation results of a model.
  /// </summary>
  public sealed partial class ModelEvaluation : pb::IMessage<ModelEvaluation> {
    private static readonly pb::MessageParser<ModelEvaluation> _parser = new pb::MessageParser<ModelEvaluation>(() => new ModelEvaluation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ModelEvaluation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Automl.V1.ModelEvaluationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ModelEvaluation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ModelEvaluation(ModelEvaluation other) : this() {
      name_ = other.name_;
      annotationSpecId_ = other.annotationSpecId_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      evaluatedExampleCount_ = other.evaluatedExampleCount_;
      switch (other.MetricsCase) {
        case MetricsOneofCase.TranslationEvaluationMetrics:
          TranslationEvaluationMetrics = other.TranslationEvaluationMetrics.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ModelEvaluation Clone() {
      return new ModelEvaluation(this);
    }

    /// <summary>Field number for the "translation_evaluation_metrics" field.</summary>
    public const int TranslationEvaluationMetricsFieldNumber = 9;
    /// <summary>
    /// Model evaluation metrics for translation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Automl.V1.TranslationEvaluationMetrics TranslationEvaluationMetrics {
      get { return metricsCase_ == MetricsOneofCase.TranslationEvaluationMetrics ? (global::Google.Cloud.Automl.V1.TranslationEvaluationMetrics) metrics_ : null; }
      set {
        metrics_ = value;
        metricsCase_ = value == null ? MetricsOneofCase.None : MetricsOneofCase.TranslationEvaluationMetrics;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. Resource name of the model evaluation.
    /// Format:
    ///
    /// `projects/{project_id}/locations/{location_id}/models/{model_id}/modelEvaluations/{model_evaluation_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "annotation_spec_id" field.</summary>
    public const int AnnotationSpecIdFieldNumber = 2;
    private string annotationSpecId_ = "";
    /// <summary>
    /// Output only. The ID of the annotation spec that the model evaluation applies to. The
    /// The ID is empty for the overall model evaluation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AnnotationSpecId {
      get { return annotationSpecId_; }
      set {
        annotationSpecId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when this model evaluation was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "evaluated_example_count" field.</summary>
    public const int EvaluatedExampleCountFieldNumber = 6;
    private int evaluatedExampleCount_;
    /// <summary>
    /// Output only. The number of examples used for model evaluation, i.e. for
    /// which ground truth from time of model creation is compared against the
    /// predicted annotations created by the model.
    /// For overall ModelEvaluation (i.e. with annotation_spec_id not set) this is
    /// the total number of all examples used for evaluation.
    /// Otherwise, this is the count of examples that according to the ground
    /// truth were annotated by the
    ///
    /// [annotation_spec_id][google.cloud.automl.v1beta1.ModelEvaluation.annotation_spec_id].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EvaluatedExampleCount {
      get { return evaluatedExampleCount_; }
      set {
        evaluatedExampleCount_ = value;
      }
    }

    private object metrics_;
    /// <summary>Enum of possible cases for the "metrics" oneof.</summary>
    public enum MetricsOneofCase {
      None = 0,
      TranslationEvaluationMetrics = 9,
    }
    private MetricsOneofCase metricsCase_ = MetricsOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MetricsOneofCase MetricsCase {
      get { return metricsCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearMetrics() {
      metricsCase_ = MetricsOneofCase.None;
      metrics_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ModelEvaluation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ModelEvaluation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TranslationEvaluationMetrics, other.TranslationEvaluationMetrics)) return false;
      if (Name != other.Name) return false;
      if (AnnotationSpecId != other.AnnotationSpecId) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (EvaluatedExampleCount != other.EvaluatedExampleCount) return false;
      if (MetricsCase != other.MetricsCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (metricsCase_ == MetricsOneofCase.TranslationEvaluationMetrics) hash ^= TranslationEvaluationMetrics.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (AnnotationSpecId.Length != 0) hash ^= AnnotationSpecId.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (EvaluatedExampleCount != 0) hash ^= EvaluatedExampleCount.GetHashCode();
      hash ^= (int) metricsCase_;
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
      if (AnnotationSpecId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AnnotationSpecId);
      }
      if (createTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CreateTime);
      }
      if (EvaluatedExampleCount != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(EvaluatedExampleCount);
      }
      if (metricsCase_ == MetricsOneofCase.TranslationEvaluationMetrics) {
        output.WriteRawTag(74);
        output.WriteMessage(TranslationEvaluationMetrics);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (metricsCase_ == MetricsOneofCase.TranslationEvaluationMetrics) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TranslationEvaluationMetrics);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (AnnotationSpecId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AnnotationSpecId);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (EvaluatedExampleCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EvaluatedExampleCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ModelEvaluation other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.AnnotationSpecId.Length != 0) {
        AnnotationSpecId = other.AnnotationSpecId;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.EvaluatedExampleCount != 0) {
        EvaluatedExampleCount = other.EvaluatedExampleCount;
      }
      switch (other.MetricsCase) {
        case MetricsOneofCase.TranslationEvaluationMetrics:
          if (TranslationEvaluationMetrics == null) {
            TranslationEvaluationMetrics = new global::Google.Cloud.Automl.V1.TranslationEvaluationMetrics();
          }
          TranslationEvaluationMetrics.MergeFrom(other.TranslationEvaluationMetrics);
          break;
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
            AnnotationSpecId = input.ReadString();
            break;
          }
          case 42: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 48: {
            EvaluatedExampleCount = input.ReadInt32();
            break;
          }
          case 74: {
            global::Google.Cloud.Automl.V1.TranslationEvaluationMetrics subBuilder = new global::Google.Cloud.Automl.V1.TranslationEvaluationMetrics();
            if (metricsCase_ == MetricsOneofCase.TranslationEvaluationMetrics) {
              subBuilder.MergeFrom(TranslationEvaluationMetrics);
            }
            input.ReadMessage(subBuilder);
            TranslationEvaluationMetrics = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
