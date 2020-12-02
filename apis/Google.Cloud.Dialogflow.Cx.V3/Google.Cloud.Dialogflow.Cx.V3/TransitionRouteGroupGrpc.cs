// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/cx/v3/transition_route_group.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
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

namespace Google.Cloud.Dialogflow.Cx.V3 {
  /// <summary>
  /// Service for managing [TransitionRouteGroups][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
  /// </summary>
  public static partial class TransitionRouteGroups
  {
    static readonly string __ServiceName = "google.cloud.dialogflow.cx.v3.TransitionRouteGroups";

    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsRequest> __Marshaller_google_cloud_dialogflow_cx_v3_ListTransitionRouteGroupsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsResponse> __Marshaller_google_cloud_dialogflow_cx_v3_ListTransitionRouteGroupsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.GetTransitionRouteGroupRequest> __Marshaller_google_cloud_dialogflow_cx_v3_GetTransitionRouteGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.GetTransitionRouteGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup> __Marshaller_google_cloud_dialogflow_cx_v3_TransitionRouteGroup = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.CreateTransitionRouteGroupRequest> __Marshaller_google_cloud_dialogflow_cx_v3_CreateTransitionRouteGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.CreateTransitionRouteGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.UpdateTransitionRouteGroupRequest> __Marshaller_google_cloud_dialogflow_cx_v3_UpdateTransitionRouteGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.UpdateTransitionRouteGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.DeleteTransitionRouteGroupRequest> __Marshaller_google_cloud_dialogflow_cx_v3_DeleteTransitionRouteGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.DeleteTransitionRouteGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsResponse> __Method_ListTransitionRouteGroups = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListTransitionRouteGroups",
        __Marshaller_google_cloud_dialogflow_cx_v3_ListTransitionRouteGroupsRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_ListTransitionRouteGroupsResponse);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.GetTransitionRouteGroupRequest, global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup> __Method_GetTransitionRouteGroup = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.GetTransitionRouteGroupRequest, global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetTransitionRouteGroup",
        __Marshaller_google_cloud_dialogflow_cx_v3_GetTransitionRouteGroupRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_TransitionRouteGroup);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.CreateTransitionRouteGroupRequest, global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup> __Method_CreateTransitionRouteGroup = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.CreateTransitionRouteGroupRequest, global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateTransitionRouteGroup",
        __Marshaller_google_cloud_dialogflow_cx_v3_CreateTransitionRouteGroupRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_TransitionRouteGroup);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.UpdateTransitionRouteGroupRequest, global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup> __Method_UpdateTransitionRouteGroup = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.UpdateTransitionRouteGroupRequest, global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateTransitionRouteGroup",
        __Marshaller_google_cloud_dialogflow_cx_v3_UpdateTransitionRouteGroupRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_TransitionRouteGroup);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.DeleteTransitionRouteGroupRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteTransitionRouteGroup = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.DeleteTransitionRouteGroupRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteTransitionRouteGroup",
        __Marshaller_google_cloud_dialogflow_cx_v3_DeleteTransitionRouteGroupRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroupReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TransitionRouteGroups</summary>
    [grpc::BindServiceMethod(typeof(TransitionRouteGroups), "BindService")]
    public abstract partial class TransitionRouteGroupsBase
    {
      /// <summary>
      /// Returns the list of all transition route groups in the specified flow.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsResponse> ListTransitionRouteGroups(global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup> GetTransitionRouteGroup(global::Google.Cloud.Dialogflow.Cx.V3.GetTransitionRouteGroupRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates an [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup] in the specified flow.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup> CreateTransitionRouteGroup(global::Google.Cloud.Dialogflow.Cx.V3.CreateTransitionRouteGroupRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup> UpdateTransitionRouteGroup(global::Google.Cloud.Dialogflow.Cx.V3.UpdateTransitionRouteGroupRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteTransitionRouteGroup(global::Google.Cloud.Dialogflow.Cx.V3.DeleteTransitionRouteGroupRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TransitionRouteGroups</summary>
    public partial class TransitionRouteGroupsClient : grpc::ClientBase<TransitionRouteGroupsClient>
    {
      /// <summary>Creates a new client for TransitionRouteGroups</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TransitionRouteGroupsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TransitionRouteGroups that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TransitionRouteGroupsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TransitionRouteGroupsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TransitionRouteGroupsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the list of all transition route groups in the specified flow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsResponse ListTransitionRouteGroups(global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListTransitionRouteGroups(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of all transition route groups in the specified flow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsResponse ListTransitionRouteGroups(global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListTransitionRouteGroups, null, options, request);
      }
      /// <summary>
      /// Returns the list of all transition route groups in the specified flow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsResponse> ListTransitionRouteGroupsAsync(global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListTransitionRouteGroupsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of all transition route groups in the specified flow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsResponse> ListTransitionRouteGroupsAsync(global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListTransitionRouteGroups, null, options, request);
      }
      /// <summary>
      /// Retrieves the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup GetTransitionRouteGroup(global::Google.Cloud.Dialogflow.Cx.V3.GetTransitionRouteGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTransitionRouteGroup(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup GetTransitionRouteGroup(global::Google.Cloud.Dialogflow.Cx.V3.GetTransitionRouteGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetTransitionRouteGroup, null, options, request);
      }
      /// <summary>
      /// Retrieves the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup> GetTransitionRouteGroupAsync(global::Google.Cloud.Dialogflow.Cx.V3.GetTransitionRouteGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTransitionRouteGroupAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup> GetTransitionRouteGroupAsync(global::Google.Cloud.Dialogflow.Cx.V3.GetTransitionRouteGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetTransitionRouteGroup, null, options, request);
      }
      /// <summary>
      /// Creates an [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup] in the specified flow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup CreateTransitionRouteGroup(global::Google.Cloud.Dialogflow.Cx.V3.CreateTransitionRouteGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateTransitionRouteGroup(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates an [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup] in the specified flow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup CreateTransitionRouteGroup(global::Google.Cloud.Dialogflow.Cx.V3.CreateTransitionRouteGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateTransitionRouteGroup, null, options, request);
      }
      /// <summary>
      /// Creates an [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup] in the specified flow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup> CreateTransitionRouteGroupAsync(global::Google.Cloud.Dialogflow.Cx.V3.CreateTransitionRouteGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateTransitionRouteGroupAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates an [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup] in the specified flow.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup> CreateTransitionRouteGroupAsync(global::Google.Cloud.Dialogflow.Cx.V3.CreateTransitionRouteGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateTransitionRouteGroup, null, options, request);
      }
      /// <summary>
      /// Updates the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup UpdateTransitionRouteGroup(global::Google.Cloud.Dialogflow.Cx.V3.UpdateTransitionRouteGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateTransitionRouteGroup(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup UpdateTransitionRouteGroup(global::Google.Cloud.Dialogflow.Cx.V3.UpdateTransitionRouteGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateTransitionRouteGroup, null, options, request);
      }
      /// <summary>
      /// Updates the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup> UpdateTransitionRouteGroupAsync(global::Google.Cloud.Dialogflow.Cx.V3.UpdateTransitionRouteGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateTransitionRouteGroupAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup> UpdateTransitionRouteGroupAsync(global::Google.Cloud.Dialogflow.Cx.V3.UpdateTransitionRouteGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateTransitionRouteGroup, null, options, request);
      }
      /// <summary>
      /// Deletes the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteTransitionRouteGroup(global::Google.Cloud.Dialogflow.Cx.V3.DeleteTransitionRouteGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteTransitionRouteGroup(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteTransitionRouteGroup(global::Google.Cloud.Dialogflow.Cx.V3.DeleteTransitionRouteGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteTransitionRouteGroup, null, options, request);
      }
      /// <summary>
      /// Deletes the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteTransitionRouteGroupAsync(global::Google.Cloud.Dialogflow.Cx.V3.DeleteTransitionRouteGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteTransitionRouteGroupAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteTransitionRouteGroupAsync(global::Google.Cloud.Dialogflow.Cx.V3.DeleteTransitionRouteGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteTransitionRouteGroup, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TransitionRouteGroupsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TransitionRouteGroupsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TransitionRouteGroupsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListTransitionRouteGroups, serviceImpl.ListTransitionRouteGroups)
          .AddMethod(__Method_GetTransitionRouteGroup, serviceImpl.GetTransitionRouteGroup)
          .AddMethod(__Method_CreateTransitionRouteGroup, serviceImpl.CreateTransitionRouteGroup)
          .AddMethod(__Method_UpdateTransitionRouteGroup, serviceImpl.UpdateTransitionRouteGroup)
          .AddMethod(__Method_DeleteTransitionRouteGroup, serviceImpl.DeleteTransitionRouteGroup).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TransitionRouteGroupsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListTransitionRouteGroups, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListTransitionRouteGroupsResponse>(serviceImpl.ListTransitionRouteGroups));
      serviceBinder.AddMethod(__Method_GetTransitionRouteGroup, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.GetTransitionRouteGroupRequest, global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup>(serviceImpl.GetTransitionRouteGroup));
      serviceBinder.AddMethod(__Method_CreateTransitionRouteGroup, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.CreateTransitionRouteGroupRequest, global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup>(serviceImpl.CreateTransitionRouteGroup));
      serviceBinder.AddMethod(__Method_UpdateTransitionRouteGroup, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.UpdateTransitionRouteGroupRequest, global::Google.Cloud.Dialogflow.Cx.V3.TransitionRouteGroup>(serviceImpl.UpdateTransitionRouteGroup));
      serviceBinder.AddMethod(__Method_DeleteTransitionRouteGroup, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.DeleteTransitionRouteGroupRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteTransitionRouteGroup));
    }

  }
}
#endregion
