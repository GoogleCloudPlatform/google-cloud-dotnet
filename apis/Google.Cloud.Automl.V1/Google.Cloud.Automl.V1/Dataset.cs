// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/automl/v1/dataset.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Automl.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/automl/v1/dataset.proto</summary>
  public static partial class DatasetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/automl/v1/dataset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DatasetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRnb29nbGUvY2xvdWQvYXV0b21sL3YxL2RhdGFzZXQucHJvdG8SFmdvb2ds",
            "ZS5jbG91ZC5hdXRvbWwudjEaKGdvb2dsZS9jbG91ZC9hdXRvbWwvdjEvdHJh",
            "bnNsYXRpb24ucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJv",
            "dG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i9AIKB0RhdGFzZXQS",
            "WgocdHJhbnNsYXRpb25fZGF0YXNldF9tZXRhZGF0YRgXIAEoCzIyLmdvb2ds",
            "ZS5jbG91ZC5hdXRvbWwudjEuVHJhbnNsYXRpb25EYXRhc2V0TWV0YWRhdGFI",
            "ABIMCgRuYW1lGAEgASgJEhQKDGRpc3BsYXlfbmFtZRgCIAEoCRITCgtkZXNj",
            "cmlwdGlvbhgDIAEoCRIVCg1leGFtcGxlX2NvdW50GBUgASgFEi8KC2NyZWF0",
            "ZV90aW1lGA4gASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIMCgRl",
            "dGFnGBEgASgJEjsKBmxhYmVscxgnIAMoCzIrLmdvb2dsZS5jbG91ZC5hdXRv",
            "bWwudjEuRGF0YXNldC5MYWJlbHNFbnRyeRotCgtMYWJlbHNFbnRyeRILCgNr",
            "ZXkYASABKAkSDQoFdmFsdWUYAiABKAk6AjgBQhIKEGRhdGFzZXRfbWV0YWRh",
            "dGFCkQEKGmNvbS5nb29nbGUuY2xvdWQuYXV0b21sLnYxUAFaPGdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvYXV0b21sL3Yx",
            "O2F1dG9tbMoCFkdvb2dsZVxDbG91ZFxBdXRvTWxcVjHqAhlHb29nbGU6OkNs",
            "b3VkOjpBdXRvTUw6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.Automl.V1.TranslationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Automl.V1.Dataset), global::Google.Cloud.Automl.V1.Dataset.Parser, new[]{ "TranslationDatasetMetadata", "Name", "DisplayName", "Description", "ExampleCount", "CreateTime", "Etag", "Labels" }, new[]{ "DatasetMetadata" }, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A workspace for solving a single, particular machine learning (ML) problem.
  /// A workspace contains examples that may be annotated.
  /// </summary>
  public sealed partial class Dataset : pb::IMessage<Dataset> {
    private static readonly pb::MessageParser<Dataset> _parser = new pb::MessageParser<Dataset>(() => new Dataset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Dataset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Automl.V1.DatasetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Dataset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Dataset(Dataset other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      description_ = other.description_;
      exampleCount_ = other.exampleCount_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      etag_ = other.etag_;
      labels_ = other.labels_.Clone();
      switch (other.DatasetMetadataCase) {
        case DatasetMetadataOneofCase.TranslationDatasetMetadata:
          TranslationDatasetMetadata = other.TranslationDatasetMetadata.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Dataset Clone() {
      return new Dataset(this);
    }

    /// <summary>Field number for the "translation_dataset_metadata" field.</summary>
    public const int TranslationDatasetMetadataFieldNumber = 23;
    /// <summary>
    /// Metadata for a dataset used for translation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Automl.V1.TranslationDatasetMetadata TranslationDatasetMetadata {
      get { return datasetMetadataCase_ == DatasetMetadataOneofCase.TranslationDatasetMetadata ? (global::Google.Cloud.Automl.V1.TranslationDatasetMetadata) datasetMetadata_ : null; }
      set {
        datasetMetadata_ = value;
        datasetMetadataCase_ = value == null ? DatasetMetadataOneofCase.None : DatasetMetadataOneofCase.TranslationDatasetMetadata;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. The resource name of the dataset.
    /// Form: `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}`
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
    /// Required. The name of the dataset to show in the interface. The name can be
    /// up to 32 characters long and can consist only of ASCII Latin letters A-Z
    /// and a-z, underscores
    /// (_), and ASCII digits 0-9.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    /// <summary>
    /// User-provided description of the dataset. The description can be up to
    /// 25000 characters long.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "example_count" field.</summary>
    public const int ExampleCountFieldNumber = 21;
    private int exampleCount_;
    /// <summary>
    /// Output only. The number of examples in the dataset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ExampleCount {
      get { return exampleCount_; }
      set {
        exampleCount_ = value;
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 14;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when this dataset was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 17;
    private string etag_ = "";
    /// <summary>
    /// Used to perform consistent read-modify-write updates. If not set, a blind
    /// "overwrite" update happens.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Etag {
      get { return etag_; }
      set {
        etag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 39;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 314);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Optional. The labels with user-defined metadata to organize your dataset.
    ///
    /// Label keys and values can be no longer than 64 characters
    /// (Unicode codepoints), can only contain lowercase letters, numeric
    /// characters, underscores and dashes. International characters are allowed.
    /// Label values are optional. Label keys must start with a letter.
    ///
    /// See https://goo.gl/xmQnxf for more information on and examples of labels.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    private object datasetMetadata_;
    /// <summary>Enum of possible cases for the "dataset_metadata" oneof.</summary>
    public enum DatasetMetadataOneofCase {
      None = 0,
      TranslationDatasetMetadata = 23,
    }
    private DatasetMetadataOneofCase datasetMetadataCase_ = DatasetMetadataOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DatasetMetadataOneofCase DatasetMetadataCase {
      get { return datasetMetadataCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearDatasetMetadata() {
      datasetMetadataCase_ = DatasetMetadataOneofCase.None;
      datasetMetadata_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Dataset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Dataset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TranslationDatasetMetadata, other.TranslationDatasetMetadata)) return false;
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (Description != other.Description) return false;
      if (ExampleCount != other.ExampleCount) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (Etag != other.Etag) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (DatasetMetadataCase != other.DatasetMetadataCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TranslationDatasetMetadata) hash ^= TranslationDatasetMetadata.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (ExampleCount != 0) hash ^= ExampleCount.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
      hash ^= Labels.GetHashCode();
      hash ^= (int) datasetMetadataCase_;
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
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (createTime_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(CreateTime);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(138, 1);
        output.WriteString(Etag);
      }
      if (ExampleCount != 0) {
        output.WriteRawTag(168, 1);
        output.WriteInt32(ExampleCount);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TranslationDatasetMetadata) {
        output.WriteRawTag(186, 1);
        output.WriteMessage(TranslationDatasetMetadata);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TranslationDatasetMetadata) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(TranslationDatasetMetadata);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (ExampleCount != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(ExampleCount);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (Etag.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Etag);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Dataset other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.ExampleCount != 0) {
        ExampleCount = other.ExampleCount;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
      }
      labels_.Add(other.labels_);
      switch (other.DatasetMetadataCase) {
        case DatasetMetadataOneofCase.TranslationDatasetMetadata:
          if (TranslationDatasetMetadata == null) {
            TranslationDatasetMetadata = new global::Google.Cloud.Automl.V1.TranslationDatasetMetadata();
          }
          TranslationDatasetMetadata.MergeFrom(other.TranslationDatasetMetadata);
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
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 114: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 138: {
            Etag = input.ReadString();
            break;
          }
          case 168: {
            ExampleCount = input.ReadInt32();
            break;
          }
          case 186: {
            global::Google.Cloud.Automl.V1.TranslationDatasetMetadata subBuilder = new global::Google.Cloud.Automl.V1.TranslationDatasetMetadata();
            if (datasetMetadataCase_ == DatasetMetadataOneofCase.TranslationDatasetMetadata) {
              subBuilder.MergeFrom(TranslationDatasetMetadata);
            }
            input.ReadMessage(subBuilder);
            TranslationDatasetMetadata = subBuilder;
            break;
          }
          case 314: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
