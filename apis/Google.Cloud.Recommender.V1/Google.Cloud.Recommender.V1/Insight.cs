// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/recommender/v1/insight.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Recommender.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/recommender/v1/insight.proto</summary>
  public static partial class InsightReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/recommender/v1/insight.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InsightReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cilnb29nbGUvY2xvdWQvcmVjb21tZW5kZXIvdjEvaW5zaWdodC5wcm90bxIb",
            "Z29vZ2xlLmNsb3VkLnJlY29tbWVuZGVyLnYxGhlnb29nbGUvYXBpL3Jlc291",
            "cmNlLnByb3RvGh5nb29nbGUvcHJvdG9idWYvZHVyYXRpb24ucHJvdG8aHGdv",
            "b2dsZS9wcm90b2J1Zi9zdHJ1Y3QucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90",
            "aW1lc3RhbXAucHJvdG8igQYKB0luc2lnaHQSDAoEbmFtZRgBIAEoCRITCgtk",
            "ZXNjcmlwdGlvbhgCIAEoCRIYChB0YXJnZXRfcmVzb3VyY2VzGAkgAygJEhcK",
            "D2luc2lnaHRfc3VidHlwZRgKIAEoCRIoCgdjb250ZW50GAMgASgLMhcuZ29v",
            "Z2xlLnByb3RvYnVmLlN0cnVjdBI1ChFsYXN0X3JlZnJlc2hfdGltZRgEIAEo",
            "CzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASNQoSb2JzZXJ2YXRpb25f",
            "cGVyaW9kGAUgASgLMhkuZ29vZ2xlLnByb3RvYnVmLkR1cmF0aW9uEkEKCnN0",
            "YXRlX2luZm8YBiABKAsyLS5nb29nbGUuY2xvdWQucmVjb21tZW5kZXIudjEu",
            "SW5zaWdodFN0YXRlSW5mbxI/CghjYXRlZ29yeRgHIAEoDjItLmdvb2dsZS5j",
            "bG91ZC5yZWNvbW1lbmRlci52MS5JbnNpZ2h0LkNhdGVnb3J5EgwKBGV0YWcY",
            "CyABKAkSYAoaYXNzb2NpYXRlZF9yZWNvbW1lbmRhdGlvbnMYCCADKAsyPC5n",
            "b29nbGUuY2xvdWQucmVjb21tZW5kZXIudjEuSW5zaWdodC5SZWNvbW1lbmRh",
            "dGlvblJlZmVyZW5jZRoxChdSZWNvbW1lbmRhdGlvblJlZmVyZW5jZRIWCg5y",
            "ZWNvbW1lbmRhdGlvbhgBIAEoCSJgCghDYXRlZ29yeRIYChRDQVRFR09SWV9V",
            "TlNQRUNJRklFRBAAEggKBENPU1QQARIMCghTRUNVUklUWRACEg8KC1BFUkZP",
            "Uk1BTkNFEAMSEQoNTUFOQUdFQUJJTElUWRAEOn/qQXwKInJlY29tbWVuZGVy",
            "Lmdvb2dsZWFwaXMuY29tL0luc2lnaHQSVnByb2plY3RzL3twcm9qZWN0fS9s",
            "b2NhdGlvbnMve2xvY2F0aW9ufS9pbnNpZ2h0VHlwZXMve2luc2lnaHRfdHlw",
            "ZX0vaW5zaWdodHMve2luc2lnaHR9Iq8CChBJbnNpZ2h0U3RhdGVJbmZvEkIK",
            "BXN0YXRlGAEgASgOMjMuZ29vZ2xlLmNsb3VkLnJlY29tbWVuZGVyLnYxLklu",
            "c2lnaHRTdGF0ZUluZm8uU3RhdGUSWAoOc3RhdGVfbWV0YWRhdGEYAiADKAsy",
            "QC5nb29nbGUuY2xvdWQucmVjb21tZW5kZXIudjEuSW5zaWdodFN0YXRlSW5m",
            "by5TdGF0ZU1ldGFkYXRhRW50cnkaNAoSU3RhdGVNZXRhZGF0YUVudHJ5EgsK",
            "A2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoCToCOAEiRwoFU3RhdGUSFQoRU1RB",
            "VEVfVU5TUEVDSUZJRUQQABIKCgZBQ1RJVkUQARIMCghBQ0NFUFRFRBACEg0K",
            "CURJU01JU1NFRBADQo4CCh9jb20uZ29vZ2xlLmNsb3VkLnJlY29tbWVuZGVy",
            "LnYxQgxJbnNpZ2h0UHJvdG9QAVpGZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJv",
            "dG8vZ29vZ2xlYXBpcy9jbG91ZC9yZWNvbW1lbmRlci92MTtyZWNvbW1lbmRl",
            "cqICBENSRUOqAhtHb29nbGUuQ2xvdWQuUmVjb21tZW5kZXIuVjHqQW0KJnJl",
            "Y29tbWVuZGVyLmdvb2dsZWFwaXMuY29tL0luc2lnaHRUeXBlEkNwcm9qZWN0",
            "cy97cHJvamVjdH0vbG9jYXRpb25zL3tsb2NhdGlvbn0vaW5zaWdodFR5cGVz",
            "L3tpbnNpZ2h0X3R5cGV9YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Recommender.V1.Insight), global::Google.Cloud.Recommender.V1.Insight.Parser, new[]{ "Name", "Description", "TargetResources", "InsightSubtype", "Content", "LastRefreshTime", "ObservationPeriod", "StateInfo", "Category", "Etag", "AssociatedRecommendations" }, null, new[]{ typeof(global::Google.Cloud.Recommender.V1.Insight.Types.Category) }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Recommender.V1.Insight.Types.RecommendationReference), global::Google.Cloud.Recommender.V1.Insight.Types.RecommendationReference.Parser, new[]{ "Recommendation" }, null, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Recommender.V1.InsightStateInfo), global::Google.Cloud.Recommender.V1.InsightStateInfo.Parser, new[]{ "State", "StateMetadata" }, null, new[]{ typeof(global::Google.Cloud.Recommender.V1.InsightStateInfo.Types.State) }, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An insight along with the information used to derive the insight. The insight
  /// may have associated recomendations as well.
  /// </summary>
  public sealed partial class Insight : pb::IMessage<Insight> {
    private static readonly pb::MessageParser<Insight> _parser = new pb::MessageParser<Insight>(() => new Insight());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Insight> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Recommender.V1.InsightReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Insight() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Insight(Insight other) : this() {
      name_ = other.name_;
      description_ = other.description_;
      targetResources_ = other.targetResources_.Clone();
      insightSubtype_ = other.insightSubtype_;
      content_ = other.content_ != null ? other.content_.Clone() : null;
      lastRefreshTime_ = other.lastRefreshTime_ != null ? other.lastRefreshTime_.Clone() : null;
      observationPeriod_ = other.observationPeriod_ != null ? other.observationPeriod_.Clone() : null;
      stateInfo_ = other.stateInfo_ != null ? other.stateInfo_.Clone() : null;
      category_ = other.category_;
      etag_ = other.etag_;
      associatedRecommendations_ = other.associatedRecommendations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Insight Clone() {
      return new Insight(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Name of the insight.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 2;
    private string description_ = "";
    /// <summary>
    /// Free-form human readable summary in English. The maximum length is 500
    /// characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target_resources" field.</summary>
    public const int TargetResourcesFieldNumber = 9;
    private static readonly pb::FieldCodec<string> _repeated_targetResources_codec
        = pb::FieldCodec.ForString(74);
    private readonly pbc::RepeatedField<string> targetResources_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Fully qualified resource names that this insight is targeting.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> TargetResources {
      get { return targetResources_; }
    }

    /// <summary>Field number for the "insight_subtype" field.</summary>
    public const int InsightSubtypeFieldNumber = 10;
    private string insightSubtype_ = "";
    /// <summary>
    /// Insight subtype. Insight content schema will be stable for a given subtype.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InsightSubtype {
      get { return insightSubtype_; }
      set {
        insightSubtype_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Struct content_;
    /// <summary>
    /// A struct of custom fields to explain the insight.
    /// Example: "grantedPermissionsCount": "1000"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct Content {
      get { return content_; }
      set {
        content_ = value;
      }
    }

    /// <summary>Field number for the "last_refresh_time" field.</summary>
    public const int LastRefreshTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp lastRefreshTime_;
    /// <summary>
    /// Timestamp of the latest data used to generate the insight.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp LastRefreshTime {
      get { return lastRefreshTime_; }
      set {
        lastRefreshTime_ = value;
      }
    }

    /// <summary>Field number for the "observation_period" field.</summary>
    public const int ObservationPeriodFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Duration observationPeriod_;
    /// <summary>
    /// Observation period that led to the insight. The source data used to
    /// generate the insight ends at last_refresh_time and begins at
    /// (last_refresh_time - observation_period).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration ObservationPeriod {
      get { return observationPeriod_; }
      set {
        observationPeriod_ = value;
      }
    }

    /// <summary>Field number for the "state_info" field.</summary>
    public const int StateInfoFieldNumber = 6;
    private global::Google.Cloud.Recommender.V1.InsightStateInfo stateInfo_;
    /// <summary>
    /// Information state and metadata.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Recommender.V1.InsightStateInfo StateInfo {
      get { return stateInfo_; }
      set {
        stateInfo_ = value;
      }
    }

    /// <summary>Field number for the "category" field.</summary>
    public const int CategoryFieldNumber = 7;
    private global::Google.Cloud.Recommender.V1.Insight.Types.Category category_ = global::Google.Cloud.Recommender.V1.Insight.Types.Category.Unspecified;
    /// <summary>
    /// Category being targeted by the insight.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Recommender.V1.Insight.Types.Category Category {
      get { return category_; }
      set {
        category_ = value;
      }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 11;
    private string etag_ = "";
    /// <summary>
    /// Fingerprint of the Insight. Provides optimistic locking when updating
    /// states.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Etag {
      get { return etag_; }
      set {
        etag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "associated_recommendations" field.</summary>
    public const int AssociatedRecommendationsFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Google.Cloud.Recommender.V1.Insight.Types.RecommendationReference> _repeated_associatedRecommendations_codec
        = pb::FieldCodec.ForMessage(66, global::Google.Cloud.Recommender.V1.Insight.Types.RecommendationReference.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Recommender.V1.Insight.Types.RecommendationReference> associatedRecommendations_ = new pbc::RepeatedField<global::Google.Cloud.Recommender.V1.Insight.Types.RecommendationReference>();
    /// <summary>
    /// Recommendations derived from this insight.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Recommender.V1.Insight.Types.RecommendationReference> AssociatedRecommendations {
      get { return associatedRecommendations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Insight);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Insight other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if(!targetResources_.Equals(other.targetResources_)) return false;
      if (InsightSubtype != other.InsightSubtype) return false;
      if (!object.Equals(Content, other.Content)) return false;
      if (!object.Equals(LastRefreshTime, other.LastRefreshTime)) return false;
      if (!object.Equals(ObservationPeriod, other.ObservationPeriod)) return false;
      if (!object.Equals(StateInfo, other.StateInfo)) return false;
      if (Category != other.Category) return false;
      if (Etag != other.Etag) return false;
      if(!associatedRecommendations_.Equals(other.associatedRecommendations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      hash ^= targetResources_.GetHashCode();
      if (InsightSubtype.Length != 0) hash ^= InsightSubtype.GetHashCode();
      if (content_ != null) hash ^= Content.GetHashCode();
      if (lastRefreshTime_ != null) hash ^= LastRefreshTime.GetHashCode();
      if (observationPeriod_ != null) hash ^= ObservationPeriod.GetHashCode();
      if (stateInfo_ != null) hash ^= StateInfo.GetHashCode();
      if (Category != global::Google.Cloud.Recommender.V1.Insight.Types.Category.Unspecified) hash ^= Category.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
      hash ^= associatedRecommendations_.GetHashCode();
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
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (content_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Content);
      }
      if (lastRefreshTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(LastRefreshTime);
      }
      if (observationPeriod_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ObservationPeriod);
      }
      if (stateInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(StateInfo);
      }
      if (Category != global::Google.Cloud.Recommender.V1.Insight.Types.Category.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Category);
      }
      associatedRecommendations_.WriteTo(output, _repeated_associatedRecommendations_codec);
      targetResources_.WriteTo(output, _repeated_targetResources_codec);
      if (InsightSubtype.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(InsightSubtype);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Etag);
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
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      size += targetResources_.CalculateSize(_repeated_targetResources_codec);
      if (InsightSubtype.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InsightSubtype);
      }
      if (content_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Content);
      }
      if (lastRefreshTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastRefreshTime);
      }
      if (observationPeriod_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ObservationPeriod);
      }
      if (stateInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StateInfo);
      }
      if (Category != global::Google.Cloud.Recommender.V1.Insight.Types.Category.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Category);
      }
      if (Etag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Etag);
      }
      size += associatedRecommendations_.CalculateSize(_repeated_associatedRecommendations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Insight other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      targetResources_.Add(other.targetResources_);
      if (other.InsightSubtype.Length != 0) {
        InsightSubtype = other.InsightSubtype;
      }
      if (other.content_ != null) {
        if (content_ == null) {
          Content = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        Content.MergeFrom(other.Content);
      }
      if (other.lastRefreshTime_ != null) {
        if (lastRefreshTime_ == null) {
          LastRefreshTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        LastRefreshTime.MergeFrom(other.LastRefreshTime);
      }
      if (other.observationPeriod_ != null) {
        if (observationPeriod_ == null) {
          ObservationPeriod = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        ObservationPeriod.MergeFrom(other.ObservationPeriod);
      }
      if (other.stateInfo_ != null) {
        if (stateInfo_ == null) {
          StateInfo = new global::Google.Cloud.Recommender.V1.InsightStateInfo();
        }
        StateInfo.MergeFrom(other.StateInfo);
      }
      if (other.Category != global::Google.Cloud.Recommender.V1.Insight.Types.Category.Unspecified) {
        Category = other.Category;
      }
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
      }
      associatedRecommendations_.Add(other.associatedRecommendations_);
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
            Description = input.ReadString();
            break;
          }
          case 26: {
            if (content_ == null) {
              Content = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(Content);
            break;
          }
          case 34: {
            if (lastRefreshTime_ == null) {
              LastRefreshTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastRefreshTime);
            break;
          }
          case 42: {
            if (observationPeriod_ == null) {
              ObservationPeriod = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(ObservationPeriod);
            break;
          }
          case 50: {
            if (stateInfo_ == null) {
              StateInfo = new global::Google.Cloud.Recommender.V1.InsightStateInfo();
            }
            input.ReadMessage(StateInfo);
            break;
          }
          case 56: {
            Category = (global::Google.Cloud.Recommender.V1.Insight.Types.Category) input.ReadEnum();
            break;
          }
          case 66: {
            associatedRecommendations_.AddEntriesFrom(input, _repeated_associatedRecommendations_codec);
            break;
          }
          case 74: {
            targetResources_.AddEntriesFrom(input, _repeated_targetResources_codec);
            break;
          }
          case 82: {
            InsightSubtype = input.ReadString();
            break;
          }
          case 90: {
            Etag = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Insight message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Insight category.
      /// </summary>
      public enum Category {
        /// <summary>
        /// Unspecified category.
        /// </summary>
        [pbr::OriginalName("CATEGORY_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The insight is related to cost.
        /// </summary>
        [pbr::OriginalName("COST")] Cost = 1,
        /// <summary>
        /// The insight is related to security.
        /// </summary>
        [pbr::OriginalName("SECURITY")] Security = 2,
        /// <summary>
        /// The insight is related to performance.
        /// </summary>
        [pbr::OriginalName("PERFORMANCE")] Performance = 3,
        /// <summary>
        /// This insight is related to manageability.
        /// </summary>
        [pbr::OriginalName("MANAGEABILITY")] Manageability = 4,
      }

      /// <summary>
      /// Reference to an associated recommendation.
      /// </summary>
      public sealed partial class RecommendationReference : pb::IMessage<RecommendationReference> {
        private static readonly pb::MessageParser<RecommendationReference> _parser = new pb::MessageParser<RecommendationReference>(() => new RecommendationReference());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<RecommendationReference> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Recommender.V1.Insight.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public RecommendationReference() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public RecommendationReference(RecommendationReference other) : this() {
          recommendation_ = other.recommendation_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public RecommendationReference Clone() {
          return new RecommendationReference(this);
        }

        /// <summary>Field number for the "recommendation" field.</summary>
        public const int RecommendationFieldNumber = 1;
        private string recommendation_ = "";
        /// <summary>
        /// Recommendation resource name, e.g.
        /// projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/recommendations/[RECOMMENDATION_ID]
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Recommendation {
          get { return recommendation_; }
          set {
            recommendation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as RecommendationReference);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(RecommendationReference other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Recommendation != other.Recommendation) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Recommendation.Length != 0) hash ^= Recommendation.GetHashCode();
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
          if (Recommendation.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Recommendation);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Recommendation.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Recommendation);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(RecommendationReference other) {
          if (other == null) {
            return;
          }
          if (other.Recommendation.Length != 0) {
            Recommendation = other.Recommendation;
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
                Recommendation = input.ReadString();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  /// <summary>
  /// Information related to insight state.
  /// </summary>
  public sealed partial class InsightStateInfo : pb::IMessage<InsightStateInfo> {
    private static readonly pb::MessageParser<InsightStateInfo> _parser = new pb::MessageParser<InsightStateInfo>(() => new InsightStateInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InsightStateInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Recommender.V1.InsightReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InsightStateInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InsightStateInfo(InsightStateInfo other) : this() {
      state_ = other.state_;
      stateMetadata_ = other.stateMetadata_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InsightStateInfo Clone() {
      return new InsightStateInfo(this);
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 1;
    private global::Google.Cloud.Recommender.V1.InsightStateInfo.Types.State state_ = global::Google.Cloud.Recommender.V1.InsightStateInfo.Types.State.Unspecified;
    /// <summary>
    /// Insight state.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Recommender.V1.InsightStateInfo.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "state_metadata" field.</summary>
    public const int StateMetadataFieldNumber = 2;
    private static readonly pbc::MapField<string, string>.Codec _map_stateMetadata_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 18);
    private readonly pbc::MapField<string, string> stateMetadata_ = new pbc::MapField<string, string>();
    /// <summary>
    /// A map of metadata for the state, provided by user or automations systems.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> StateMetadata {
      get { return stateMetadata_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InsightStateInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InsightStateInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (State != other.State) return false;
      if (!StateMetadata.Equals(other.StateMetadata)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (State != global::Google.Cloud.Recommender.V1.InsightStateInfo.Types.State.Unspecified) hash ^= State.GetHashCode();
      hash ^= StateMetadata.GetHashCode();
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
      if (State != global::Google.Cloud.Recommender.V1.InsightStateInfo.Types.State.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) State);
      }
      stateMetadata_.WriteTo(output, _map_stateMetadata_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (State != global::Google.Cloud.Recommender.V1.InsightStateInfo.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      size += stateMetadata_.CalculateSize(_map_stateMetadata_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InsightStateInfo other) {
      if (other == null) {
        return;
      }
      if (other.State != global::Google.Cloud.Recommender.V1.InsightStateInfo.Types.State.Unspecified) {
        State = other.State;
      }
      stateMetadata_.Add(other.stateMetadata_);
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
          case 8: {
            State = (global::Google.Cloud.Recommender.V1.InsightStateInfo.Types.State) input.ReadEnum();
            break;
          }
          case 18: {
            stateMetadata_.AddEntriesFrom(input, _map_stateMetadata_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the InsightStateInfo message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Represents insight state.
      /// </summary>
      public enum State {
        /// <summary>
        /// Unspecified state.
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Insight is active. Content for ACTIVE insights can be updated by Google.
        /// ACTIVE insights can be marked DISMISSED OR ACCEPTED.
        /// </summary>
        [pbr::OriginalName("ACTIVE")] Active = 1,
        /// <summary>
        /// Some action has been taken based on this insight. Insights become
        /// accepted when a recommendation derived from the insight has been marked
        /// CLAIMED, SUCCEEDED, or FAILED. ACTIVE insights can also be marked
        /// ACCEPTED explicitly. Content for ACCEPTED insights is immutable. ACCEPTED
        /// insights can only be marked ACCEPTED (which may update state metadata).
        /// </summary>
        [pbr::OriginalName("ACCEPTED")] Accepted = 2,
        /// <summary>
        /// Insight is dismissed. Content for DISMISSED insights can be updated by
        /// Google. DISMISSED insights can be marked as ACTIVE.
        /// </summary>
        [pbr::OriginalName("DISMISSED")] Dismissed = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
