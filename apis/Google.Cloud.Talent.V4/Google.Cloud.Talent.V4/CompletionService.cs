// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/talent/v4/completion_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Talent.V4 {

  /// <summary>Holder for reflection information generated from google/cloud/talent/v4/completion_service.proto</summary>
  public static partial class CompletionServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/talent/v4/completion_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompletionServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvY2xvdWQvdGFsZW50L3Y0L2NvbXBsZXRpb25fc2VydmljZS5w",
            "cm90bxIWZ29vZ2xlLmNsb3VkLnRhbGVudC52NBocZ29vZ2xlL2FwaS9hbm5v",
            "dGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8aH2dvb2ds",
            "ZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3Vy",
            "Y2UucHJvdG8aI2dvb2dsZS9jbG91ZC90YWxlbnQvdjQvY29tbW9uLnByb3Rv",
            "IogEChRDb21wbGV0ZVF1ZXJ5UmVxdWVzdBIyCgZ0ZW5hbnQYASABKAlCIuBB",
            "AvpBHAoaam9icy5nb29nbGVhcGlzLmNvbS9UZW5hbnQSEgoFcXVlcnkYAiAB",
            "KAlCA+BBAhIWCg5sYW5ndWFnZV9jb2RlcxgDIAMoCRIWCglwYWdlX3NpemUY",
            "BCABKAVCA+BBAhIxCgdjb21wYW55GAUgASgJQiD6QR0KG2pvYnMuZ29vZ2xl",
            "YXBpcy5jb20vQ29tcGFueRJLCgVzY29wZRgGIAEoDjI8Lmdvb2dsZS5jbG91",
            "ZC50YWxlbnQudjQuQ29tcGxldGVRdWVyeVJlcXVlc3QuQ29tcGxldGlvblNj",
            "b3BlEkkKBHR5cGUYByABKA4yOy5nb29nbGUuY2xvdWQudGFsZW50LnY0LkNv",
            "bXBsZXRlUXVlcnlSZXF1ZXN0LkNvbXBsZXRpb25UeXBlIksKD0NvbXBsZXRp",
            "b25TY29wZRIgChxDT01QTEVUSU9OX1NDT1BFX1VOU1BFQ0lGSUVEEAASCgoG",
            "VEVOQU5UEAESCgoGUFVCTElDEAIiYAoOQ29tcGxldGlvblR5cGUSHwobQ09N",
            "UExFVElPTl9UWVBFX1VOU1BFQ0lGSUVEEAASDQoJSk9CX1RJVExFEAESEAoM",
            "Q09NUEFOWV9OQU1FEAISDAoIQ09NQklORUQQAyK2AgoVQ29tcGxldGVRdWVy",
            "eVJlc3BvbnNlEloKEmNvbXBsZXRpb25fcmVzdWx0cxgBIAMoCzI+Lmdvb2ds",
            "ZS5jbG91ZC50YWxlbnQudjQuQ29tcGxldGVRdWVyeVJlc3BvbnNlLkNvbXBs",
            "ZXRpb25SZXN1bHQSOgoIbWV0YWRhdGEYAiABKAsyKC5nb29nbGUuY2xvdWQu",
            "dGFsZW50LnY0LlJlc3BvbnNlTWV0YWRhdGEahAEKEENvbXBsZXRpb25SZXN1",
            "bHQSEgoKc3VnZ2VzdGlvbhgBIAEoCRJJCgR0eXBlGAIgASgOMjsuZ29vZ2xl",
            "LmNsb3VkLnRhbGVudC52NC5Db21wbGV0ZVF1ZXJ5UmVxdWVzdC5Db21wbGV0",
            "aW9uVHlwZRIRCglpbWFnZV91cmkYAyABKAkyogIKCkNvbXBsZXRpb24SpQEK",
            "DUNvbXBsZXRlUXVlcnkSLC5nb29nbGUuY2xvdWQudGFsZW50LnY0LkNvbXBs",
            "ZXRlUXVlcnlSZXF1ZXN0Gi0uZ29vZ2xlLmNsb3VkLnRhbGVudC52NC5Db21w",
            "bGV0ZVF1ZXJ5UmVzcG9uc2UiN4LT5JMCMRIvL3Y0L3t0ZW5hbnQ9cHJvamVj",
            "dHMvKi90ZW5hbnRzLyp9OmNvbXBsZXRlUXVlcnkabMpBE2pvYnMuZ29vZ2xl",
            "YXBpcy5jb23SQVNodHRwczovL3d3dy5nb29nbGVhcGlzLmNvbS9hdXRoL2Ns",
            "b3VkLXBsYXRmb3JtLGh0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1dGgv",
            "am9ic0J6Chpjb20uZ29vZ2xlLmNsb3VkLnRhbGVudC52NEIWQ29tcGxldGlv",
            "blNlcnZpY2VQcm90b1ABWjxnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL2Nsb3VkL3RhbGVudC92NDt0YWxlbnSiAgNDVFNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.Talent.V4.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Talent.V4.CompleteQueryRequest), global::Google.Cloud.Talent.V4.CompleteQueryRequest.Parser, new[]{ "Tenant", "Query", "LanguageCodes", "PageSize", "Company", "Scope", "Type" }, null, new[]{ typeof(global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionScope), typeof(global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionType) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Talent.V4.CompleteQueryResponse), global::Google.Cloud.Talent.V4.CompleteQueryResponse.Parser, new[]{ "CompletionResults", "Metadata" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Talent.V4.CompleteQueryResponse.Types.CompletionResult), global::Google.Cloud.Talent.V4.CompleteQueryResponse.Types.CompletionResult.Parser, new[]{ "Suggestion", "Type", "ImageUri" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Auto-complete parameters.
  /// </summary>
  public sealed partial class CompleteQueryRequest : pb::IMessage<CompleteQueryRequest> {
    private static readonly pb::MessageParser<CompleteQueryRequest> _parser = new pb::MessageParser<CompleteQueryRequest>(() => new CompleteQueryRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompleteQueryRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Talent.V4.CompletionServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQueryRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQueryRequest(CompleteQueryRequest other) : this() {
      tenant_ = other.tenant_;
      query_ = other.query_;
      languageCodes_ = other.languageCodes_.Clone();
      pageSize_ = other.pageSize_;
      company_ = other.company_;
      scope_ = other.scope_;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQueryRequest Clone() {
      return new CompleteQueryRequest(this);
    }

    /// <summary>Field number for the "tenant" field.</summary>
    public const int TenantFieldNumber = 1;
    private string tenant_ = "";
    /// <summary>
    /// Required. Resource name of tenant the completion is performed within.
    ///
    /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
    /// "projects/foo/tenants/bar".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Tenant {
      get { return tenant_; }
      set {
        tenant_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "query" field.</summary>
    public const int QueryFieldNumber = 2;
    private string query_ = "";
    /// <summary>
    /// Required. The query used to generate suggestions.
    ///
    /// The maximum number of allowed characters is 255.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Query {
      get { return query_; }
      set {
        query_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "language_codes" field.</summary>
    public const int LanguageCodesFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_languageCodes_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> languageCodes_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The list of languages of the query. This is
    /// the BCP-47 language code, such as "en-US" or "sr-Latn".
    /// For more information, see
    /// [Tags for Identifying Languages](https://tools.ietf.org/html/bcp47).
    ///
    /// The maximum number of allowed characters is 255.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> LanguageCodes {
      get { return languageCodes_; }
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 4;
    private int pageSize_;
    /// <summary>
    /// Required. Completion result count.
    ///
    /// The maximum allowed page size is 10.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PageSize {
      get { return pageSize_; }
      set {
        pageSize_ = value;
      }
    }

    /// <summary>Field number for the "company" field.</summary>
    public const int CompanyFieldNumber = 5;
    private string company_ = "";
    /// <summary>
    /// If provided, restricts completion to specified company.
    ///
    /// The format is
    /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
    /// example, "projects/foo/tenants/bar/companies/baz".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Company {
      get { return company_; }
      set {
        company_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "scope" field.</summary>
    public const int ScopeFieldNumber = 6;
    private global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionScope scope_ = global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionScope.Unspecified;
    /// <summary>
    /// The scope of the completion. The defaults is
    /// [CompletionScope.PUBLIC][google.cloud.talent.v4.CompleteQueryRequest.CompletionScope.PUBLIC].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionScope Scope {
      get { return scope_; }
      set {
        scope_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 7;
    private global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionType type_ = global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionType.Unspecified;
    /// <summary>
    /// The completion topic. The default is
    /// [CompletionType.COMBINED][google.cloud.talent.v4.CompleteQueryRequest.CompletionType.COMBINED].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompleteQueryRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompleteQueryRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Tenant != other.Tenant) return false;
      if (Query != other.Query) return false;
      if(!languageCodes_.Equals(other.languageCodes_)) return false;
      if (PageSize != other.PageSize) return false;
      if (Company != other.Company) return false;
      if (Scope != other.Scope) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Tenant.Length != 0) hash ^= Tenant.GetHashCode();
      if (Query.Length != 0) hash ^= Query.GetHashCode();
      hash ^= languageCodes_.GetHashCode();
      if (PageSize != 0) hash ^= PageSize.GetHashCode();
      if (Company.Length != 0) hash ^= Company.GetHashCode();
      if (Scope != global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionScope.Unspecified) hash ^= Scope.GetHashCode();
      if (Type != global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionType.Unspecified) hash ^= Type.GetHashCode();
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
      if (Tenant.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Tenant);
      }
      if (Query.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Query);
      }
      languageCodes_.WriteTo(output, _repeated_languageCodes_codec);
      if (PageSize != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(PageSize);
      }
      if (Company.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Company);
      }
      if (Scope != global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionScope.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Scope);
      }
      if (Type != global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionType.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Tenant.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Tenant);
      }
      if (Query.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Query);
      }
      size += languageCodes_.CalculateSize(_repeated_languageCodes_codec);
      if (PageSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageSize);
      }
      if (Company.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Company);
      }
      if (Scope != global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionScope.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Scope);
      }
      if (Type != global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompleteQueryRequest other) {
      if (other == null) {
        return;
      }
      if (other.Tenant.Length != 0) {
        Tenant = other.Tenant;
      }
      if (other.Query.Length != 0) {
        Query = other.Query;
      }
      languageCodes_.Add(other.languageCodes_);
      if (other.PageSize != 0) {
        PageSize = other.PageSize;
      }
      if (other.Company.Length != 0) {
        Company = other.Company;
      }
      if (other.Scope != global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionScope.Unspecified) {
        Scope = other.Scope;
      }
      if (other.Type != global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionType.Unspecified) {
        Type = other.Type;
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
            Tenant = input.ReadString();
            break;
          }
          case 18: {
            Query = input.ReadString();
            break;
          }
          case 26: {
            languageCodes_.AddEntriesFrom(input, _repeated_languageCodes_codec);
            break;
          }
          case 32: {
            PageSize = input.ReadInt32();
            break;
          }
          case 42: {
            Company = input.ReadString();
            break;
          }
          case 48: {
            Scope = (global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionScope) input.ReadEnum();
            break;
          }
          case 56: {
            Type = (global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionType) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CompleteQueryRequest message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum to specify the scope of completion.
      /// </summary>
      public enum CompletionScope {
        /// <summary>
        /// Default value.
        /// </summary>
        [pbr::OriginalName("COMPLETION_SCOPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Suggestions are based only on the data provided by the client.
        /// </summary>
        [pbr::OriginalName("TENANT")] Tenant = 1,
        /// <summary>
        /// Suggestions are based on all jobs data in the system that's visible to
        /// the client
        /// </summary>
        [pbr::OriginalName("PUBLIC")] Public = 2,
      }

      /// <summary>
      /// Enum to specify auto-completion topics.
      /// </summary>
      public enum CompletionType {
        /// <summary>
        /// Default value.
        /// </summary>
        [pbr::OriginalName("COMPLETION_TYPE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Suggest job titles for jobs autocomplete.
        ///
        /// For
        /// [CompletionType.JOB_TITLE][google.cloud.talent.v4.CompleteQueryRequest.CompletionType.JOB_TITLE]
        /// type, only open jobs with the same
        /// [language_codes][google.cloud.talent.v4.CompleteQueryRequest.language_codes]
        /// are returned.
        /// </summary>
        [pbr::OriginalName("JOB_TITLE")] JobTitle = 1,
        /// <summary>
        /// Suggest company names for jobs autocomplete.
        ///
        /// For
        /// [CompletionType.COMPANY_NAME][google.cloud.talent.v4.CompleteQueryRequest.CompletionType.COMPANY_NAME]
        /// type, only companies having open jobs with the same
        /// [language_codes][google.cloud.talent.v4.CompleteQueryRequest.language_codes]
        /// are returned.
        /// </summary>
        [pbr::OriginalName("COMPANY_NAME")] CompanyName = 2,
        /// <summary>
        /// Suggest both job titles and company names for jobs autocomplete.
        ///
        /// For
        /// [CompletionType.COMBINED][google.cloud.talent.v4.CompleteQueryRequest.CompletionType.COMBINED]
        /// type, only open jobs with the same
        /// [language_codes][google.cloud.talent.v4.CompleteQueryRequest.language_codes]
        /// or companies having open jobs with the same
        /// [language_codes][google.cloud.talent.v4.CompleteQueryRequest.language_codes]
        /// are returned.
        /// </summary>
        [pbr::OriginalName("COMBINED")] Combined = 3,
      }

    }
    #endregion

  }

  /// <summary>
  /// Response of auto-complete query.
  /// </summary>
  public sealed partial class CompleteQueryResponse : pb::IMessage<CompleteQueryResponse> {
    private static readonly pb::MessageParser<CompleteQueryResponse> _parser = new pb::MessageParser<CompleteQueryResponse>(() => new CompleteQueryResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompleteQueryResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Talent.V4.CompletionServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQueryResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQueryResponse(CompleteQueryResponse other) : this() {
      completionResults_ = other.completionResults_.Clone();
      metadata_ = other.metadata_ != null ? other.metadata_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQueryResponse Clone() {
      return new CompleteQueryResponse(this);
    }

    /// <summary>Field number for the "completion_results" field.</summary>
    public const int CompletionResultsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Cloud.Talent.V4.CompleteQueryResponse.Types.CompletionResult> _repeated_completionResults_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Cloud.Talent.V4.CompleteQueryResponse.Types.CompletionResult.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Talent.V4.CompleteQueryResponse.Types.CompletionResult> completionResults_ = new pbc::RepeatedField<global::Google.Cloud.Talent.V4.CompleteQueryResponse.Types.CompletionResult>();
    /// <summary>
    /// Results of the matching job/company candidates.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Talent.V4.CompleteQueryResponse.Types.CompletionResult> CompletionResults {
      get { return completionResults_; }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 2;
    private global::Google.Cloud.Talent.V4.ResponseMetadata metadata_;
    /// <summary>
    /// Additional information for the API invocation, such as the request
    /// tracking id.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Talent.V4.ResponseMetadata Metadata {
      get { return metadata_; }
      set {
        metadata_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompleteQueryResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompleteQueryResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!completionResults_.Equals(other.completionResults_)) return false;
      if (!object.Equals(Metadata, other.Metadata)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= completionResults_.GetHashCode();
      if (metadata_ != null) hash ^= Metadata.GetHashCode();
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
      completionResults_.WriteTo(output, _repeated_completionResults_codec);
      if (metadata_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Metadata);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += completionResults_.CalculateSize(_repeated_completionResults_codec);
      if (metadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metadata);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompleteQueryResponse other) {
      if (other == null) {
        return;
      }
      completionResults_.Add(other.completionResults_);
      if (other.metadata_ != null) {
        if (metadata_ == null) {
          Metadata = new global::Google.Cloud.Talent.V4.ResponseMetadata();
        }
        Metadata.MergeFrom(other.Metadata);
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
            completionResults_.AddEntriesFrom(input, _repeated_completionResults_codec);
            break;
          }
          case 18: {
            if (metadata_ == null) {
              Metadata = new global::Google.Cloud.Talent.V4.ResponseMetadata();
            }
            input.ReadMessage(Metadata);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CompleteQueryResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Resource that represents completion results.
      /// </summary>
      public sealed partial class CompletionResult : pb::IMessage<CompletionResult> {
        private static readonly pb::MessageParser<CompletionResult> _parser = new pb::MessageParser<CompletionResult>(() => new CompletionResult());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<CompletionResult> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Talent.V4.CompleteQueryResponse.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CompletionResult() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CompletionResult(CompletionResult other) : this() {
          suggestion_ = other.suggestion_;
          type_ = other.type_;
          imageUri_ = other.imageUri_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public CompletionResult Clone() {
          return new CompletionResult(this);
        }

        /// <summary>Field number for the "suggestion" field.</summary>
        public const int SuggestionFieldNumber = 1;
        private string suggestion_ = "";
        /// <summary>
        /// The suggestion for the query.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Suggestion {
          get { return suggestion_; }
          set {
            suggestion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 2;
        private global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionType type_ = global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionType.Unspecified;
        /// <summary>
        /// The completion topic.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionType Type {
          get { return type_; }
          set {
            type_ = value;
          }
        }

        /// <summary>Field number for the "image_uri" field.</summary>
        public const int ImageUriFieldNumber = 3;
        private string imageUri_ = "";
        /// <summary>
        /// The URI of the company image for
        /// [COMPANY_NAME][google.cloud.talent.v4.CompleteQueryRequest.CompletionType.COMPANY_NAME].
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string ImageUri {
          get { return imageUri_; }
          set {
            imageUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as CompletionResult);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(CompletionResult other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Suggestion != other.Suggestion) return false;
          if (Type != other.Type) return false;
          if (ImageUri != other.ImageUri) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Suggestion.Length != 0) hash ^= Suggestion.GetHashCode();
          if (Type != global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionType.Unspecified) hash ^= Type.GetHashCode();
          if (ImageUri.Length != 0) hash ^= ImageUri.GetHashCode();
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
          if (Suggestion.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Suggestion);
          }
          if (Type != global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionType.Unspecified) {
            output.WriteRawTag(16);
            output.WriteEnum((int) Type);
          }
          if (ImageUri.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(ImageUri);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Suggestion.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Suggestion);
          }
          if (Type != global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionType.Unspecified) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
          }
          if (ImageUri.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ImageUri);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(CompletionResult other) {
          if (other == null) {
            return;
          }
          if (other.Suggestion.Length != 0) {
            Suggestion = other.Suggestion;
          }
          if (other.Type != global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionType.Unspecified) {
            Type = other.Type;
          }
          if (other.ImageUri.Length != 0) {
            ImageUri = other.ImageUri;
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
                Suggestion = input.ReadString();
                break;
              }
              case 16: {
                Type = (global::Google.Cloud.Talent.V4.CompleteQueryRequest.Types.CompletionType) input.ReadEnum();
                break;
              }
              case 26: {
                ImageUri = input.ReadString();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
