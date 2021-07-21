// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/aiplatform/v1/schema/predict/instance/image_object_detection.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AIPlatform.V1.Schema.Predict.Instance {

  /// <summary>Holder for reflection information generated from google/cloud/aiplatform/v1/schema/predict/instance/image_object_detection.proto</summary>
  public static partial class ImageObjectDetectionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/aiplatform/v1/schema/predict/instance/image_object_detection.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ImageObjectDetectionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ck9nb29nbGUvY2xvdWQvYWlwbGF0Zm9ybS92MS9zY2hlbWEvcHJlZGljdC9p",
            "bnN0YW5jZS9pbWFnZV9vYmplY3RfZGV0ZWN0aW9uLnByb3RvEjJnb29nbGUu",
            "Y2xvdWQuYWlwbGF0Zm9ybS52MS5zY2hlbWEucHJlZGljdC5pbnN0YW5jZRoc",
            "Z29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byJMCiZJbWFnZU9iamVjdERl",
            "dGVjdGlvblByZWRpY3Rpb25JbnN0YW5jZRIPCgdjb250ZW50GAEgASgJEhEK",
            "CW1pbWVfdHlwZRgCIAEoCULoAgo2Y29tLmdvb2dsZS5jbG91ZC5haXBsYXRm",
            "b3JtLnYxLnNjaGVtYS5wcmVkaWN0Lmluc3RhbmNlQitJbWFnZU9iamVjdERl",
            "dGVjdGlvblByZWRpY3Rpb25JbnN0YW5jZVByb3RvUAFaWmdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvYWlwbGF0Zm9ybS92",
            "MS9zY2hlbWEvcHJlZGljdC9pbnN0YW5jZTtpbnN0YW5jZaoCMkdvb2dsZS5D",
            "bG91ZC5BSVBsYXRmb3JtLlYxLlNjaGVtYS5QcmVkaWN0Lkluc3RhbmNlygIy",
            "R29vZ2xlXENsb3VkXEFJUGxhdGZvcm1cVjFcU2NoZW1hXFByZWRpY3RcSW5z",
            "dGFuY2XqAjhHb29nbGU6OkNsb3VkOjpBSVBsYXRmb3JtOjpWMTo6U2NoZW1h",
            "OjpQcmVkaWN0OjpJbnN0YW5jZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AIPlatform.V1.Schema.Predict.Instance.ImageObjectDetectionPredictionInstance), global::Google.Cloud.AIPlatform.V1.Schema.Predict.Instance.ImageObjectDetectionPredictionInstance.Parser, new[]{ "Content", "MimeType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Prediction input format for Image Object Detection.
  /// </summary>
  public sealed partial class ImageObjectDetectionPredictionInstance : pb::IMessage<ImageObjectDetectionPredictionInstance>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ImageObjectDetectionPredictionInstance> _parser = new pb::MessageParser<ImageObjectDetectionPredictionInstance>(() => new ImageObjectDetectionPredictionInstance());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ImageObjectDetectionPredictionInstance> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AIPlatform.V1.Schema.Predict.Instance.ImageObjectDetectionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageObjectDetectionPredictionInstance() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageObjectDetectionPredictionInstance(ImageObjectDetectionPredictionInstance other) : this() {
      content_ = other.content_;
      mimeType_ = other.mimeType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageObjectDetectionPredictionInstance Clone() {
      return new ImageObjectDetectionPredictionInstance(this);
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 1;
    private string content_ = "";
    /// <summary>
    /// The image bytes or Cloud Storage URI to make the prediction on.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "mime_type" field.</summary>
    public const int MimeTypeFieldNumber = 2;
    private string mimeType_ = "";
    /// <summary>
    /// The MIME type of the content of the image. Only the images in below listed
    /// MIME types are supported.
    /// - image/jpeg
    /// - image/gif
    /// - image/png
    /// - image/webp
    /// - image/bmp
    /// - image/tiff
    /// - image/vnd.microsoft.icon
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MimeType {
      get { return mimeType_; }
      set {
        mimeType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ImageObjectDetectionPredictionInstance);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ImageObjectDetectionPredictionInstance other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Content != other.Content) return false;
      if (MimeType != other.MimeType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (MimeType.Length != 0) hash ^= MimeType.GetHashCode();
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
      if (Content.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Content);
      }
      if (MimeType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MimeType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Content.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Content);
      }
      if (MimeType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MimeType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (MimeType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MimeType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ImageObjectDetectionPredictionInstance other) {
      if (other == null) {
        return;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.MimeType.Length != 0) {
        MimeType = other.MimeType;
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
            Content = input.ReadString();
            break;
          }
          case 18: {
            MimeType = input.ReadString();
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
            Content = input.ReadString();
            break;
          }
          case 18: {
            MimeType = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
