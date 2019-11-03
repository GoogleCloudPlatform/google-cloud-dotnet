// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/automl/v1/annotation_payload.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AutoML.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/automl/v1/annotation_payload.proto</summary>
  public static partial class AnnotationPayloadReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/automl/v1/annotation_payload.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AnnotationPayloadReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvY2xvdWQvYXV0b21sL3YxL2Fubm90YXRpb25fcGF5bG9hZC5w",
            "cm90bxIWZ29vZ2xlLmNsb3VkLmF1dG9tbC52MRorZ29vZ2xlL2Nsb3VkL2F1",
            "dG9tbC92MS9jbGFzc2lmaWNhdGlvbi5wcm90bxomZ29vZ2xlL2Nsb3VkL2F1",
            "dG9tbC92MS9kZXRlY3Rpb24ucHJvdG8aLGdvb2dsZS9jbG91ZC9hdXRvbWwv",
            "djEvdGV4dF9leHRyYWN0aW9uLnByb3RvGitnb29nbGUvY2xvdWQvYXV0b21s",
            "L3YxL3RleHRfc2VudGltZW50LnByb3RvGihnb29nbGUvY2xvdWQvYXV0b21s",
            "L3YxL3RyYW5zbGF0aW9uLnByb3RvGhlnb29nbGUvcHJvdG9idWYvYW55LnBy",
            "b3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvItMDChFBbm5vdGF0",
            "aW9uUGF5bG9hZBJECgt0cmFuc2xhdGlvbhgCIAEoCzItLmdvb2dsZS5jbG91",
            "ZC5hdXRvbWwudjEuVHJhbnNsYXRpb25Bbm5vdGF0aW9uSAASSgoOY2xhc3Np",
            "ZmljYXRpb24YAyABKAsyMC5nb29nbGUuY2xvdWQuYXV0b21sLnYxLkNsYXNz",
            "aWZpY2F0aW9uQW5ub3RhdGlvbkgAElgKFmltYWdlX29iamVjdF9kZXRlY3Rp",
            "b24YBCABKAsyNi5nb29nbGUuY2xvdWQuYXV0b21sLnYxLkltYWdlT2JqZWN0",
            "RGV0ZWN0aW9uQW5ub3RhdGlvbkgAEksKD3RleHRfZXh0cmFjdGlvbhgGIAEo",
            "CzIwLmdvb2dsZS5jbG91ZC5hdXRvbWwudjEuVGV4dEV4dHJhY3Rpb25Bbm5v",
            "dGF0aW9uSAASSQoOdGV4dF9zZW50aW1lbnQYByABKAsyLy5nb29nbGUuY2xv",
            "dWQuYXV0b21sLnYxLlRleHRTZW50aW1lbnRBbm5vdGF0aW9uSAASGgoSYW5u",
            "b3RhdGlvbl9zcGVjX2lkGAEgASgJEhQKDGRpc3BsYXlfbmFtZRgFIAEoCUII",
            "CgZkZXRhaWxCqgEKGmNvbS5nb29nbGUuY2xvdWQuYXV0b21sLnYxUAFaPGdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvYXV0",
            "b21sL3YxO2F1dG9tbKoCFkdvb2dsZS5DbG91ZC5BdXRvTUwuVjHKAhZHb29n",
            "bGVcQ2xvdWRcQXV0b01MXFYx6gIZR29vZ2xlOjpDbG91ZDo6QXV0b01MOjpW",
            "MWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.AutoML.V1.ClassificationReflection.Descriptor, global::Google.Cloud.AutoML.V1.DetectionReflection.Descriptor, global::Google.Cloud.AutoML.V1.TextExtractionReflection.Descriptor, global::Google.Cloud.AutoML.V1.TextSentimentReflection.Descriptor, global::Google.Cloud.AutoML.V1.TranslationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.AnnotationPayload), global::Google.Cloud.AutoML.V1.AnnotationPayload.Parser, new[]{ "Translation", "Classification", "ImageObjectDetection", "TextExtraction", "TextSentiment", "AnnotationSpecId", "DisplayName" }, new[]{ "Detail" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Contains annotation information that is relevant to AutoML.
  /// </summary>
  public sealed partial class AnnotationPayload : pb::IMessage<AnnotationPayload> {
    private static readonly pb::MessageParser<AnnotationPayload> _parser = new pb::MessageParser<AnnotationPayload>(() => new AnnotationPayload());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AnnotationPayload> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.AnnotationPayloadReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnnotationPayload() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnnotationPayload(AnnotationPayload other) : this() {
      annotationSpecId_ = other.annotationSpecId_;
      displayName_ = other.displayName_;
      switch (other.DetailCase) {
        case DetailOneofCase.Translation:
          Translation = other.Translation.Clone();
          break;
        case DetailOneofCase.Classification:
          Classification = other.Classification.Clone();
          break;
        case DetailOneofCase.ImageObjectDetection:
          ImageObjectDetection = other.ImageObjectDetection.Clone();
          break;
        case DetailOneofCase.TextExtraction:
          TextExtraction = other.TextExtraction.Clone();
          break;
        case DetailOneofCase.TextSentiment:
          TextSentiment = other.TextSentiment.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnnotationPayload Clone() {
      return new AnnotationPayload(this);
    }

    /// <summary>Field number for the "translation" field.</summary>
    public const int TranslationFieldNumber = 2;
    /// <summary>
    /// Annotation details for translation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.TranslationAnnotation Translation {
      get { return detailCase_ == DetailOneofCase.Translation ? (global::Google.Cloud.AutoML.V1.TranslationAnnotation) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.Translation;
      }
    }

    /// <summary>Field number for the "classification" field.</summary>
    public const int ClassificationFieldNumber = 3;
    /// <summary>
    /// Annotation details for content or image classification.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.ClassificationAnnotation Classification {
      get { return detailCase_ == DetailOneofCase.Classification ? (global::Google.Cloud.AutoML.V1.ClassificationAnnotation) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.Classification;
      }
    }

    /// <summary>Field number for the "image_object_detection" field.</summary>
    public const int ImageObjectDetectionFieldNumber = 4;
    /// <summary>
    /// Annotation details for image object detection.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.ImageObjectDetectionAnnotation ImageObjectDetection {
      get { return detailCase_ == DetailOneofCase.ImageObjectDetection ? (global::Google.Cloud.AutoML.V1.ImageObjectDetectionAnnotation) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.ImageObjectDetection;
      }
    }

    /// <summary>Field number for the "text_extraction" field.</summary>
    public const int TextExtractionFieldNumber = 6;
    /// <summary>
    /// Annotation details for text extraction.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.TextExtractionAnnotation TextExtraction {
      get { return detailCase_ == DetailOneofCase.TextExtraction ? (global::Google.Cloud.AutoML.V1.TextExtractionAnnotation) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.TextExtraction;
      }
    }

    /// <summary>Field number for the "text_sentiment" field.</summary>
    public const int TextSentimentFieldNumber = 7;
    /// <summary>
    /// Annotation details for text sentiment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.TextSentimentAnnotation TextSentiment {
      get { return detailCase_ == DetailOneofCase.TextSentiment ? (global::Google.Cloud.AutoML.V1.TextSentimentAnnotation) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.TextSentiment;
      }
    }

    /// <summary>Field number for the "annotation_spec_id" field.</summary>
    public const int AnnotationSpecIdFieldNumber = 1;
    private string annotationSpecId_ = "";
    /// <summary>
    /// Output only . The resource ID of the annotation spec that
    /// this annotation pertains to. The annotation spec comes from either an
    /// ancestor dataset, or the dataset that was used to train the model in use.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AnnotationSpecId {
      get { return annotationSpecId_; }
      set {
        annotationSpecId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 5;
    private string displayName_ = "";
    /// <summary>
    /// Output only. The value of
    /// [display_name][google.cloud.automl.v1.AnnotationSpec.display_name]
    /// when the model was trained. Because this field returns a value at model
    /// training time, for different models trained using the same dataset, the
    /// returned value could be different as model owner could update the
    /// `display_name` between any two model training.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private object detail_;
    /// <summary>Enum of possible cases for the "detail" oneof.</summary>
    public enum DetailOneofCase {
      None = 0,
      Translation = 2,
      Classification = 3,
      ImageObjectDetection = 4,
      TextExtraction = 6,
      TextSentiment = 7,
    }
    private DetailOneofCase detailCase_ = DetailOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DetailOneofCase DetailCase {
      get { return detailCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearDetail() {
      detailCase_ = DetailOneofCase.None;
      detail_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AnnotationPayload);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AnnotationPayload other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Translation, other.Translation)) return false;
      if (!object.Equals(Classification, other.Classification)) return false;
      if (!object.Equals(ImageObjectDetection, other.ImageObjectDetection)) return false;
      if (!object.Equals(TextExtraction, other.TextExtraction)) return false;
      if (!object.Equals(TextSentiment, other.TextSentiment)) return false;
      if (AnnotationSpecId != other.AnnotationSpecId) return false;
      if (DisplayName != other.DisplayName) return false;
      if (DetailCase != other.DetailCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (detailCase_ == DetailOneofCase.Translation) hash ^= Translation.GetHashCode();
      if (detailCase_ == DetailOneofCase.Classification) hash ^= Classification.GetHashCode();
      if (detailCase_ == DetailOneofCase.ImageObjectDetection) hash ^= ImageObjectDetection.GetHashCode();
      if (detailCase_ == DetailOneofCase.TextExtraction) hash ^= TextExtraction.GetHashCode();
      if (detailCase_ == DetailOneofCase.TextSentiment) hash ^= TextSentiment.GetHashCode();
      if (AnnotationSpecId.Length != 0) hash ^= AnnotationSpecId.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      hash ^= (int) detailCase_;
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
      if (AnnotationSpecId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AnnotationSpecId);
      }
      if (detailCase_ == DetailOneofCase.Translation) {
        output.WriteRawTag(18);
        output.WriteMessage(Translation);
      }
      if (detailCase_ == DetailOneofCase.Classification) {
        output.WriteRawTag(26);
        output.WriteMessage(Classification);
      }
      if (detailCase_ == DetailOneofCase.ImageObjectDetection) {
        output.WriteRawTag(34);
        output.WriteMessage(ImageObjectDetection);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(DisplayName);
      }
      if (detailCase_ == DetailOneofCase.TextExtraction) {
        output.WriteRawTag(50);
        output.WriteMessage(TextExtraction);
      }
      if (detailCase_ == DetailOneofCase.TextSentiment) {
        output.WriteRawTag(58);
        output.WriteMessage(TextSentiment);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (detailCase_ == DetailOneofCase.Translation) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Translation);
      }
      if (detailCase_ == DetailOneofCase.Classification) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Classification);
      }
      if (detailCase_ == DetailOneofCase.ImageObjectDetection) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ImageObjectDetection);
      }
      if (detailCase_ == DetailOneofCase.TextExtraction) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TextExtraction);
      }
      if (detailCase_ == DetailOneofCase.TextSentiment) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TextSentiment);
      }
      if (AnnotationSpecId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AnnotationSpecId);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AnnotationPayload other) {
      if (other == null) {
        return;
      }
      if (other.AnnotationSpecId.Length != 0) {
        AnnotationSpecId = other.AnnotationSpecId;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      switch (other.DetailCase) {
        case DetailOneofCase.Translation:
          if (Translation == null) {
            Translation = new global::Google.Cloud.AutoML.V1.TranslationAnnotation();
          }
          Translation.MergeFrom(other.Translation);
          break;
        case DetailOneofCase.Classification:
          if (Classification == null) {
            Classification = new global::Google.Cloud.AutoML.V1.ClassificationAnnotation();
          }
          Classification.MergeFrom(other.Classification);
          break;
        case DetailOneofCase.ImageObjectDetection:
          if (ImageObjectDetection == null) {
            ImageObjectDetection = new global::Google.Cloud.AutoML.V1.ImageObjectDetectionAnnotation();
          }
          ImageObjectDetection.MergeFrom(other.ImageObjectDetection);
          break;
        case DetailOneofCase.TextExtraction:
          if (TextExtraction == null) {
            TextExtraction = new global::Google.Cloud.AutoML.V1.TextExtractionAnnotation();
          }
          TextExtraction.MergeFrom(other.TextExtraction);
          break;
        case DetailOneofCase.TextSentiment:
          if (TextSentiment == null) {
            TextSentiment = new global::Google.Cloud.AutoML.V1.TextSentimentAnnotation();
          }
          TextSentiment.MergeFrom(other.TextSentiment);
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
            AnnotationSpecId = input.ReadString();
            break;
          }
          case 18: {
            global::Google.Cloud.AutoML.V1.TranslationAnnotation subBuilder = new global::Google.Cloud.AutoML.V1.TranslationAnnotation();
            if (detailCase_ == DetailOneofCase.Translation) {
              subBuilder.MergeFrom(Translation);
            }
            input.ReadMessage(subBuilder);
            Translation = subBuilder;
            break;
          }
          case 26: {
            global::Google.Cloud.AutoML.V1.ClassificationAnnotation subBuilder = new global::Google.Cloud.AutoML.V1.ClassificationAnnotation();
            if (detailCase_ == DetailOneofCase.Classification) {
              subBuilder.MergeFrom(Classification);
            }
            input.ReadMessage(subBuilder);
            Classification = subBuilder;
            break;
          }
          case 34: {
            global::Google.Cloud.AutoML.V1.ImageObjectDetectionAnnotation subBuilder = new global::Google.Cloud.AutoML.V1.ImageObjectDetectionAnnotation();
            if (detailCase_ == DetailOneofCase.ImageObjectDetection) {
              subBuilder.MergeFrom(ImageObjectDetection);
            }
            input.ReadMessage(subBuilder);
            ImageObjectDetection = subBuilder;
            break;
          }
          case 42: {
            DisplayName = input.ReadString();
            break;
          }
          case 50: {
            global::Google.Cloud.AutoML.V1.TextExtractionAnnotation subBuilder = new global::Google.Cloud.AutoML.V1.TextExtractionAnnotation();
            if (detailCase_ == DetailOneofCase.TextExtraction) {
              subBuilder.MergeFrom(TextExtraction);
            }
            input.ReadMessage(subBuilder);
            TextExtraction = subBuilder;
            break;
          }
          case 58: {
            global::Google.Cloud.AutoML.V1.TextSentimentAnnotation subBuilder = new global::Google.Cloud.AutoML.V1.TextSentimentAnnotation();
            if (detailCase_ == DetailOneofCase.TextSentiment) {
              subBuilder.MergeFrom(TextSentiment);
            }
            input.ReadMessage(subBuilder);
            TextSentiment = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
