// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/cx/v3/intent.proto
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
  /// Service for managing [Intents][google.cloud.dialogflow.cx.v3.Intent].
  /// </summary>
  public static partial class Intents
  {
    static readonly string __ServiceName = "google.cloud.dialogflow.cx.v3.Intents";

    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsRequest> __Marshaller_google_cloud_dialogflow_cx_v3_ListIntentsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsResponse> __Marshaller_google_cloud_dialogflow_cx_v3_ListIntentsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.GetIntentRequest> __Marshaller_google_cloud_dialogflow_cx_v3_GetIntentRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.GetIntentRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.Intent> __Marshaller_google_cloud_dialogflow_cx_v3_Intent = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.Intent.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.CreateIntentRequest> __Marshaller_google_cloud_dialogflow_cx_v3_CreateIntentRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.CreateIntentRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.UpdateIntentRequest> __Marshaller_google_cloud_dialogflow_cx_v3_UpdateIntentRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.UpdateIntentRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Dialogflow.Cx.V3.DeleteIntentRequest> __Marshaller_google_cloud_dialogflow_cx_v3_DeleteIntentRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Dialogflow.Cx.V3.DeleteIntentRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsResponse> __Method_ListIntents = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListIntents",
        __Marshaller_google_cloud_dialogflow_cx_v3_ListIntentsRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_ListIntentsResponse);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.GetIntentRequest, global::Google.Cloud.Dialogflow.Cx.V3.Intent> __Method_GetIntent = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.GetIntentRequest, global::Google.Cloud.Dialogflow.Cx.V3.Intent>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetIntent",
        __Marshaller_google_cloud_dialogflow_cx_v3_GetIntentRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_Intent);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.CreateIntentRequest, global::Google.Cloud.Dialogflow.Cx.V3.Intent> __Method_CreateIntent = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.CreateIntentRequest, global::Google.Cloud.Dialogflow.Cx.V3.Intent>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateIntent",
        __Marshaller_google_cloud_dialogflow_cx_v3_CreateIntentRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_Intent);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.UpdateIntentRequest, global::Google.Cloud.Dialogflow.Cx.V3.Intent> __Method_UpdateIntent = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.UpdateIntentRequest, global::Google.Cloud.Dialogflow.Cx.V3.Intent>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateIntent",
        __Marshaller_google_cloud_dialogflow_cx_v3_UpdateIntentRequest,
        __Marshaller_google_cloud_dialogflow_cx_v3_Intent);

    static readonly grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.DeleteIntentRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteIntent = new grpc::Method<global::Google.Cloud.Dialogflow.Cx.V3.DeleteIntentRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteIntent",
        __Marshaller_google_cloud_dialogflow_cx_v3_DeleteIntentRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Dialogflow.Cx.V3.IntentReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Intents</summary>
    [grpc::BindServiceMethod(typeof(Intents), "BindService")]
    public abstract partial class IntentsBase
    {
      /// <summary>
      /// Returns the list of all intents in the specified agent.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsResponse> ListIntents(global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves the specified intent.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.Intent> GetIntent(global::Google.Cloud.Dialogflow.Cx.V3.GetIntentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates an intent in the specified agent.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.Intent> CreateIntent(global::Google.Cloud.Dialogflow.Cx.V3.CreateIntentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates the specified intent.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Dialogflow.Cx.V3.Intent> UpdateIntent(global::Google.Cloud.Dialogflow.Cx.V3.UpdateIntentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes the specified intent.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteIntent(global::Google.Cloud.Dialogflow.Cx.V3.DeleteIntentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Intents</summary>
    public partial class IntentsClient : grpc::ClientBase<IntentsClient>
    {
      /// <summary>Creates a new client for Intents</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public IntentsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Intents that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public IntentsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected IntentsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected IntentsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the list of all intents in the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsResponse ListIntents(global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListIntents(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of all intents in the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsResponse ListIntents(global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListIntents, null, options, request);
      }
      /// <summary>
      /// Returns the list of all intents in the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsResponse> ListIntentsAsync(global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListIntentsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of all intents in the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsResponse> ListIntentsAsync(global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListIntents, null, options, request);
      }
      /// <summary>
      /// Retrieves the specified intent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Intent GetIntent(global::Google.Cloud.Dialogflow.Cx.V3.GetIntentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetIntent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified intent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Intent GetIntent(global::Google.Cloud.Dialogflow.Cx.V3.GetIntentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetIntent, null, options, request);
      }
      /// <summary>
      /// Retrieves the specified intent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Intent> GetIntentAsync(global::Google.Cloud.Dialogflow.Cx.V3.GetIntentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetIntentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the specified intent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Intent> GetIntentAsync(global::Google.Cloud.Dialogflow.Cx.V3.GetIntentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetIntent, null, options, request);
      }
      /// <summary>
      /// Creates an intent in the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Intent CreateIntent(global::Google.Cloud.Dialogflow.Cx.V3.CreateIntentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateIntent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates an intent in the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Intent CreateIntent(global::Google.Cloud.Dialogflow.Cx.V3.CreateIntentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateIntent, null, options, request);
      }
      /// <summary>
      /// Creates an intent in the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Intent> CreateIntentAsync(global::Google.Cloud.Dialogflow.Cx.V3.CreateIntentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateIntentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates an intent in the specified agent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Intent> CreateIntentAsync(global::Google.Cloud.Dialogflow.Cx.V3.CreateIntentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateIntent, null, options, request);
      }
      /// <summary>
      /// Updates the specified intent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Intent UpdateIntent(global::Google.Cloud.Dialogflow.Cx.V3.UpdateIntentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateIntent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified intent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Dialogflow.Cx.V3.Intent UpdateIntent(global::Google.Cloud.Dialogflow.Cx.V3.UpdateIntentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateIntent, null, options, request);
      }
      /// <summary>
      /// Updates the specified intent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Intent> UpdateIntentAsync(global::Google.Cloud.Dialogflow.Cx.V3.UpdateIntentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateIntentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified intent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Dialogflow.Cx.V3.Intent> UpdateIntentAsync(global::Google.Cloud.Dialogflow.Cx.V3.UpdateIntentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateIntent, null, options, request);
      }
      /// <summary>
      /// Deletes the specified intent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteIntent(global::Google.Cloud.Dialogflow.Cx.V3.DeleteIntentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteIntent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified intent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteIntent(global::Google.Cloud.Dialogflow.Cx.V3.DeleteIntentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteIntent, null, options, request);
      }
      /// <summary>
      /// Deletes the specified intent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteIntentAsync(global::Google.Cloud.Dialogflow.Cx.V3.DeleteIntentRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteIntentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified intent.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteIntentAsync(global::Google.Cloud.Dialogflow.Cx.V3.DeleteIntentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteIntent, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override IntentsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new IntentsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(IntentsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListIntents, serviceImpl.ListIntents)
          .AddMethod(__Method_GetIntent, serviceImpl.GetIntent)
          .AddMethod(__Method_CreateIntent, serviceImpl.CreateIntent)
          .AddMethod(__Method_UpdateIntent, serviceImpl.UpdateIntent)
          .AddMethod(__Method_DeleteIntent, serviceImpl.DeleteIntent).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, IntentsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListIntents, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsRequest, global::Google.Cloud.Dialogflow.Cx.V3.ListIntentsResponse>(serviceImpl.ListIntents));
      serviceBinder.AddMethod(__Method_GetIntent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.GetIntentRequest, global::Google.Cloud.Dialogflow.Cx.V3.Intent>(serviceImpl.GetIntent));
      serviceBinder.AddMethod(__Method_CreateIntent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.CreateIntentRequest, global::Google.Cloud.Dialogflow.Cx.V3.Intent>(serviceImpl.CreateIntent));
      serviceBinder.AddMethod(__Method_UpdateIntent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.UpdateIntentRequest, global::Google.Cloud.Dialogflow.Cx.V3.Intent>(serviceImpl.UpdateIntent));
      serviceBinder.AddMethod(__Method_DeleteIntent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Dialogflow.Cx.V3.DeleteIntentRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteIntent));
    }

  }
}
#endregion
