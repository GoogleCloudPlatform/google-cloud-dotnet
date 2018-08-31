// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/tasks/v2beta3/task.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Tasks.V2Beta3 {

  /// <summary>Holder for reflection information generated from google/cloud/tasks/v2beta3/task.proto</summary>
  public static partial class TaskReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/tasks/v2beta3/task.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TaskReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVnb29nbGUvY2xvdWQvdGFza3MvdjJiZXRhMy90YXNrLnByb3RvEhpnb29n",
            "bGUuY2xvdWQudGFza3MudjJiZXRhMxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9u",
            "cy5wcm90bxonZ29vZ2xlL2Nsb3VkL3Rhc2tzL3YyYmV0YTMvdGFyZ2V0LnBy",
            "b3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvGhdnb29nbGUv",
            "cnBjL3N0YXR1cy5wcm90byLsAwoEVGFzaxIMCgRuYW1lGAEgASgJElMKF2Fw",
            "cF9lbmdpbmVfaHR0cF9yZXF1ZXN0GAMgASgLMjAuZ29vZ2xlLmNsb3VkLnRh",
            "c2tzLnYyYmV0YTMuQXBwRW5naW5lSHR0cFJlcXVlc3RIABIxCg1zY2hlZHVs",
            "ZV90aW1lGAQgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIvCgtj",
            "cmVhdGVfdGltZRgFIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXAS",
            "FgoOZGlzcGF0Y2hfY291bnQYBiABKAUSFgoOcmVzcG9uc2VfY291bnQYByAB",
            "KAUSOgoNZmlyc3RfYXR0ZW1wdBgIIAEoCzIjLmdvb2dsZS5jbG91ZC50YXNr",
            "cy52MmJldGEzLkF0dGVtcHQSOQoMbGFzdF9hdHRlbXB0GAkgASgLMiMuZ29v",
            "Z2xlLmNsb3VkLnRhc2tzLnYyYmV0YTMuQXR0ZW1wdBIzCgR2aWV3GAogASgO",
            "MiUuZ29vZ2xlLmNsb3VkLnRhc2tzLnYyYmV0YTMuVGFzay5WaWV3IjEKBFZp",
            "ZXcSFAoQVklFV19VTlNQRUNJRklFRBAAEgkKBUJBU0lDEAESCAoERlVMTBAC",
            "Qg4KDHBheWxvYWRfdHlwZSLPAQoHQXR0ZW1wdBIxCg1zY2hlZHVsZV90aW1l",
            "GAEgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIxCg1kaXNwYXRj",
            "aF90aW1lGAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIxCg1y",
            "ZXNwb25zZV90aW1lGAMgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFt",
            "cBIrCg9yZXNwb25zZV9zdGF0dXMYBCABKAsyEi5nb29nbGUucnBjLlN0YXR1",
            "c0JuCh5jb20uZ29vZ2xlLmNsb3VkLnRhc2tzLnYyYmV0YTNCCVRhc2tQcm90",
            "b1ABWj9nb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Ns",
            "b3VkL3Rhc2tzL3YyYmV0YTM7dGFza3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Cloud.Tasks.V2Beta3.TargetReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Rpc.StatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Tasks.V2Beta3.Task), global::Google.Cloud.Tasks.V2Beta3.Task.Parser, new[]{ "Name", "AppEngineHttpRequest", "ScheduleTime", "CreateTime", "DispatchCount", "ResponseCount", "FirstAttempt", "LastAttempt", "View" }, new[]{ "PayloadType" }, new[]{ typeof(global::Google.Cloud.Tasks.V2Beta3.Task.Types.View) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Tasks.V2Beta3.Attempt), global::Google.Cloud.Tasks.V2Beta3.Attempt.Parser, new[]{ "ScheduleTime", "DispatchTime", "ResponseTime", "ResponseStatus" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A unit of scheduled work.
  /// </summary>
  public sealed partial class Task : pb::IMessage<Task> {
    private static readonly pb::MessageParser<Task> _parser = new pb::MessageParser<Task>(() => new Task());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Task> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Tasks.V2Beta3.TaskReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Task() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Task(Task other) : this() {
      name_ = other.name_;
      scheduleTime_ = other.scheduleTime_ != null ? other.scheduleTime_.Clone() : null;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      dispatchCount_ = other.dispatchCount_;
      responseCount_ = other.responseCount_;
      firstAttempt_ = other.firstAttempt_ != null ? other.firstAttempt_.Clone() : null;
      lastAttempt_ = other.lastAttempt_ != null ? other.lastAttempt_.Clone() : null;
      view_ = other.view_;
      switch (other.PayloadTypeCase) {
        case PayloadTypeOneofCase.AppEngineHttpRequest:
          AppEngineHttpRequest = other.AppEngineHttpRequest.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Task Clone() {
      return new Task(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Optionally caller-specified in [CreateTask][google.cloud.tasks.v2beta3.CloudTasks.CreateTask].
    ///
    /// The task name.
    ///
    /// The task name must have the following format:
    /// `projects/PROJECT_ID/locations/LOCATION_ID/queues/QUEUE_ID/tasks/TASK_ID`
    ///
    /// * `PROJECT_ID` can contain letters ([A-Za-z]), numbers ([0-9]),
    ///    hyphens (-), colons (:), or periods (.).
    ///    For more information, see
    ///    [Identifying projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#identifying_projects)
    /// * `LOCATION_ID` is the canonical ID for the task's location.
    ///    The list of available locations can be obtained by calling
    ///    [ListLocations][google.cloud.location.Locations.ListLocations].
    ///    For more information, see https://cloud.google.com/about/locations/.
    /// * `QUEUE_ID` can contain letters ([A-Za-z]), numbers ([0-9]), or
    ///   hyphens (-). The maximum length is 100 characters.
    /// * `TASK_ID` can contain only letters ([A-Za-z]), numbers ([0-9]),
    ///   hyphens (-), or underscores (_). The maximum length is 500 characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "app_engine_http_request" field.</summary>
    public const int AppEngineHttpRequestFieldNumber = 3;
    /// <summary>
    /// App Engine HTTP request that is sent to the task's target. Can
    /// be set only if
    /// [app_engine_http_queue][google.cloud.tasks.v2beta3.Queue.app_engine_http_queue] is set
    /// on the queue.
    ///
    /// An App Engine task is a task that has [AppEngineHttpRequest][google.cloud.tasks.v2beta3.AppEngineHttpRequest] set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Tasks.V2Beta3.AppEngineHttpRequest AppEngineHttpRequest {
      get { return payloadTypeCase_ == PayloadTypeOneofCase.AppEngineHttpRequest ? (global::Google.Cloud.Tasks.V2Beta3.AppEngineHttpRequest) payloadType_ : null; }
      set {
        payloadType_ = value;
        payloadTypeCase_ = value == null ? PayloadTypeOneofCase.None : PayloadTypeOneofCase.AppEngineHttpRequest;
      }
    }

    /// <summary>Field number for the "schedule_time" field.</summary>
    public const int ScheduleTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp scheduleTime_;
    /// <summary>
    /// The time when the task is scheduled to be attempted.
    ///
    /// For App Engine queues, this is when the task will be attempted or retried.
    ///
    /// `schedule_time` will be truncated to the nearest microsecond.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ScheduleTime {
      get { return scheduleTime_; }
      set {
        scheduleTime_ = value;
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. The time that the task was created.
    ///
    /// `create_time` will be truncated to the nearest second.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "dispatch_count" field.</summary>
    public const int DispatchCountFieldNumber = 6;
    private int dispatchCount_;
    /// <summary>
    /// Output only. The number of attempts dispatched.
    ///
    /// This count includes tasks which have been dispatched but haven't
    /// received a response.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DispatchCount {
      get { return dispatchCount_; }
      set {
        dispatchCount_ = value;
      }
    }

    /// <summary>Field number for the "response_count" field.</summary>
    public const int ResponseCountFieldNumber = 7;
    private int responseCount_;
    /// <summary>
    /// Output only. The number of attempts which have received a response.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ResponseCount {
      get { return responseCount_; }
      set {
        responseCount_ = value;
      }
    }

    /// <summary>Field number for the "first_attempt" field.</summary>
    public const int FirstAttemptFieldNumber = 8;
    private global::Google.Cloud.Tasks.V2Beta3.Attempt firstAttempt_;
    /// <summary>
    /// Output only. The status of the task's first attempt.
    ///
    /// Only [dispatch_time][google.cloud.tasks.v2beta3.Attempt.dispatch_time] will be set.
    /// The other [Attempt][google.cloud.tasks.v2beta3.Attempt] information is not retained by Cloud Tasks.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Tasks.V2Beta3.Attempt FirstAttempt {
      get { return firstAttempt_; }
      set {
        firstAttempt_ = value;
      }
    }

    /// <summary>Field number for the "last_attempt" field.</summary>
    public const int LastAttemptFieldNumber = 9;
    private global::Google.Cloud.Tasks.V2Beta3.Attempt lastAttempt_;
    /// <summary>
    /// Output only. The status of the task's last attempt.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Tasks.V2Beta3.Attempt LastAttempt {
      get { return lastAttempt_; }
      set {
        lastAttempt_ = value;
      }
    }

    /// <summary>Field number for the "view" field.</summary>
    public const int ViewFieldNumber = 10;
    private global::Google.Cloud.Tasks.V2Beta3.Task.Types.View view_ = 0;
    /// <summary>
    /// Output only. The view specifies which subset of the [Task][google.cloud.tasks.v2beta3.Task] has
    /// been returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Tasks.V2Beta3.Task.Types.View View {
      get { return view_; }
      set {
        view_ = value;
      }
    }

    private object payloadType_;
    /// <summary>Enum of possible cases for the "payload_type" oneof.</summary>
    public enum PayloadTypeOneofCase {
      None = 0,
      AppEngineHttpRequest = 3,
    }
    private PayloadTypeOneofCase payloadTypeCase_ = PayloadTypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PayloadTypeOneofCase PayloadTypeCase {
      get { return payloadTypeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearPayloadType() {
      payloadTypeCase_ = PayloadTypeOneofCase.None;
      payloadType_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Task);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Task other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(AppEngineHttpRequest, other.AppEngineHttpRequest)) return false;
      if (!object.Equals(ScheduleTime, other.ScheduleTime)) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (DispatchCount != other.DispatchCount) return false;
      if (ResponseCount != other.ResponseCount) return false;
      if (!object.Equals(FirstAttempt, other.FirstAttempt)) return false;
      if (!object.Equals(LastAttempt, other.LastAttempt)) return false;
      if (View != other.View) return false;
      if (PayloadTypeCase != other.PayloadTypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (payloadTypeCase_ == PayloadTypeOneofCase.AppEngineHttpRequest) hash ^= AppEngineHttpRequest.GetHashCode();
      if (scheduleTime_ != null) hash ^= ScheduleTime.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (DispatchCount != 0) hash ^= DispatchCount.GetHashCode();
      if (ResponseCount != 0) hash ^= ResponseCount.GetHashCode();
      if (firstAttempt_ != null) hash ^= FirstAttempt.GetHashCode();
      if (lastAttempt_ != null) hash ^= LastAttempt.GetHashCode();
      if (View != 0) hash ^= View.GetHashCode();
      hash ^= (int) payloadTypeCase_;
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
      if (payloadTypeCase_ == PayloadTypeOneofCase.AppEngineHttpRequest) {
        output.WriteRawTag(26);
        output.WriteMessage(AppEngineHttpRequest);
      }
      if (scheduleTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ScheduleTime);
      }
      if (createTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CreateTime);
      }
      if (DispatchCount != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(DispatchCount);
      }
      if (ResponseCount != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(ResponseCount);
      }
      if (firstAttempt_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(FirstAttempt);
      }
      if (lastAttempt_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(LastAttempt);
      }
      if (View != 0) {
        output.WriteRawTag(80);
        output.WriteEnum((int) View);
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
      if (payloadTypeCase_ == PayloadTypeOneofCase.AppEngineHttpRequest) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppEngineHttpRequest);
      }
      if (scheduleTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ScheduleTime);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (DispatchCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DispatchCount);
      }
      if (ResponseCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ResponseCount);
      }
      if (firstAttempt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FirstAttempt);
      }
      if (lastAttempt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastAttempt);
      }
      if (View != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) View);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Task other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.scheduleTime_ != null) {
        if (scheduleTime_ == null) {
          scheduleTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ScheduleTime.MergeFrom(other.ScheduleTime);
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          createTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.DispatchCount != 0) {
        DispatchCount = other.DispatchCount;
      }
      if (other.ResponseCount != 0) {
        ResponseCount = other.ResponseCount;
      }
      if (other.firstAttempt_ != null) {
        if (firstAttempt_ == null) {
          firstAttempt_ = new global::Google.Cloud.Tasks.V2Beta3.Attempt();
        }
        FirstAttempt.MergeFrom(other.FirstAttempt);
      }
      if (other.lastAttempt_ != null) {
        if (lastAttempt_ == null) {
          lastAttempt_ = new global::Google.Cloud.Tasks.V2Beta3.Attempt();
        }
        LastAttempt.MergeFrom(other.LastAttempt);
      }
      if (other.View != 0) {
        View = other.View;
      }
      switch (other.PayloadTypeCase) {
        case PayloadTypeOneofCase.AppEngineHttpRequest:
          if (AppEngineHttpRequest == null) {
            AppEngineHttpRequest = new global::Google.Cloud.Tasks.V2Beta3.AppEngineHttpRequest();
          }
          AppEngineHttpRequest.MergeFrom(other.AppEngineHttpRequest);
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
          case 26: {
            global::Google.Cloud.Tasks.V2Beta3.AppEngineHttpRequest subBuilder = new global::Google.Cloud.Tasks.V2Beta3.AppEngineHttpRequest();
            if (payloadTypeCase_ == PayloadTypeOneofCase.AppEngineHttpRequest) {
              subBuilder.MergeFrom(AppEngineHttpRequest);
            }
            input.ReadMessage(subBuilder);
            AppEngineHttpRequest = subBuilder;
            break;
          }
          case 34: {
            if (scheduleTime_ == null) {
              scheduleTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(scheduleTime_);
            break;
          }
          case 42: {
            if (createTime_ == null) {
              createTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(createTime_);
            break;
          }
          case 48: {
            DispatchCount = input.ReadInt32();
            break;
          }
          case 56: {
            ResponseCount = input.ReadInt32();
            break;
          }
          case 66: {
            if (firstAttempt_ == null) {
              firstAttempt_ = new global::Google.Cloud.Tasks.V2Beta3.Attempt();
            }
            input.ReadMessage(firstAttempt_);
            break;
          }
          case 74: {
            if (lastAttempt_ == null) {
              lastAttempt_ = new global::Google.Cloud.Tasks.V2Beta3.Attempt();
            }
            input.ReadMessage(lastAttempt_);
            break;
          }
          case 80: {
            view_ = (global::Google.Cloud.Tasks.V2Beta3.Task.Types.View) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Task message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The view specifies a subset of [Task][google.cloud.tasks.v2beta3.Task] data.
      ///
      /// When a task is returned in a response, not all
      /// information is retrieved by default because some data, such as
      /// payloads, might be desirable to return only when needed because
      /// of its large size or because of the sensitivity of data that it
      /// contains.
      /// </summary>
      public enum View {
        /// <summary>
        /// Unspecified. Defaults to BASIC.
        /// </summary>
        [pbr::OriginalName("VIEW_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The basic view omits fields which can be large or can contain
        /// sensitive data.
        ///
        /// This view does not include the
        /// [body in AppEngineHttpRequest][google.cloud.tasks.v2beta3.AppEngineHttpRequest.body].
        /// Bodies are desirable to return only when needed, because they
        /// can be large and because of the sensitivity of the data that you
        /// choose to store in it.
        /// </summary>
        [pbr::OriginalName("BASIC")] Basic = 1,
        /// <summary>
        /// All information is returned.
        ///
        /// Authorization for [FULL][google.cloud.tasks.v2beta3.Task.View.FULL] requires
        /// `cloudtasks.tasks.fullView` [Google IAM](https://cloud.google.com/iam/)
        /// permission on the [Queue][google.cloud.tasks.v2beta3.Queue] resource.
        /// </summary>
        [pbr::OriginalName("FULL")] Full = 2,
      }

    }
    #endregion

  }

  /// <summary>
  /// The status of a task attempt.
  /// </summary>
  public sealed partial class Attempt : pb::IMessage<Attempt> {
    private static readonly pb::MessageParser<Attempt> _parser = new pb::MessageParser<Attempt>(() => new Attempt());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Attempt> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Tasks.V2Beta3.TaskReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Attempt() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Attempt(Attempt other) : this() {
      scheduleTime_ = other.scheduleTime_ != null ? other.scheduleTime_.Clone() : null;
      dispatchTime_ = other.dispatchTime_ != null ? other.dispatchTime_.Clone() : null;
      responseTime_ = other.responseTime_ != null ? other.responseTime_.Clone() : null;
      responseStatus_ = other.responseStatus_ != null ? other.responseStatus_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Attempt Clone() {
      return new Attempt(this);
    }

    /// <summary>Field number for the "schedule_time" field.</summary>
    public const int ScheduleTimeFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp scheduleTime_;
    /// <summary>
    /// Output only. The time that this attempt was scheduled.
    ///
    /// `schedule_time` will be truncated to the nearest microsecond.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ScheduleTime {
      get { return scheduleTime_; }
      set {
        scheduleTime_ = value;
      }
    }

    /// <summary>Field number for the "dispatch_time" field.</summary>
    public const int DispatchTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp dispatchTime_;
    /// <summary>
    /// Output only. The time that this attempt was dispatched.
    ///
    /// `dispatch_time` will be truncated to the nearest microsecond.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp DispatchTime {
      get { return dispatchTime_; }
      set {
        dispatchTime_ = value;
      }
    }

    /// <summary>Field number for the "response_time" field.</summary>
    public const int ResponseTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp responseTime_;
    /// <summary>
    /// Output only. The time that this attempt response was received.
    ///
    /// `response_time` will be truncated to the nearest microsecond.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ResponseTime {
      get { return responseTime_; }
      set {
        responseTime_ = value;
      }
    }

    /// <summary>Field number for the "response_status" field.</summary>
    public const int ResponseStatusFieldNumber = 4;
    private global::Google.Rpc.Status responseStatus_;
    /// <summary>
    /// Output only. The response from the target for this attempt.
    ///
    /// If `response_time` is unset, then the task has not been attempted or is
    /// currently running and the `response_status` field is meaningless.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Rpc.Status ResponseStatus {
      get { return responseStatus_; }
      set {
        responseStatus_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Attempt);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Attempt other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ScheduleTime, other.ScheduleTime)) return false;
      if (!object.Equals(DispatchTime, other.DispatchTime)) return false;
      if (!object.Equals(ResponseTime, other.ResponseTime)) return false;
      if (!object.Equals(ResponseStatus, other.ResponseStatus)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (scheduleTime_ != null) hash ^= ScheduleTime.GetHashCode();
      if (dispatchTime_ != null) hash ^= DispatchTime.GetHashCode();
      if (responseTime_ != null) hash ^= ResponseTime.GetHashCode();
      if (responseStatus_ != null) hash ^= ResponseStatus.GetHashCode();
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
      if (scheduleTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ScheduleTime);
      }
      if (dispatchTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DispatchTime);
      }
      if (responseTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ResponseTime);
      }
      if (responseStatus_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ResponseStatus);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (scheduleTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ScheduleTime);
      }
      if (dispatchTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DispatchTime);
      }
      if (responseTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResponseTime);
      }
      if (responseStatus_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResponseStatus);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Attempt other) {
      if (other == null) {
        return;
      }
      if (other.scheduleTime_ != null) {
        if (scheduleTime_ == null) {
          scheduleTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ScheduleTime.MergeFrom(other.ScheduleTime);
      }
      if (other.dispatchTime_ != null) {
        if (dispatchTime_ == null) {
          dispatchTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        DispatchTime.MergeFrom(other.DispatchTime);
      }
      if (other.responseTime_ != null) {
        if (responseTime_ == null) {
          responseTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ResponseTime.MergeFrom(other.ResponseTime);
      }
      if (other.responseStatus_ != null) {
        if (responseStatus_ == null) {
          responseStatus_ = new global::Google.Rpc.Status();
        }
        ResponseStatus.MergeFrom(other.ResponseStatus);
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
            if (scheduleTime_ == null) {
              scheduleTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(scheduleTime_);
            break;
          }
          case 18: {
            if (dispatchTime_ == null) {
              dispatchTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(dispatchTime_);
            break;
          }
          case 26: {
            if (responseTime_ == null) {
              responseTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(responseTime_);
            break;
          }
          case 34: {
            if (responseStatus_ == null) {
              responseStatus_ = new global::Google.Rpc.Status();
            }
            input.ReadMessage(responseStatus_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
