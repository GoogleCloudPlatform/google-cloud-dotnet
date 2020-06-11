// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1p1beta1/source.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1P1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1p1beta1/source.proto</summary>
  public static partial class SourceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1p1beta1/source.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SourceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjFwMWJldGExL3NvdXJj",
            "ZS5wcm90bxIlZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnYxcDFiZXRh",
            "MRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxoZZ29vZ2xlL2FwaS9y",
            "ZXNvdXJjZS5wcm90byKbAQoGU291cmNlEgwKBG5hbWUYASABKAkSFAoMZGlz",
            "cGxheV9uYW1lGAIgASgJEhMKC2Rlc2NyaXB0aW9uGAMgASgJOljqQVUKJHNl",
            "Y3VyaXR5Y2VudGVyLmdvb2dsZWFwaXMuY29tL1NvdXJjZRItb3JnYW5pemF0",
            "aW9ucy97b3JnYW5pemF0aW9ufS9zb3VyY2VzL3tzb3VyY2V9Qv0BCiljb20u",
            "Z29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnYxcDFiZXRhMVABWlNnb29n",
            "bGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Nsb3VkL3NlY3Vy",
            "aXR5Y2VudGVyL3YxcDFiZXRhMTtzZWN1cml0eWNlbnRlcqoCJUdvb2dsZS5D",
            "bG91ZC5TZWN1cml0eUNlbnRlci5WMVAxQmV0YTHKAiVHb29nbGVcQ2xvdWRc",
            "U2VjdXJpdHlDZW50ZXJcVjFwMWJldGEx6gIoR29vZ2xlOjpDbG91ZDo6U2Vj",
            "dXJpdHlDZW50ZXI6OlYxcDFiZXRhMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1P1Beta1.Source), global::Google.Cloud.SecurityCenter.V1P1Beta1.Source.Parser, new[]{ "Name", "DisplayName", "Description" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Security Command Center finding source. A finding source
  /// is an entity or a mechanism that can produce a finding. A source is like a
  /// container of findings that come from the same scanner, logger, monitor, etc.
  /// </summary>
  public sealed partial class Source : pb::IMessage<Source> {
    private static readonly pb::MessageParser<Source> _parser = new pb::MessageParser<Source>(() => new Source());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Source> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1P1Beta1.SourceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Source() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Source(Source other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      description_ = other.description_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Source Clone() {
      return new Source(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The relative resource name of this source. See:
    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name
    /// Example:
    /// "organizations/{organization_id}/sources/{source_id}"
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
    /// The source's display name.
    /// A source's display name must be unique amongst its siblings, for example,
    /// two sources with the same parent can't share the same display name.
    /// The display name must have a length between 1 and 64 characters
    /// (inclusive).
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
    /// The description of the source (max of 1024 characters).
    /// Example:
    /// "Web Security Scanner is a web security scanner for common
    /// vulnerabilities in App Engine applications. It can automatically
    /// scan and detect four common vulnerabilities, including cross-site-scripting
    /// (XSS), Flash injection, mixed content (HTTP in HTTPS), and
    /// outdated/insecure libraries."
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Source);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Source other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (Description != other.Description) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
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
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Source other) {
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
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
