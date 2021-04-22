// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/assuredworkloads/v1beta1/assuredworkloads_v1beta1.proto
// </auto-generated>
// Original file comments:
// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.AssuredWorkloads.V1Beta1 {
  /// <summary>
  /// Service to manage AssuredWorkloads.
  /// </summary>
  public static partial class AssuredWorkloadsService
  {
    static readonly string __ServiceName = "google.cloud.assuredworkloads.v1beta1.AssuredWorkloadsService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Google.Cloud.AssuredWorkloads.V1Beta1.CreateWorkloadRequest> __Marshaller_google_cloud_assuredworkloads_v1beta1_CreateWorkloadRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AssuredWorkloads.V1Beta1.CreateWorkloadRequest.Parser));
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.AssuredWorkloads.V1Beta1.UpdateWorkloadRequest> __Marshaller_google_cloud_assuredworkloads_v1beta1_UpdateWorkloadRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AssuredWorkloads.V1Beta1.UpdateWorkloadRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload> __Marshaller_google_cloud_assuredworkloads_v1beta1_Workload = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.AssuredWorkloads.V1Beta1.DeleteWorkloadRequest> __Marshaller_google_cloud_assuredworkloads_v1beta1_DeleteWorkloadRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AssuredWorkloads.V1Beta1.DeleteWorkloadRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.AssuredWorkloads.V1Beta1.GetWorkloadRequest> __Marshaller_google_cloud_assuredworkloads_v1beta1_GetWorkloadRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AssuredWorkloads.V1Beta1.GetWorkloadRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsRequest> __Marshaller_google_cloud_assuredworkloads_v1beta1_ListWorkloadsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsResponse> __Marshaller_google_cloud_assuredworkloads_v1beta1_ListWorkloadsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsResponse.Parser));

    static readonly grpc::Method<global::Google.Cloud.AssuredWorkloads.V1Beta1.CreateWorkloadRequest, global::Google.LongRunning.Operation> __Method_CreateWorkload = new grpc::Method<global::Google.Cloud.AssuredWorkloads.V1Beta1.CreateWorkloadRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateWorkload",
        __Marshaller_google_cloud_assuredworkloads_v1beta1_CreateWorkloadRequest,
        __Marshaller_google_longrunning_Operation);

    static readonly grpc::Method<global::Google.Cloud.AssuredWorkloads.V1Beta1.UpdateWorkloadRequest, global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload> __Method_UpdateWorkload = new grpc::Method<global::Google.Cloud.AssuredWorkloads.V1Beta1.UpdateWorkloadRequest, global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateWorkload",
        __Marshaller_google_cloud_assuredworkloads_v1beta1_UpdateWorkloadRequest,
        __Marshaller_google_cloud_assuredworkloads_v1beta1_Workload);

    static readonly grpc::Method<global::Google.Cloud.AssuredWorkloads.V1Beta1.DeleteWorkloadRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteWorkload = new grpc::Method<global::Google.Cloud.AssuredWorkloads.V1Beta1.DeleteWorkloadRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteWorkload",
        __Marshaller_google_cloud_assuredworkloads_v1beta1_DeleteWorkloadRequest,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::Google.Cloud.AssuredWorkloads.V1Beta1.GetWorkloadRequest, global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload> __Method_GetWorkload = new grpc::Method<global::Google.Cloud.AssuredWorkloads.V1Beta1.GetWorkloadRequest, global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetWorkload",
        __Marshaller_google_cloud_assuredworkloads_v1beta1_GetWorkloadRequest,
        __Marshaller_google_cloud_assuredworkloads_v1beta1_Workload);

    static readonly grpc::Method<global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsRequest, global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsResponse> __Method_ListWorkloads = new grpc::Method<global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsRequest, global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListWorkloads",
        __Marshaller_google_cloud_assuredworkloads_v1beta1_ListWorkloadsRequest,
        __Marshaller_google_cloud_assuredworkloads_v1beta1_ListWorkloadsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.AssuredWorkloads.V1Beta1.AssuredworkloadsV1Beta1Reflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AssuredWorkloadsService</summary>
    [grpc::BindServiceMethod(typeof(AssuredWorkloadsService), "BindService")]
    public abstract partial class AssuredWorkloadsServiceBase
    {
      /// <summary>
      /// Creates Assured Workload.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> CreateWorkload(global::Google.Cloud.AssuredWorkloads.V1Beta1.CreateWorkloadRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates an existing workload.
      /// Currently allows updating of workload display_name and labels.
      /// For force updates don't set etag field in the Workload.
      /// Only one update operation per workload can be in progress.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload> UpdateWorkload(global::Google.Cloud.AssuredWorkloads.V1Beta1.UpdateWorkloadRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes the workload. Make sure that workload's direct children are already
      /// in a deleted state, otherwise the request will fail with a
      /// FAILED_PRECONDITION error.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteWorkload(global::Google.Cloud.AssuredWorkloads.V1Beta1.DeleteWorkloadRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets Assured Workload associated with a CRM Node
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload> GetWorkload(global::Google.Cloud.AssuredWorkloads.V1Beta1.GetWorkloadRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Lists Assured Workloads under a CRM Node.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsResponse> ListWorkloads(global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AssuredWorkloadsService</summary>
    public partial class AssuredWorkloadsServiceClient : grpc::ClientBase<AssuredWorkloadsServiceClient>
    {
      /// <summary>Creates a new client for AssuredWorkloadsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AssuredWorkloadsServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AssuredWorkloadsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AssuredWorkloadsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AssuredWorkloadsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AssuredWorkloadsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates Assured Workload.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation CreateWorkload(global::Google.Cloud.AssuredWorkloads.V1Beta1.CreateWorkloadRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateWorkload(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates Assured Workload.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation CreateWorkload(global::Google.Cloud.AssuredWorkloads.V1Beta1.CreateWorkloadRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateWorkload, null, options, request);
      }
      /// <summary>
      /// Creates Assured Workload.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateWorkloadAsync(global::Google.Cloud.AssuredWorkloads.V1Beta1.CreateWorkloadRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateWorkloadAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates Assured Workload.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateWorkloadAsync(global::Google.Cloud.AssuredWorkloads.V1Beta1.CreateWorkloadRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateWorkload, null, options, request);
      }
      /// <summary>
      /// Updates an existing workload.
      /// Currently allows updating of workload display_name and labels.
      /// For force updates don't set etag field in the Workload.
      /// Only one update operation per workload can be in progress.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload UpdateWorkload(global::Google.Cloud.AssuredWorkloads.V1Beta1.UpdateWorkloadRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateWorkload(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates an existing workload.
      /// Currently allows updating of workload display_name and labels.
      /// For force updates don't set etag field in the Workload.
      /// Only one update operation per workload can be in progress.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload UpdateWorkload(global::Google.Cloud.AssuredWorkloads.V1Beta1.UpdateWorkloadRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateWorkload, null, options, request);
      }
      /// <summary>
      /// Updates an existing workload.
      /// Currently allows updating of workload display_name and labels.
      /// For force updates don't set etag field in the Workload.
      /// Only one update operation per workload can be in progress.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload> UpdateWorkloadAsync(global::Google.Cloud.AssuredWorkloads.V1Beta1.UpdateWorkloadRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateWorkloadAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates an existing workload.
      /// Currently allows updating of workload display_name and labels.
      /// For force updates don't set etag field in the Workload.
      /// Only one update operation per workload can be in progress.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload> UpdateWorkloadAsync(global::Google.Cloud.AssuredWorkloads.V1Beta1.UpdateWorkloadRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateWorkload, null, options, request);
      }
      /// <summary>
      /// Deletes the workload. Make sure that workload's direct children are already
      /// in a deleted state, otherwise the request will fail with a
      /// FAILED_PRECONDITION error.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteWorkload(global::Google.Cloud.AssuredWorkloads.V1Beta1.DeleteWorkloadRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteWorkload(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the workload. Make sure that workload's direct children are already
      /// in a deleted state, otherwise the request will fail with a
      /// FAILED_PRECONDITION error.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteWorkload(global::Google.Cloud.AssuredWorkloads.V1Beta1.DeleteWorkloadRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteWorkload, null, options, request);
      }
      /// <summary>
      /// Deletes the workload. Make sure that workload's direct children are already
      /// in a deleted state, otherwise the request will fail with a
      /// FAILED_PRECONDITION error.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteWorkloadAsync(global::Google.Cloud.AssuredWorkloads.V1Beta1.DeleteWorkloadRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteWorkloadAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the workload. Make sure that workload's direct children are already
      /// in a deleted state, otherwise the request will fail with a
      /// FAILED_PRECONDITION error.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteWorkloadAsync(global::Google.Cloud.AssuredWorkloads.V1Beta1.DeleteWorkloadRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteWorkload, null, options, request);
      }
      /// <summary>
      /// Gets Assured Workload associated with a CRM Node
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload GetWorkload(global::Google.Cloud.AssuredWorkloads.V1Beta1.GetWorkloadRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetWorkload(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets Assured Workload associated with a CRM Node
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload GetWorkload(global::Google.Cloud.AssuredWorkloads.V1Beta1.GetWorkloadRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetWorkload, null, options, request);
      }
      /// <summary>
      /// Gets Assured Workload associated with a CRM Node
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload> GetWorkloadAsync(global::Google.Cloud.AssuredWorkloads.V1Beta1.GetWorkloadRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetWorkloadAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets Assured Workload associated with a CRM Node
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload> GetWorkloadAsync(global::Google.Cloud.AssuredWorkloads.V1Beta1.GetWorkloadRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetWorkload, null, options, request);
      }
      /// <summary>
      /// Lists Assured Workloads under a CRM Node.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsResponse ListWorkloads(global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListWorkloads(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists Assured Workloads under a CRM Node.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsResponse ListWorkloads(global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListWorkloads, null, options, request);
      }
      /// <summary>
      /// Lists Assured Workloads under a CRM Node.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsResponse> ListWorkloadsAsync(global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListWorkloadsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists Assured Workloads under a CRM Node.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsResponse> ListWorkloadsAsync(global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListWorkloads, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AssuredWorkloadsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AssuredWorkloadsServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AssuredWorkloadsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateWorkload, serviceImpl.CreateWorkload)
          .AddMethod(__Method_UpdateWorkload, serviceImpl.UpdateWorkload)
          .AddMethod(__Method_DeleteWorkload, serviceImpl.DeleteWorkload)
          .AddMethod(__Method_GetWorkload, serviceImpl.GetWorkload)
          .AddMethod(__Method_ListWorkloads, serviceImpl.ListWorkloads).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AssuredWorkloadsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateWorkload, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AssuredWorkloads.V1Beta1.CreateWorkloadRequest, global::Google.LongRunning.Operation>(serviceImpl.CreateWorkload));
      serviceBinder.AddMethod(__Method_UpdateWorkload, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AssuredWorkloads.V1Beta1.UpdateWorkloadRequest, global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload>(serviceImpl.UpdateWorkload));
      serviceBinder.AddMethod(__Method_DeleteWorkload, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AssuredWorkloads.V1Beta1.DeleteWorkloadRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteWorkload));
      serviceBinder.AddMethod(__Method_GetWorkload, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AssuredWorkloads.V1Beta1.GetWorkloadRequest, global::Google.Cloud.AssuredWorkloads.V1Beta1.Workload>(serviceImpl.GetWorkload));
      serviceBinder.AddMethod(__Method_ListWorkloads, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsRequest, global::Google.Cloud.AssuredWorkloads.V1Beta1.ListWorkloadsResponse>(serviceImpl.ListWorkloads));
    }

  }
}
#endregion
