// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/talent/v4beta1/application.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Talent.V4Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/talent/v4beta1/application.proto</summary>
  public static partial class ApplicationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/talent/v4beta1/application.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ApplicationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvY2xvdWQvdGFsZW50L3Y0YmV0YTEvYXBwbGljYXRpb24ucHJv",
            "dG8SG2dvb2dsZS5jbG91ZC50YWxlbnQudjRiZXRhMRofZ29vZ2xlL2FwaS9m",
            "aWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90",
            "bxooZ29vZ2xlL2Nsb3VkL3RhbGVudC92NGJldGExL2NvbW1vbi5wcm90bxof",
            "Z29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90bxoeZ29vZ2xlL3Byb3Rv",
            "YnVmL3dyYXBwZXJzLnByb3RvGhZnb29nbGUvdHlwZS9kYXRlLnByb3RvGhxn",
            "b29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIpkJCgtBcHBsaWNhdGlvbhIM",
            "CgRuYW1lGAEgASgJEhgKC2V4dGVybmFsX2lkGB8gASgJQgPgQQISFAoHcHJv",
            "ZmlsZRgCIAEoCUID4EEDEikKA2pvYhgEIAEoCUIc+kEZChdqb2JzLmdvb2ds",
            "ZWFwaXMuY29tL0pvYhIxCgdjb21wYW55GAUgASgJQiD6QR0KG2pvYnMuZ29v",
            "Z2xlYXBpcy5jb20vQ29tcGFueRIrChBhcHBsaWNhdGlvbl9kYXRlGAcgASgL",
            "MhEuZ29vZ2xlLnR5cGUuRGF0ZRJNCgVzdGFnZRgLIAEoDjI5Lmdvb2dsZS5j",
            "bG91ZC50YWxlbnQudjRiZXRhMS5BcHBsaWNhdGlvbi5BcHBsaWNhdGlvblN0",
            "YWdlQgPgQQISSAoFc3RhdGUYDSABKA4yOS5nb29nbGUuY2xvdWQudGFsZW50",
            "LnY0YmV0YTEuQXBwbGljYXRpb24uQXBwbGljYXRpb25TdGF0ZRI6CgppbnRl",
            "cnZpZXdzGBAgAygLMiYuZ29vZ2xlLmNsb3VkLnRhbGVudC52NGJldGExLklu",
            "dGVydmlldxIsCghyZWZlcnJhbBgSIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5C",
            "b29sVmFsdWUSNAoLY3JlYXRlX3RpbWUYEyABKAsyGi5nb29nbGUucHJvdG9i",
            "dWYuVGltZXN0YW1wQgPgQQISLwoLdXBkYXRlX3RpbWUYFCABKAsyGi5nb29n",
            "bGUucHJvdG9idWYuVGltZXN0YW1wEhUKDW91dGNvbWVfbm90ZXMYFSABKAkS",
            "NQoHb3V0Y29tZRgWIAEoDjIkLmdvb2dsZS5jbG91ZC50YWxlbnQudjRiZXRh",
            "MS5PdXRjb21lEjEKCGlzX21hdGNoGBwgASgLMhouZ29vZ2xlLnByb3RvYnVm",
            "LkJvb2xWYWx1ZUID4EEDEh4KEWpvYl90aXRsZV9zbmlwcGV0GB0gASgJQgPg",
            "QQMikAEKEEFwcGxpY2F0aW9uU3RhdGUSIQodQVBQTElDQVRJT05fU1RBVEVf",
            "VU5TUEVDSUZJRUQQABIPCgtJTl9QUk9HUkVTUxABEhYKEkNBTkRJREFURV9X",
            "SVRIRFJFVxACEhUKEUVNUExPWUVSX1dJVEhEUkVXEAMSDQoJQ09NUExFVEVE",
            "EAQSCgoGQ0xPU0VEEAUiqQEKEEFwcGxpY2F0aW9uU3RhZ2USIQodQVBQTElD",
            "QVRJT05fU1RBR0VfVU5TUEVDSUZJRUQQABIHCgNORVcQARIKCgZTQ1JFRU4Q",
            "AhIZChVISVJJTkdfTUFOQUdFUl9SRVZJRVcQAxINCglJTlRFUlZJRVcQBBIS",
            "Cg5PRkZFUl9FWFRFTkRFRBAFEhIKDk9GRkVSX0FDQ0VQVEVEEAYSCwoHU1RB",
            "UlRFRBAHOnfqQXQKH2pvYnMuZ29vZ2xlYXBpcy5jb20vQXBwbGljYXRpb24S",
            "UXByb2plY3RzL3twcm9qZWN0fS90ZW5hbnRzL3t0ZW5hbnR9L3Byb2ZpbGVz",
            "L3twcm9maWxlfS9hcHBsaWNhdGlvbnMve2FwcGxpY2F0aW9ufUKGAQofY29t",
            "Lmdvb2dsZS5jbG91ZC50YWxlbnQudjRiZXRhMUIYQXBwbGljYXRpb25SZXNv",
            "dXJjZVByb3RvUAFaQWdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvY2xvdWQvdGFsZW50L3Y0YmV0YTE7dGFsZW50ogIDQ1RTYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.Talent.V4Beta1.CommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Type.DateReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Talent.V4Beta1.Application), global::Google.Cloud.Talent.V4Beta1.Application.Parser, new[]{ "Name", "ExternalId", "Profile", "Job", "Company", "ApplicationDate", "Stage", "State", "Interviews", "Referral", "CreateTime", "UpdateTime", "OutcomeNotes", "Outcome", "IsMatch", "JobTitleSnippet" }, null, new[]{ typeof(global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationState), typeof(global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationStage) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Resource that represents a job application record of a candidate.
  /// </summary>
  public sealed partial class Application : pb::IMessage<Application> {
    private static readonly pb::MessageParser<Application> _parser = new pb::MessageParser<Application>(() => new Application());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Application> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Talent.V4Beta1.ApplicationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Application() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Application(Application other) : this() {
      name_ = other.name_;
      externalId_ = other.externalId_;
      profile_ = other.profile_;
      job_ = other.job_;
      company_ = other.company_;
      applicationDate_ = other.applicationDate_ != null ? other.applicationDate_.Clone() : null;
      stage_ = other.stage_;
      state_ = other.state_;
      interviews_ = other.interviews_.Clone();
      Referral = other.Referral;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      outcomeNotes_ = other.outcomeNotes_;
      outcome_ = other.outcome_;
      IsMatch = other.IsMatch;
      jobTitleSnippet_ = other.jobTitleSnippet_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Application Clone() {
      return new Application(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Required during application update.
    ///
    /// Resource name assigned to an application by the API.
    ///
    /// The format is
    /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}/applications/{application_id}".
    /// For example, "projects/foo/tenants/bar/profiles/baz/applications/qux".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "external_id" field.</summary>
    public const int ExternalIdFieldNumber = 31;
    private string externalId_ = "";
    /// <summary>
    /// Required. Client side application identifier, used to uniquely identify the
    /// application.
    ///
    /// The maximum number of allowed characters is 255.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExternalId {
      get { return externalId_; }
      set {
        externalId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "profile" field.</summary>
    public const int ProfileFieldNumber = 2;
    private string profile_ = "";
    /// <summary>
    /// Output only. Resource name of the candidate of this application.
    ///
    /// The format is
    /// "projects/{project_id}/tenants/{tenant_id}/profiles/{profile_id}".
    /// For example, "projects/foo/tenants/bar/profiles/baz".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Profile {
      get { return profile_; }
      set {
        profile_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "job" field.</summary>
    public const int JobFieldNumber = 4;
    private string job_ = "";
    /// <summary>
    /// One of either a job or a company is required.
    ///
    /// Resource name of the job which the candidate applied for.
    ///
    /// The format is
    /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For example,
    /// "projects/foo/tenants/bar/jobs/baz".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Job {
      get { return job_; }
      set {
        job_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "company" field.</summary>
    public const int CompanyFieldNumber = 5;
    private string company_ = "";
    /// <summary>
    /// One of either a job or a company is required.
    ///
    /// Resource name of the company which the candidate applied for.
    ///
    /// The format is
    /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}".
    /// For example, "projects/foo/tenants/bar/companies/baz".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Company {
      get { return company_; }
      set {
        company_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "application_date" field.</summary>
    public const int ApplicationDateFieldNumber = 7;
    private global::Google.Type.Date applicationDate_;
    /// <summary>
    /// The application date.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Type.Date ApplicationDate {
      get { return applicationDate_; }
      set {
        applicationDate_ = value;
      }
    }

    /// <summary>Field number for the "stage" field.</summary>
    public const int StageFieldNumber = 11;
    private global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationStage stage_ = global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationStage.Unspecified;
    /// <summary>
    /// Required. What is the most recent stage of the application (that is, new, screen,
    /// send cv, hired, finished work)?  This field is intentionally not
    /// comprehensive of every possible status, but instead, represents statuses
    /// that would be used to indicate to the ML models good / bad matches.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationStage Stage {
      get { return stage_; }
      set {
        stage_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 13;
    private global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationState state_ = global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationState.Unspecified;
    /// <summary>
    /// The application state.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "interviews" field.</summary>
    public const int InterviewsFieldNumber = 16;
    private static readonly pb::FieldCodec<global::Google.Cloud.Talent.V4Beta1.Interview> _repeated_interviews_codec
        = pb::FieldCodec.ForMessage(130, global::Google.Cloud.Talent.V4Beta1.Interview.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Talent.V4Beta1.Interview> interviews_ = new pbc::RepeatedField<global::Google.Cloud.Talent.V4Beta1.Interview>();
    /// <summary>
    /// All interviews (screen, onsite, and so on) conducted as part of this
    /// application (includes details such as user conducting the interview,
    /// timestamp, feedback, and so on).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Talent.V4Beta1.Interview> Interviews {
      get { return interviews_; }
    }

    /// <summary>Field number for the "referral" field.</summary>
    public const int ReferralFieldNumber = 18;
    private static readonly pb::FieldCodec<bool?> _single_referral_codec = pb::FieldCodec.ForStructWrapper<bool>(146);
    private bool? referral_;
    /// <summary>
    /// If the candidate is referred by a employee.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? Referral {
      get { return referral_; }
      set {
        referral_ = value;
      }
    }


    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 19;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Required. Reflects the time that the application was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 20;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// The last update timestamp.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "outcome_notes" field.</summary>
    public const int OutcomeNotesFieldNumber = 21;
    private string outcomeNotes_ = "";
    /// <summary>
    /// Free text reason behind the recruitement outcome (for example, reason for
    /// withdraw / reject, reason for an unsuccessful finish, and so on).
    ///
    /// Number of characters allowed is 100.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OutcomeNotes {
      get { return outcomeNotes_; }
      set {
        outcomeNotes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "outcome" field.</summary>
    public const int OutcomeFieldNumber = 22;
    private global::Google.Cloud.Talent.V4Beta1.Outcome outcome_ = global::Google.Cloud.Talent.V4Beta1.Outcome.Unspecified;
    /// <summary>
    /// Outcome positiveness shows how positive the outcome is.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Talent.V4Beta1.Outcome Outcome {
      get { return outcome_; }
      set {
        outcome_ = value;
      }
    }

    /// <summary>Field number for the "is_match" field.</summary>
    public const int IsMatchFieldNumber = 28;
    private static readonly pb::FieldCodec<bool?> _single_isMatch_codec = pb::FieldCodec.ForStructWrapper<bool>(226);
    private bool? isMatch_;
    /// <summary>
    /// Output only. Indicates whether this job application is a match to
    /// application related filters. This value is only applicable in profile
    /// search response.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? IsMatch {
      get { return isMatch_; }
      set {
        isMatch_ = value;
      }
    }


    /// <summary>Field number for the "job_title_snippet" field.</summary>
    public const int JobTitleSnippetFieldNumber = 29;
    private string jobTitleSnippet_ = "";
    /// <summary>
    /// Output only. Job title snippet shows how the job title is related to a
    /// search query. It's empty if the job title isn't related to the search
    /// query.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JobTitleSnippet {
      get { return jobTitleSnippet_; }
      set {
        jobTitleSnippet_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Application);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Application other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (ExternalId != other.ExternalId) return false;
      if (Profile != other.Profile) return false;
      if (Job != other.Job) return false;
      if (Company != other.Company) return false;
      if (!object.Equals(ApplicationDate, other.ApplicationDate)) return false;
      if (Stage != other.Stage) return false;
      if (State != other.State) return false;
      if(!interviews_.Equals(other.interviews_)) return false;
      if (Referral != other.Referral) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (OutcomeNotes != other.OutcomeNotes) return false;
      if (Outcome != other.Outcome) return false;
      if (IsMatch != other.IsMatch) return false;
      if (JobTitleSnippet != other.JobTitleSnippet) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (ExternalId.Length != 0) hash ^= ExternalId.GetHashCode();
      if (Profile.Length != 0) hash ^= Profile.GetHashCode();
      if (Job.Length != 0) hash ^= Job.GetHashCode();
      if (Company.Length != 0) hash ^= Company.GetHashCode();
      if (applicationDate_ != null) hash ^= ApplicationDate.GetHashCode();
      if (Stage != global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationStage.Unspecified) hash ^= Stage.GetHashCode();
      if (State != global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationState.Unspecified) hash ^= State.GetHashCode();
      hash ^= interviews_.GetHashCode();
      if (referral_ != null) hash ^= Referral.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (OutcomeNotes.Length != 0) hash ^= OutcomeNotes.GetHashCode();
      if (Outcome != global::Google.Cloud.Talent.V4Beta1.Outcome.Unspecified) hash ^= Outcome.GetHashCode();
      if (isMatch_ != null) hash ^= IsMatch.GetHashCode();
      if (JobTitleSnippet.Length != 0) hash ^= JobTitleSnippet.GetHashCode();
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
      if (Profile.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Profile);
      }
      if (Job.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Job);
      }
      if (Company.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Company);
      }
      if (applicationDate_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ApplicationDate);
      }
      if (Stage != global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationStage.Unspecified) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Stage);
      }
      if (State != global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationState.Unspecified) {
        output.WriteRawTag(104);
        output.WriteEnum((int) State);
      }
      interviews_.WriteTo(output, _repeated_interviews_codec);
      if (referral_ != null) {
        _single_referral_codec.WriteTagAndValue(output, Referral);
      }
      if (createTime_ != null) {
        output.WriteRawTag(154, 1);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(162, 1);
        output.WriteMessage(UpdateTime);
      }
      if (OutcomeNotes.Length != 0) {
        output.WriteRawTag(170, 1);
        output.WriteString(OutcomeNotes);
      }
      if (Outcome != global::Google.Cloud.Talent.V4Beta1.Outcome.Unspecified) {
        output.WriteRawTag(176, 1);
        output.WriteEnum((int) Outcome);
      }
      if (isMatch_ != null) {
        _single_isMatch_codec.WriteTagAndValue(output, IsMatch);
      }
      if (JobTitleSnippet.Length != 0) {
        output.WriteRawTag(234, 1);
        output.WriteString(JobTitleSnippet);
      }
      if (ExternalId.Length != 0) {
        output.WriteRawTag(250, 1);
        output.WriteString(ExternalId);
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
      if (ExternalId.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ExternalId);
      }
      if (Profile.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Profile);
      }
      if (Job.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Job);
      }
      if (Company.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Company);
      }
      if (applicationDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ApplicationDate);
      }
      if (Stage != global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationStage.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Stage);
      }
      if (State != global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationState.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      size += interviews_.CalculateSize(_repeated_interviews_codec);
      if (referral_ != null) {
        size += _single_referral_codec.CalculateSizeWithTag(Referral);
      }
      if (createTime_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (OutcomeNotes.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(OutcomeNotes);
      }
      if (Outcome != global::Google.Cloud.Talent.V4Beta1.Outcome.Unspecified) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) Outcome);
      }
      if (isMatch_ != null) {
        size += _single_isMatch_codec.CalculateSizeWithTag(IsMatch);
      }
      if (JobTitleSnippet.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(JobTitleSnippet);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Application other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.ExternalId.Length != 0) {
        ExternalId = other.ExternalId;
      }
      if (other.Profile.Length != 0) {
        Profile = other.Profile;
      }
      if (other.Job.Length != 0) {
        Job = other.Job;
      }
      if (other.Company.Length != 0) {
        Company = other.Company;
      }
      if (other.applicationDate_ != null) {
        if (applicationDate_ == null) {
          ApplicationDate = new global::Google.Type.Date();
        }
        ApplicationDate.MergeFrom(other.ApplicationDate);
      }
      if (other.Stage != global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationStage.Unspecified) {
        Stage = other.Stage;
      }
      if (other.State != global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationState.Unspecified) {
        State = other.State;
      }
      interviews_.Add(other.interviews_);
      if (other.referral_ != null) {
        if (referral_ == null || other.Referral != false) {
          Referral = other.Referral;
        }
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      if (other.OutcomeNotes.Length != 0) {
        OutcomeNotes = other.OutcomeNotes;
      }
      if (other.Outcome != global::Google.Cloud.Talent.V4Beta1.Outcome.Unspecified) {
        Outcome = other.Outcome;
      }
      if (other.isMatch_ != null) {
        if (isMatch_ == null || other.IsMatch != false) {
          IsMatch = other.IsMatch;
        }
      }
      if (other.JobTitleSnippet.Length != 0) {
        JobTitleSnippet = other.JobTitleSnippet;
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
            Profile = input.ReadString();
            break;
          }
          case 34: {
            Job = input.ReadString();
            break;
          }
          case 42: {
            Company = input.ReadString();
            break;
          }
          case 58: {
            if (applicationDate_ == null) {
              ApplicationDate = new global::Google.Type.Date();
            }
            input.ReadMessage(ApplicationDate);
            break;
          }
          case 88: {
            Stage = (global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationStage) input.ReadEnum();
            break;
          }
          case 104: {
            State = (global::Google.Cloud.Talent.V4Beta1.Application.Types.ApplicationState) input.ReadEnum();
            break;
          }
          case 130: {
            interviews_.AddEntriesFrom(input, _repeated_interviews_codec);
            break;
          }
          case 146: {
            bool? value = _single_referral_codec.Read(input);
            if (referral_ == null || value != false) {
              Referral = value;
            }
            break;
          }
          case 154: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 162: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 170: {
            OutcomeNotes = input.ReadString();
            break;
          }
          case 176: {
            Outcome = (global::Google.Cloud.Talent.V4Beta1.Outcome) input.ReadEnum();
            break;
          }
          case 226: {
            bool? value = _single_isMatch_codec.Read(input);
            if (isMatch_ == null || value != false) {
              IsMatch = value;
            }
            break;
          }
          case 234: {
            JobTitleSnippet = input.ReadString();
            break;
          }
          case 250: {
            ExternalId = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Application message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum that represents the application status.
      /// </summary>
      public enum ApplicationState {
        /// <summary>
        /// Default value.
        /// </summary>
        [pbr::OriginalName("APPLICATION_STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The current stage is in progress or pending, for example, interviews in
        /// progress.
        /// </summary>
        [pbr::OriginalName("IN_PROGRESS")] InProgress = 1,
        /// <summary>
        /// The current stage was terminated by a candidate decision.
        /// </summary>
        [pbr::OriginalName("CANDIDATE_WITHDREW")] CandidateWithdrew = 2,
        /// <summary>
        /// The current stage was terminated by an employer or agency decision.
        /// </summary>
        [pbr::OriginalName("EMPLOYER_WITHDREW")] EmployerWithdrew = 3,
        /// <summary>
        /// The current stage is successfully completed, but the next stage (if
        /// applicable) has not begun.
        /// </summary>
        [pbr::OriginalName("COMPLETED")] Completed = 4,
        /// <summary>
        /// The current stage was closed without an exception, or terminated for
        /// reasons unrealated to the candidate.
        /// </summary>
        [pbr::OriginalName("CLOSED")] Closed = 5,
      }

      /// <summary>
      /// The stage of the application.
      /// </summary>
      public enum ApplicationStage {
        /// <summary>
        /// Default value.
        /// </summary>
        [pbr::OriginalName("APPLICATION_STAGE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Candidate has applied or a recruiter put candidate into consideration but
        /// candidate is not yet screened / no decision has been made to move or not
        /// move the candidate to the next stage.
        /// </summary>
        [pbr::OriginalName("NEW")] New = 1,
        /// <summary>
        /// A recruiter decided to screen the candidate for this role.
        /// </summary>
        [pbr::OriginalName("SCREEN")] Screen = 2,
        /// <summary>
        /// Candidate is being / was sent to the customer / hiring manager for
        /// detailed review.
        /// </summary>
        [pbr::OriginalName("HIRING_MANAGER_REVIEW")] HiringManagerReview = 3,
        /// <summary>
        /// Candidate was approved by the client / hiring manager and is being / was
        /// interviewed for the role.
        /// </summary>
        [pbr::OriginalName("INTERVIEW")] Interview = 4,
        /// <summary>
        /// Candidate will be / has been given an offer of employment.
        /// </summary>
        [pbr::OriginalName("OFFER_EXTENDED")] OfferExtended = 5,
        /// <summary>
        /// Candidate has accepted their offer of employment.
        /// </summary>
        [pbr::OriginalName("OFFER_ACCEPTED")] OfferAccepted = 6,
        /// <summary>
        /// Candidate has begun (or completed) their employment or assignment with
        /// the employer.
        /// </summary>
        [pbr::OriginalName("STARTED")] Started = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
