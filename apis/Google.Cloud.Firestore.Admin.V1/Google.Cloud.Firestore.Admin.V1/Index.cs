// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/firestore/admin/v1/index.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Firestore.Admin.V1 {

  /// <summary>Holder for reflection information generated from google/firestore/admin/v1/index.proto</summary>
  public static partial class IndexReflection {

    #region Descriptor
    /// <summary>File descriptor for google/firestore/admin/v1/index.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IndexReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVnb29nbGUvZmlyZXN0b3JlL2FkbWluL3YxL2luZGV4LnByb3RvEhlnb29n",
            "bGUuZmlyZXN0b3JlLmFkbWluLnYxGhlnb29nbGUvYXBpL3Jlc291cmNlLnBy",
            "b3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIqMGCgVJbmRleBIM",
            "CgRuYW1lGAEgASgJEkAKC3F1ZXJ5X3Njb3BlGAIgASgOMisuZ29vZ2xlLmZp",
            "cmVzdG9yZS5hZG1pbi52MS5JbmRleC5RdWVyeVNjb3BlEjsKBmZpZWxkcxgD",
            "IAMoCzIrLmdvb2dsZS5maXJlc3RvcmUuYWRtaW4udjEuSW5kZXguSW5kZXhG",
            "aWVsZBI1CgVzdGF0ZRgEIAEoDjImLmdvb2dsZS5maXJlc3RvcmUuYWRtaW4u",
            "djEuSW5kZXguU3RhdGUavQIKCkluZGV4RmllbGQSEgoKZmllbGRfcGF0aBgB",
            "IAEoCRJCCgVvcmRlchgCIAEoDjIxLmdvb2dsZS5maXJlc3RvcmUuYWRtaW4u",
            "djEuSW5kZXguSW5kZXhGaWVsZC5PcmRlckgAEk8KDGFycmF5X2NvbmZpZxgD",
            "IAEoDjI3Lmdvb2dsZS5maXJlc3RvcmUuYWRtaW4udjEuSW5kZXguSW5kZXhG",
            "aWVsZC5BcnJheUNvbmZpZ0gAIj0KBU9yZGVyEhUKEU9SREVSX1VOU1BFQ0lG",
            "SUVEEAASDQoJQVNDRU5ESU5HEAESDgoKREVTQ0VORElORxACIjkKC0FycmF5",
            "Q29uZmlnEhwKGEFSUkFZX0NPTkZJR19VTlNQRUNJRklFRBAAEgwKCENPTlRB",
            "SU5TEAFCDAoKdmFsdWVfbW9kZSJPCgpRdWVyeVNjb3BlEhsKF1FVRVJZX1ND",
            "T1BFX1VOU1BFQ0lGSUVEEAASDgoKQ09MTEVDVElPThABEhQKEENPTExFQ1RJ",
            "T05fR1JPVVAQAiJJCgVTdGF0ZRIVChFTVEFURV9VTlNQRUNJRklFRBAAEgwK",
            "CENSRUFUSU5HEAESCQoFUkVBRFkQAhIQCgxORUVEU19SRVBBSVIQAzp66kF3",
            "Ch5maXJlc3RvcmUuZ29vZ2xlYXBpcy5jb20vSW5kZXgSVXByb2plY3RzL3tw",
            "cm9qZWN0fS9kYXRhYmFzZXMve2RhdGFiYXNlfS9jb2xsZWN0aW9uR3JvdXBz",
            "L3tjb2xsZWN0aW9ufS9pbmRleGVzL3tpbmRleH1C3gEKHWNvbS5nb29nbGUu",
            "ZmlyZXN0b3JlLmFkbWluLnYxQgpJbmRleFByb3RvUAFaPmdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvZmlyZXN0b3JlL2FkbWluL3Yx",
            "O2FkbWluogIER0NGU6oCH0dvb2dsZS5DbG91ZC5GaXJlc3RvcmUuQWRtaW4u",
            "VjHKAh9Hb29nbGVcQ2xvdWRcRmlyZXN0b3JlXEFkbWluXFYx6gIjR29vZ2xl",
            "OjpDbG91ZDo6RmlyZXN0b3JlOjpBZG1pbjo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Firestore.Admin.V1.Index), global::Google.Cloud.Firestore.Admin.V1.Index.Parser, new[]{ "Name", "QueryScope", "Fields", "State" }, null, new[]{ typeof(global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope), typeof(global::Google.Cloud.Firestore.Admin.V1.Index.Types.State) }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField), global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Parser, new[]{ "FieldPath", "Order", "ArrayConfig" }, new[]{ "ValueMode" }, new[]{ typeof(global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Types.Order), typeof(global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Types.ArrayConfig) }, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Cloud Firestore indexes enable simple and complex queries against
  /// documents in a database.
  /// </summary>
  public sealed partial class Index : pb::IMessage<Index> {
    private static readonly pb::MessageParser<Index> _parser = new pb::MessageParser<Index>(() => new Index());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Index> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Firestore.Admin.V1.IndexReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Index() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Index(Index other) : this() {
      name_ = other.name_;
      queryScope_ = other.queryScope_;
      fields_ = other.fields_.Clone();
      state_ = other.state_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Index Clone() {
      return new Index(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. A server defined name for this index.
    /// The form of this name for composite indexes will be:
    /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{composite_index_id}`
    /// For single field indexes, this field will be empty.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "query_scope" field.</summary>
    public const int QueryScopeFieldNumber = 2;
    private global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope queryScope_ = global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope.Unspecified;
    /// <summary>
    /// Indexes with a collection query scope specified allow queries
    /// against a collection that is the child of a specific document, specified at
    /// query time, and that has the same collection id.
    ///
    /// Indexes with a collection group query scope specified allow queries against
    /// all collections descended from a specific document, specified at query
    /// time, and that have the same collection id as this index.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope QueryScope {
      get { return queryScope_; }
      set {
        queryScope_ = value;
      }
    }

    /// <summary>Field number for the "fields" field.</summary>
    public const int FieldsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField> _repeated_fields_codec
        = pb::FieldCodec.ForMessage(26, global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField> fields_ = new pbc::RepeatedField<global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField>();
    /// <summary>
    /// The fields supported by this index.
    ///
    /// For composite indexes, this is always 2 or more fields.
    /// The last field entry is always for the field path `__name__`. If, on
    /// creation, `__name__` was not specified as the last field, it will be added
    /// automatically with the same direction as that of the last field defined. If
    /// the final field in a composite index is not directional, the `__name__`
    /// will be ordered ASCENDING (unless explicitly specified).
    ///
    /// For single field indexes, this will always be exactly one entry with a
    /// field path equal to the field path of the associated field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField> Fields {
      get { return fields_; }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 4;
    private global::Google.Cloud.Firestore.Admin.V1.Index.Types.State state_ = global::Google.Cloud.Firestore.Admin.V1.Index.Types.State.Unspecified;
    /// <summary>
    /// Output only. The serving state of the index.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Firestore.Admin.V1.Index.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Index);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Index other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (QueryScope != other.QueryScope) return false;
      if(!fields_.Equals(other.fields_)) return false;
      if (State != other.State) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (QueryScope != global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope.Unspecified) hash ^= QueryScope.GetHashCode();
      hash ^= fields_.GetHashCode();
      if (State != global::Google.Cloud.Firestore.Admin.V1.Index.Types.State.Unspecified) hash ^= State.GetHashCode();
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
      if (QueryScope != global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) QueryScope);
      }
      fields_.WriteTo(output, _repeated_fields_codec);
      if (State != global::Google.Cloud.Firestore.Admin.V1.Index.Types.State.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
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
      if (QueryScope != global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) QueryScope);
      }
      size += fields_.CalculateSize(_repeated_fields_codec);
      if (State != global::Google.Cloud.Firestore.Admin.V1.Index.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Index other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.QueryScope != global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope.Unspecified) {
        QueryScope = other.QueryScope;
      }
      fields_.Add(other.fields_);
      if (other.State != global::Google.Cloud.Firestore.Admin.V1.Index.Types.State.Unspecified) {
        State = other.State;
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
          case 16: {
            QueryScope = (global::Google.Cloud.Firestore.Admin.V1.Index.Types.QueryScope) input.ReadEnum();
            break;
          }
          case 26: {
            fields_.AddEntriesFrom(input, _repeated_fields_codec);
            break;
          }
          case 32: {
            State = (global::Google.Cloud.Firestore.Admin.V1.Index.Types.State) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Index message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Query Scope defines the scope at which a query is run. This is specified on
      /// a StructuredQuery's `from` field.
      /// </summary>
      public enum QueryScope {
        /// <summary>
        /// The query scope is unspecified. Not a valid option.
        /// </summary>
        [pbr::OriginalName("QUERY_SCOPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Indexes with a collection query scope specified allow queries
        /// against a collection that is the child of a specific document, specified
        /// at query time, and that has the collection id specified by the index.
        /// </summary>
        [pbr::OriginalName("COLLECTION")] Collection = 1,
        /// <summary>
        /// Indexes with a collection group query scope specified allow queries
        /// against all collections that has the collection id specified by the
        /// index.
        /// </summary>
        [pbr::OriginalName("COLLECTION_GROUP")] CollectionGroup = 2,
      }

      /// <summary>
      /// The state of an index. During index creation, an index will be in the
      /// `CREATING` state. If the index is created successfully, it will transition
      /// to the `READY` state. If the index creation encounters a problem, the index
      /// will transition to the `NEEDS_REPAIR` state.
      /// </summary>
      public enum State {
        /// <summary>
        /// The state is unspecified.
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The index is being created.
        /// There is an active long-running operation for the index.
        /// The index is updated when writing a document.
        /// Some index data may exist.
        /// </summary>
        [pbr::OriginalName("CREATING")] Creating = 1,
        /// <summary>
        /// The index is ready to be used.
        /// The index is updated when writing a document.
        /// The index is fully populated from all stored documents it applies to.
        /// </summary>
        [pbr::OriginalName("READY")] Ready = 2,
        /// <summary>
        /// The index was being created, but something went wrong.
        /// There is no active long-running operation for the index,
        /// and the most recently finished long-running operation failed.
        /// The index is not updated when writing a document.
        /// Some index data may exist.
        /// Use the google.longrunning.Operations API to determine why the operation
        /// that last attempted to create this index failed, then re-create the
        /// index.
        /// </summary>
        [pbr::OriginalName("NEEDS_REPAIR")] NeedsRepair = 3,
      }

      /// <summary>
      /// A field in an index.
      /// The field_path describes which field is indexed, the value_mode describes
      /// how the field value is indexed.
      /// </summary>
      public sealed partial class IndexField : pb::IMessage<IndexField> {
        private static readonly pb::MessageParser<IndexField> _parser = new pb::MessageParser<IndexField>(() => new IndexField());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<IndexField> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Firestore.Admin.V1.Index.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public IndexField() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public IndexField(IndexField other) : this() {
          fieldPath_ = other.fieldPath_;
          switch (other.ValueModeCase) {
            case ValueModeOneofCase.Order:
              Order = other.Order;
              break;
            case ValueModeOneofCase.ArrayConfig:
              ArrayConfig = other.ArrayConfig;
              break;
          }

          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public IndexField Clone() {
          return new IndexField(this);
        }

        /// <summary>Field number for the "field_path" field.</summary>
        public const int FieldPathFieldNumber = 1;
        private string fieldPath_ = "";
        /// <summary>
        /// Can be __name__.
        /// For single field indexes, this must match the name of the field or may
        /// be omitted.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string FieldPath {
          get { return fieldPath_; }
          set {
            fieldPath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "order" field.</summary>
        public const int OrderFieldNumber = 2;
        /// <summary>
        /// Indicates that this field supports ordering by the specified order or
        /// comparing using =, &lt;, &lt;=, >, >=.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Types.Order Order {
          get { return valueModeCase_ == ValueModeOneofCase.Order ? (global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Types.Order) valueMode_ : global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Types.Order.Unspecified; }
          set {
            valueMode_ = value;
            valueModeCase_ = ValueModeOneofCase.Order;
          }
        }

        /// <summary>Field number for the "array_config" field.</summary>
        public const int ArrayConfigFieldNumber = 3;
        /// <summary>
        /// Indicates that this field supports operations on `array_value`s.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Types.ArrayConfig ArrayConfig {
          get { return valueModeCase_ == ValueModeOneofCase.ArrayConfig ? (global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Types.ArrayConfig) valueMode_ : global::Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Types.ArrayConfig.Unspecified; }
          set {
            valueMode_ = value;
            valueModeCase_ = ValueModeOneofCase.ArrayConfig;
          }
        }

        private object valueMode_;
        /// <summary>Enum of possible cases for the "value_mode" oneof.</summary>
        public enum ValueModeOneofCase {
          None = 0,
          Order = 2,
          ArrayConfig = 3,
        }
        private ValueModeOneofCase valueModeCase_ = ValueModeOneofCase.None;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ValueModeOneofCase ValueModeCase {
          get { return valueModeCase_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void ClearValueMode() {
          valueModeCase_ = ValueModeOneofCase.None;
          valueMode_ = null;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as IndexField);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(IndexField other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (FieldPath != other.FieldPath) return false;
          if (Order != other.Order) return false;
          if (ArrayConfig != other.ArrayConfig) return false;
          if (ValueModeCase != other.ValueModeCase) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (FieldPath.Length != 0) hash ^= FieldPath.GetHashCode();
          if (valueModeCase_ == ValueModeOneofCase.Order) hash ^= Order.GetHashCode();
          if (valueModeCase_ == ValueModeOneofCase.ArrayConfig) hash ^= ArrayConfig.GetHashCode();
          hash ^= (int) valueModeCase_;
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
          if (FieldPath.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(FieldPath);
          }
          if (valueModeCase_ == ValueModeOneofCase.Order) {
            output.WriteRawTag(16);
            output.WriteEnum((int) Order);
          }
          if (valueModeCase_ == ValueModeOneofCase.ArrayConfig) {
            output.WriteRawTag(24);
            output.WriteEnum((int) ArrayConfig);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (FieldPath.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(FieldPath);
          }
          if (valueModeCase_ == ValueModeOneofCase.Order) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Order);
          }
          if (valueModeCase_ == ValueModeOneofCase.ArrayConfig) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ArrayConfig);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(IndexField other) {
          if (other == null) {
            return;
          }
          if (other.FieldPath.Length != 0) {
            FieldPath = other.FieldPath;
          }
          switch (other.ValueModeCase) {
            case ValueModeOneofCase.Order:
              Order = other.Order;
              break;
            case ValueModeOneofCase.ArrayConfig:
              ArrayConfig = other.ArrayConfig;
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
                FieldPath = input.ReadString();
                break;
              }
              case 16: {
                valueMode_ = input.ReadEnum();
                valueModeCase_ = ValueModeOneofCase.Order;
                break;
              }
              case 24: {
                valueMode_ = input.ReadEnum();
                valueModeCase_ = ValueModeOneofCase.ArrayConfig;
                break;
              }
            }
          }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the IndexField message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static partial class Types {
          /// <summary>
          /// The supported orderings.
          /// </summary>
          public enum Order {
            /// <summary>
            /// The ordering is unspecified. Not a valid option.
            /// </summary>
            [pbr::OriginalName("ORDER_UNSPECIFIED")] Unspecified = 0,
            /// <summary>
            /// The field is ordered by ascending field value.
            /// </summary>
            [pbr::OriginalName("ASCENDING")] Ascending = 1,
            /// <summary>
            /// The field is ordered by descending field value.
            /// </summary>
            [pbr::OriginalName("DESCENDING")] Descending = 2,
          }

          /// <summary>
          /// The supported array value configurations.
          /// </summary>
          public enum ArrayConfig {
            /// <summary>
            /// The index does not support additional array queries.
            /// </summary>
            [pbr::OriginalName("ARRAY_CONFIG_UNSPECIFIED")] Unspecified = 0,
            /// <summary>
            /// The index supports array containment queries.
            /// </summary>
            [pbr::OriginalName("CONTAINS")] Contains = 1,
          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
