// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/monitoring/v3/dropped_labels.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Monitoring.V3 {

  /// <summary>Holder for reflection information generated from google/monitoring/v3/dropped_labels.proto</summary>
  public static partial class DroppedLabelsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/monitoring/v3/dropped_labels.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DroppedLabelsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cilnb29nbGUvbW9uaXRvcmluZy92My9kcm9wcGVkX2xhYmVscy5wcm90bxIU",
            "Z29vZ2xlLm1vbml0b3JpbmcudjMifAoNRHJvcHBlZExhYmVscxI9CgVsYWJl",
            "bBgBIAMoCzIuLmdvb2dsZS5tb25pdG9yaW5nLnYzLkRyb3BwZWRMYWJlbHMu",
            "TGFiZWxFbnRyeRosCgpMYWJlbEVudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1",
            "ZRgCIAEoCToCOAFCqgEKGGNvbS5nb29nbGUubW9uaXRvcmluZy52M0ISRHJv",
            "cHBlZExhYmVsc1Byb3RvUAFaPmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3Rv",
            "L2dvb2dsZWFwaXMvbW9uaXRvcmluZy92Mzttb25pdG9yaW5nqgIaR29vZ2xl",
            "LkNsb3VkLk1vbml0b3JpbmcuVjPKAhpHb29nbGVcQ2xvdWRcTW9uaXRvcmlu",
            "Z1xWM2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Monitoring.V3.DroppedLabels), global::Google.Cloud.Monitoring.V3.DroppedLabels.Parser, new[]{ "Label" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A set of (label, value) pairs which were dropped during aggregation, attached
  /// to google.api.Distribution.Exemplars in google.api.Distribution values during
  /// aggregation.
  ///
  /// These values are used in combination with the label values that remain on the
  /// aggregated Distribution timeseries to construct the full label set for the
  /// exemplar values.  The resulting full label set may be used to identify the
  /// specific task/job/instance (for example) which may be contributing to a
  /// long-tail, while allowing the storage savings of only storing aggregated
  /// distribution values for a large group.
  ///
  /// Note that there are no guarantees on ordering of the labels from
  /// exemplar-to-exemplar and from distribution-to-distribution in the same
  /// stream, and there may be duplicates.  It is up to clients to resolve any
  /// ambiguities.
  /// </summary>
  public sealed partial class DroppedLabels : pb::IMessage<DroppedLabels> {
    private static readonly pb::MessageParser<DroppedLabels> _parser = new pb::MessageParser<DroppedLabels>(() => new DroppedLabels());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DroppedLabels> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Monitoring.V3.DroppedLabelsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DroppedLabels() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DroppedLabels(DroppedLabels other) : this() {
      label_ = other.label_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DroppedLabels Clone() {
      return new DroppedLabels(this);
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 1;
    private static readonly pbc::MapField<string, string>.Codec _map_label_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 10);
    private readonly pbc::MapField<string, string> label_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Map from label to its value, for all labels dropped in any aggregation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Label {
      get { return label_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DroppedLabels);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DroppedLabels other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Label.Equals(other.Label)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Label.GetHashCode();
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
      label_.WriteTo(output, _map_label_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += label_.CalculateSize(_map_label_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DroppedLabels other) {
      if (other == null) {
        return;
      }
      label_.Add(other.label_);
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
            label_.AddEntriesFrom(input, _map_label_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
