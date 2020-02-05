// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/spanner/v1/keys.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Spanner.V1 {

  /// <summary>Holder for reflection information generated from google/spanner/v1/keys.proto</summary>
  public static partial class KeysReflection {

    #region Descriptor
    /// <summary>File descriptor for google/spanner/v1/keys.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeysReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chxnb29nbGUvc3Bhbm5lci92MS9rZXlzLnByb3RvEhFnb29nbGUuc3Bhbm5l",
            "ci52MRocZ29vZ2xlL3Byb3RvYnVmL3N0cnVjdC5wcm90bxocZ29vZ2xlL2Fw",
            "aS9hbm5vdGF0aW9ucy5wcm90byL0AQoIS2V5UmFuZ2USMgoMc3RhcnRfY2xv",
            "c2VkGAEgASgLMhouZ29vZ2xlLnByb3RvYnVmLkxpc3RWYWx1ZUgAEjAKCnN0",
            "YXJ0X29wZW4YAiABKAsyGi5nb29nbGUucHJvdG9idWYuTGlzdFZhbHVlSAAS",
            "MAoKZW5kX2Nsb3NlZBgDIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5MaXN0VmFs",
            "dWVIARIuCghlbmRfb3BlbhgEIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5MaXN0",
            "VmFsdWVIAUIQCg5zdGFydF9rZXlfdHlwZUIOCgxlbmRfa2V5X3R5cGUibAoG",
            "S2V5U2V0EigKBGtleXMYASADKAsyGi5nb29nbGUucHJvdG9idWYuTGlzdFZh",
            "bHVlEisKBnJhbmdlcxgCIAMoCzIbLmdvb2dsZS5zcGFubmVyLnYxLktleVJh",
            "bmdlEgsKA2FsbBgDIAEoCEKSAQoVY29tLmdvb2dsZS5zcGFubmVyLnYxQglL",
            "ZXlzUHJvdG9QAVo4Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9zcGFubmVyL3YxO3NwYW5uZXKqAhdHb29nbGUuQ2xvdWQuU3Bhbm5l",
            "ci5WMcoCF0dvb2dsZVxDbG91ZFxTcGFubmVyXFYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Spanner.V1.KeyRange), global::Google.Cloud.Spanner.V1.KeyRange.Parser, new[]{ "StartClosed", "StartOpen", "EndClosed", "EndOpen" }, new[]{ "StartKeyType", "EndKeyType" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Spanner.V1.KeySet), global::Google.Cloud.Spanner.V1.KeySet.Parser, new[]{ "Keys", "Ranges", "All" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// KeyRange represents a range of rows in a table or index.
  ///
  /// A range has a start key and an end key. These keys can be open or
  /// closed, indicating if the range includes rows with that key.
  ///
  /// Keys are represented by lists, where the ith value in the list
  /// corresponds to the ith component of the table or index primary key.
  /// Individual values are encoded as described
  /// [here][google.spanner.v1.TypeCode].
  ///
  /// For example, consider the following table definition:
  ///
  ///     CREATE TABLE UserEvents (
  ///       UserName STRING(MAX),
  ///       EventDate STRING(10)
  ///     ) PRIMARY KEY(UserName, EventDate);
  ///
  /// The following keys name rows in this table:
  ///
  ///     ["Bob", "2014-09-23"]
  ///     ["Alfred", "2015-06-12"]
  ///
  /// Since the `UserEvents` table's `PRIMARY KEY` clause names two
  /// columns, each `UserEvents` key has two elements; the first is the
  /// `UserName`, and the second is the `EventDate`.
  ///
  /// Key ranges with multiple components are interpreted
  /// lexicographically by component using the table or index key's declared
  /// sort order. For example, the following range returns all events for
  /// user `"Bob"` that occurred in the year 2015:
  ///
  ///     "start_closed": ["Bob", "2015-01-01"]
  ///     "end_closed": ["Bob", "2015-12-31"]
  ///
  /// Start and end keys can omit trailing key components. This affects the
  /// inclusion and exclusion of rows that exactly match the provided key
  /// components: if the key is closed, then rows that exactly match the
  /// provided components are included; if the key is open, then rows
  /// that exactly match are not included.
  ///
  /// For example, the following range includes all events for `"Bob"` that
  /// occurred during and after the year 2000:
  ///
  ///     "start_closed": ["Bob", "2000-01-01"]
  ///     "end_closed": ["Bob"]
  ///
  /// The next example retrieves all events for `"Bob"`:
  ///
  ///     "start_closed": ["Bob"]
  ///     "end_closed": ["Bob"]
  ///
  /// To retrieve events before the year 2000:
  ///
  ///     "start_closed": ["Bob"]
  ///     "end_open": ["Bob", "2000-01-01"]
  ///
  /// The following range includes all rows in the table:
  ///
  ///     "start_closed": []
  ///     "end_closed": []
  ///
  /// This range returns all users whose `UserName` begins with any
  /// character from A to C:
  ///
  ///     "start_closed": ["A"]
  ///     "end_open": ["D"]
  ///
  /// This range returns all users whose `UserName` begins with B:
  ///
  ///     "start_closed": ["B"]
  ///     "end_open": ["C"]
  ///
  /// Key ranges honor column sort order. For example, suppose a table is
  /// defined as follows:
  ///
  ///     CREATE TABLE DescendingSortedTable {
  ///       Key INT64,
  ///       ...
  ///     ) PRIMARY KEY(Key DESC);
  ///
  /// The following range retrieves all rows with key values between 1
  /// and 100 inclusive:
  ///
  ///     "start_closed": ["100"]
  ///     "end_closed": ["1"]
  ///
  /// Note that 100 is passed as the start, and 1 is passed as the end,
  /// because `Key` is a descending column in the schema.
  /// </summary>
  public sealed partial class KeyRange : pb::IMessage<KeyRange> {
    private static readonly pb::MessageParser<KeyRange> _parser = new pb::MessageParser<KeyRange>(() => new KeyRange());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeyRange> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Spanner.V1.KeysReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeyRange() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeyRange(KeyRange other) : this() {
      switch (other.StartKeyTypeCase) {
        case StartKeyTypeOneofCase.StartClosed:
          StartClosed = other.StartClosed.Clone();
          break;
        case StartKeyTypeOneofCase.StartOpen:
          StartOpen = other.StartOpen.Clone();
          break;
      }

      switch (other.EndKeyTypeCase) {
        case EndKeyTypeOneofCase.EndClosed:
          EndClosed = other.EndClosed.Clone();
          break;
        case EndKeyTypeOneofCase.EndOpen:
          EndOpen = other.EndOpen.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeyRange Clone() {
      return new KeyRange(this);
    }

    /// <summary>Field number for the "start_closed" field.</summary>
    public const int StartClosedFieldNumber = 1;
    /// <summary>
    /// If the start is closed, then the range includes all rows whose
    /// first `len(start_closed)` key columns exactly match `start_closed`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.ListValue StartClosed {
      get { return startKeyTypeCase_ == StartKeyTypeOneofCase.StartClosed ? (global::Google.Protobuf.WellKnownTypes.ListValue) startKeyType_ : null; }
      set {
        startKeyType_ = value;
        startKeyTypeCase_ = value == null ? StartKeyTypeOneofCase.None : StartKeyTypeOneofCase.StartClosed;
      }
    }

    /// <summary>Field number for the "start_open" field.</summary>
    public const int StartOpenFieldNumber = 2;
    /// <summary>
    /// If the start is open, then the range excludes rows whose first
    /// `len(start_open)` key columns exactly match `start_open`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.ListValue StartOpen {
      get { return startKeyTypeCase_ == StartKeyTypeOneofCase.StartOpen ? (global::Google.Protobuf.WellKnownTypes.ListValue) startKeyType_ : null; }
      set {
        startKeyType_ = value;
        startKeyTypeCase_ = value == null ? StartKeyTypeOneofCase.None : StartKeyTypeOneofCase.StartOpen;
      }
    }

    /// <summary>Field number for the "end_closed" field.</summary>
    public const int EndClosedFieldNumber = 3;
    /// <summary>
    /// If the end is closed, then the range includes all rows whose
    /// first `len(end_closed)` key columns exactly match `end_closed`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.ListValue EndClosed {
      get { return endKeyTypeCase_ == EndKeyTypeOneofCase.EndClosed ? (global::Google.Protobuf.WellKnownTypes.ListValue) endKeyType_ : null; }
      set {
        endKeyType_ = value;
        endKeyTypeCase_ = value == null ? EndKeyTypeOneofCase.None : EndKeyTypeOneofCase.EndClosed;
      }
    }

    /// <summary>Field number for the "end_open" field.</summary>
    public const int EndOpenFieldNumber = 4;
    /// <summary>
    /// If the end is open, then the range excludes rows whose first
    /// `len(end_open)` key columns exactly match `end_open`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.ListValue EndOpen {
      get { return endKeyTypeCase_ == EndKeyTypeOneofCase.EndOpen ? (global::Google.Protobuf.WellKnownTypes.ListValue) endKeyType_ : null; }
      set {
        endKeyType_ = value;
        endKeyTypeCase_ = value == null ? EndKeyTypeOneofCase.None : EndKeyTypeOneofCase.EndOpen;
      }
    }

    private object startKeyType_;
    /// <summary>Enum of possible cases for the "start_key_type" oneof.</summary>
    public enum StartKeyTypeOneofCase {
      None = 0,
      StartClosed = 1,
      StartOpen = 2,
    }
    private StartKeyTypeOneofCase startKeyTypeCase_ = StartKeyTypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StartKeyTypeOneofCase StartKeyTypeCase {
      get { return startKeyTypeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearStartKeyType() {
      startKeyTypeCase_ = StartKeyTypeOneofCase.None;
      startKeyType_ = null;
    }

    private object endKeyType_;
    /// <summary>Enum of possible cases for the "end_key_type" oneof.</summary>
    public enum EndKeyTypeOneofCase {
      None = 0,
      EndClosed = 3,
      EndOpen = 4,
    }
    private EndKeyTypeOneofCase endKeyTypeCase_ = EndKeyTypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EndKeyTypeOneofCase EndKeyTypeCase {
      get { return endKeyTypeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearEndKeyType() {
      endKeyTypeCase_ = EndKeyTypeOneofCase.None;
      endKeyType_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeyRange);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeyRange other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(StartClosed, other.StartClosed)) return false;
      if (!object.Equals(StartOpen, other.StartOpen)) return false;
      if (!object.Equals(EndClosed, other.EndClosed)) return false;
      if (!object.Equals(EndOpen, other.EndOpen)) return false;
      if (StartKeyTypeCase != other.StartKeyTypeCase) return false;
      if (EndKeyTypeCase != other.EndKeyTypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (startKeyTypeCase_ == StartKeyTypeOneofCase.StartClosed) hash ^= StartClosed.GetHashCode();
      if (startKeyTypeCase_ == StartKeyTypeOneofCase.StartOpen) hash ^= StartOpen.GetHashCode();
      if (endKeyTypeCase_ == EndKeyTypeOneofCase.EndClosed) hash ^= EndClosed.GetHashCode();
      if (endKeyTypeCase_ == EndKeyTypeOneofCase.EndOpen) hash ^= EndOpen.GetHashCode();
      hash ^= (int) startKeyTypeCase_;
      hash ^= (int) endKeyTypeCase_;
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
      if (startKeyTypeCase_ == StartKeyTypeOneofCase.StartClosed) {
        output.WriteRawTag(10);
        output.WriteMessage(StartClosed);
      }
      if (startKeyTypeCase_ == StartKeyTypeOneofCase.StartOpen) {
        output.WriteRawTag(18);
        output.WriteMessage(StartOpen);
      }
      if (endKeyTypeCase_ == EndKeyTypeOneofCase.EndClosed) {
        output.WriteRawTag(26);
        output.WriteMessage(EndClosed);
      }
      if (endKeyTypeCase_ == EndKeyTypeOneofCase.EndOpen) {
        output.WriteRawTag(34);
        output.WriteMessage(EndOpen);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (startKeyTypeCase_ == StartKeyTypeOneofCase.StartClosed) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartClosed);
      }
      if (startKeyTypeCase_ == StartKeyTypeOneofCase.StartOpen) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartOpen);
      }
      if (endKeyTypeCase_ == EndKeyTypeOneofCase.EndClosed) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndClosed);
      }
      if (endKeyTypeCase_ == EndKeyTypeOneofCase.EndOpen) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndOpen);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KeyRange other) {
      if (other == null) {
        return;
      }
      switch (other.StartKeyTypeCase) {
        case StartKeyTypeOneofCase.StartClosed:
          if (StartClosed == null) {
            StartClosed = new global::Google.Protobuf.WellKnownTypes.ListValue();
          }
          StartClosed.MergeFrom(other.StartClosed);
          break;
        case StartKeyTypeOneofCase.StartOpen:
          if (StartOpen == null) {
            StartOpen = new global::Google.Protobuf.WellKnownTypes.ListValue();
          }
          StartOpen.MergeFrom(other.StartOpen);
          break;
      }

      switch (other.EndKeyTypeCase) {
        case EndKeyTypeOneofCase.EndClosed:
          if (EndClosed == null) {
            EndClosed = new global::Google.Protobuf.WellKnownTypes.ListValue();
          }
          EndClosed.MergeFrom(other.EndClosed);
          break;
        case EndKeyTypeOneofCase.EndOpen:
          if (EndOpen == null) {
            EndOpen = new global::Google.Protobuf.WellKnownTypes.ListValue();
          }
          EndOpen.MergeFrom(other.EndOpen);
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
            global::Google.Protobuf.WellKnownTypes.ListValue subBuilder = new global::Google.Protobuf.WellKnownTypes.ListValue();
            if (startKeyTypeCase_ == StartKeyTypeOneofCase.StartClosed) {
              subBuilder.MergeFrom(StartClosed);
            }
            input.ReadMessage(subBuilder);
            StartClosed = subBuilder;
            break;
          }
          case 18: {
            global::Google.Protobuf.WellKnownTypes.ListValue subBuilder = new global::Google.Protobuf.WellKnownTypes.ListValue();
            if (startKeyTypeCase_ == StartKeyTypeOneofCase.StartOpen) {
              subBuilder.MergeFrom(StartOpen);
            }
            input.ReadMessage(subBuilder);
            StartOpen = subBuilder;
            break;
          }
          case 26: {
            global::Google.Protobuf.WellKnownTypes.ListValue subBuilder = new global::Google.Protobuf.WellKnownTypes.ListValue();
            if (endKeyTypeCase_ == EndKeyTypeOneofCase.EndClosed) {
              subBuilder.MergeFrom(EndClosed);
            }
            input.ReadMessage(subBuilder);
            EndClosed = subBuilder;
            break;
          }
          case 34: {
            global::Google.Protobuf.WellKnownTypes.ListValue subBuilder = new global::Google.Protobuf.WellKnownTypes.ListValue();
            if (endKeyTypeCase_ == EndKeyTypeOneofCase.EndOpen) {
              subBuilder.MergeFrom(EndOpen);
            }
            input.ReadMessage(subBuilder);
            EndOpen = subBuilder;
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// `KeySet` defines a collection of Cloud Spanner keys and/or key ranges. All
  /// the keys are expected to be in the same table or index. The keys need
  /// not be sorted in any particular way.
  ///
  /// If the same key is specified multiple times in the set (for example
  /// if two ranges, two keys, or a key and a range overlap), Cloud Spanner
  /// behaves as if the key were only specified once.
  /// </summary>
  public sealed partial class KeySet : pb::IMessage<KeySet> {
    private static readonly pb::MessageParser<KeySet> _parser = new pb::MessageParser<KeySet>(() => new KeySet());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeySet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Spanner.V1.KeysReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeySet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeySet(KeySet other) : this() {
      keys_ = other.keys_.Clone();
      ranges_ = other.ranges_.Clone();
      all_ = other.all_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeySet Clone() {
      return new KeySet(this);
    }

    /// <summary>Field number for the "keys" field.</summary>
    public const int KeysFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.ListValue> _repeated_keys_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Protobuf.WellKnownTypes.ListValue.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.ListValue> keys_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.ListValue>();
    /// <summary>
    /// A list of specific keys. Entries in `keys` should have exactly as
    /// many elements as there are columns in the primary or index key
    /// with which this `KeySet` is used.  Individual key values are
    /// encoded as described [here][google.spanner.v1.TypeCode].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.ListValue> Keys {
      get { return keys_; }
    }

    /// <summary>Field number for the "ranges" field.</summary>
    public const int RangesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Cloud.Spanner.V1.KeyRange> _repeated_ranges_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Cloud.Spanner.V1.KeyRange.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Spanner.V1.KeyRange> ranges_ = new pbc::RepeatedField<global::Google.Cloud.Spanner.V1.KeyRange>();
    /// <summary>
    /// A list of key ranges. See [KeyRange][google.spanner.v1.KeyRange] for more information about
    /// key range specifications.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Spanner.V1.KeyRange> Ranges {
      get { return ranges_; }
    }

    /// <summary>Field number for the "all" field.</summary>
    public const int AllFieldNumber = 3;
    private bool all_;
    /// <summary>
    /// For convenience `all` can be set to `true` to indicate that this
    /// `KeySet` matches all keys in the table or index. Note that any keys
    /// specified in `keys` or `ranges` are only yielded once.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool All {
      get { return all_; }
      set {
        all_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeySet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeySet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!keys_.Equals(other.keys_)) return false;
      if(!ranges_.Equals(other.ranges_)) return false;
      if (All != other.All) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= keys_.GetHashCode();
      hash ^= ranges_.GetHashCode();
      if (All != false) hash ^= All.GetHashCode();
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
      keys_.WriteTo(output, _repeated_keys_codec);
      ranges_.WriteTo(output, _repeated_ranges_codec);
      if (All != false) {
        output.WriteRawTag(24);
        output.WriteBool(All);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += keys_.CalculateSize(_repeated_keys_codec);
      size += ranges_.CalculateSize(_repeated_ranges_codec);
      if (All != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KeySet other) {
      if (other == null) {
        return;
      }
      keys_.Add(other.keys_);
      ranges_.Add(other.ranges_);
      if (other.All != false) {
        All = other.All;
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
            keys_.AddEntriesFrom(input, _repeated_keys_codec);
            break;
          }
          case 18: {
            ranges_.AddEntriesFrom(input, _repeated_ranges_codec);
            break;
          }
          case 24: {
            All = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
