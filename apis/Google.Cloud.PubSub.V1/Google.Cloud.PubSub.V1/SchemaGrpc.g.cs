// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/pubsub/v1/schema.proto
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

namespace Google.Cloud.PubSub.V1 {
  /// <summary>
  /// Service for doing schema-related operations.
  /// </summary>
  public static partial class SchemaService
  {
    static readonly string __ServiceName = "google.pubsub.v1.SchemaService";

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

    static readonly grpc::Marshaller<global::Google.Cloud.PubSub.V1.CreateSchemaRequest> __Marshaller_google_pubsub_v1_CreateSchemaRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PubSub.V1.CreateSchemaRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.PubSub.V1.Schema> __Marshaller_google_pubsub_v1_Schema = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PubSub.V1.Schema.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.PubSub.V1.GetSchemaRequest> __Marshaller_google_pubsub_v1_GetSchemaRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PubSub.V1.GetSchemaRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.PubSub.V1.ListSchemasRequest> __Marshaller_google_pubsub_v1_ListSchemasRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PubSub.V1.ListSchemasRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.PubSub.V1.ListSchemasResponse> __Marshaller_google_pubsub_v1_ListSchemasResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PubSub.V1.ListSchemasResponse.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.PubSub.V1.DeleteSchemaRequest> __Marshaller_google_pubsub_v1_DeleteSchemaRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PubSub.V1.DeleteSchemaRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.PubSub.V1.ValidateSchemaRequest> __Marshaller_google_pubsub_v1_ValidateSchemaRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PubSub.V1.ValidateSchemaRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.PubSub.V1.ValidateSchemaResponse> __Marshaller_google_pubsub_v1_ValidateSchemaResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PubSub.V1.ValidateSchemaResponse.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.PubSub.V1.ValidateMessageRequest> __Marshaller_google_pubsub_v1_ValidateMessageRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PubSub.V1.ValidateMessageRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.PubSub.V1.ValidateMessageResponse> __Marshaller_google_pubsub_v1_ValidateMessageResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PubSub.V1.ValidateMessageResponse.Parser));

    static readonly grpc::Method<global::Google.Cloud.PubSub.V1.CreateSchemaRequest, global::Google.Cloud.PubSub.V1.Schema> __Method_CreateSchema = new grpc::Method<global::Google.Cloud.PubSub.V1.CreateSchemaRequest, global::Google.Cloud.PubSub.V1.Schema>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateSchema",
        __Marshaller_google_pubsub_v1_CreateSchemaRequest,
        __Marshaller_google_pubsub_v1_Schema);

    static readonly grpc::Method<global::Google.Cloud.PubSub.V1.GetSchemaRequest, global::Google.Cloud.PubSub.V1.Schema> __Method_GetSchema = new grpc::Method<global::Google.Cloud.PubSub.V1.GetSchemaRequest, global::Google.Cloud.PubSub.V1.Schema>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSchema",
        __Marshaller_google_pubsub_v1_GetSchemaRequest,
        __Marshaller_google_pubsub_v1_Schema);

    static readonly grpc::Method<global::Google.Cloud.PubSub.V1.ListSchemasRequest, global::Google.Cloud.PubSub.V1.ListSchemasResponse> __Method_ListSchemas = new grpc::Method<global::Google.Cloud.PubSub.V1.ListSchemasRequest, global::Google.Cloud.PubSub.V1.ListSchemasResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListSchemas",
        __Marshaller_google_pubsub_v1_ListSchemasRequest,
        __Marshaller_google_pubsub_v1_ListSchemasResponse);

    static readonly grpc::Method<global::Google.Cloud.PubSub.V1.DeleteSchemaRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteSchema = new grpc::Method<global::Google.Cloud.PubSub.V1.DeleteSchemaRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteSchema",
        __Marshaller_google_pubsub_v1_DeleteSchemaRequest,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::Google.Cloud.PubSub.V1.ValidateSchemaRequest, global::Google.Cloud.PubSub.V1.ValidateSchemaResponse> __Method_ValidateSchema = new grpc::Method<global::Google.Cloud.PubSub.V1.ValidateSchemaRequest, global::Google.Cloud.PubSub.V1.ValidateSchemaResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ValidateSchema",
        __Marshaller_google_pubsub_v1_ValidateSchemaRequest,
        __Marshaller_google_pubsub_v1_ValidateSchemaResponse);

    static readonly grpc::Method<global::Google.Cloud.PubSub.V1.ValidateMessageRequest, global::Google.Cloud.PubSub.V1.ValidateMessageResponse> __Method_ValidateMessage = new grpc::Method<global::Google.Cloud.PubSub.V1.ValidateMessageRequest, global::Google.Cloud.PubSub.V1.ValidateMessageResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ValidateMessage",
        __Marshaller_google_pubsub_v1_ValidateMessageRequest,
        __Marshaller_google_pubsub_v1_ValidateMessageResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.PubSub.V1.SchemaReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SchemaService</summary>
    [grpc::BindServiceMethod(typeof(SchemaService), "BindService")]
    public abstract partial class SchemaServiceBase
    {
      /// <summary>
      /// Creates a schema.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.PubSub.V1.Schema> CreateSchema(global::Google.Cloud.PubSub.V1.CreateSchemaRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets a schema.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.PubSub.V1.Schema> GetSchema(global::Google.Cloud.PubSub.V1.GetSchemaRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Lists schemas in a project.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.PubSub.V1.ListSchemasResponse> ListSchemas(global::Google.Cloud.PubSub.V1.ListSchemasRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes a schema.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteSchema(global::Google.Cloud.PubSub.V1.DeleteSchemaRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Validates a schema.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.PubSub.V1.ValidateSchemaResponse> ValidateSchema(global::Google.Cloud.PubSub.V1.ValidateSchemaRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Validates a message against a schema.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.PubSub.V1.ValidateMessageResponse> ValidateMessage(global::Google.Cloud.PubSub.V1.ValidateMessageRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SchemaService</summary>
    public partial class SchemaServiceClient : grpc::ClientBase<SchemaServiceClient>
    {
      /// <summary>Creates a new client for SchemaService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SchemaServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SchemaService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SchemaServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SchemaServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SchemaServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.PubSub.V1.Schema CreateSchema(global::Google.Cloud.PubSub.V1.CreateSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateSchema(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.PubSub.V1.Schema CreateSchema(global::Google.Cloud.PubSub.V1.CreateSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateSchema, null, options, request);
      }
      /// <summary>
      /// Creates a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PubSub.V1.Schema> CreateSchemaAsync(global::Google.Cloud.PubSub.V1.CreateSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateSchemaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PubSub.V1.Schema> CreateSchemaAsync(global::Google.Cloud.PubSub.V1.CreateSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateSchema, null, options, request);
      }
      /// <summary>
      /// Gets a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.PubSub.V1.Schema GetSchema(global::Google.Cloud.PubSub.V1.GetSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSchema(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.PubSub.V1.Schema GetSchema(global::Google.Cloud.PubSub.V1.GetSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSchema, null, options, request);
      }
      /// <summary>
      /// Gets a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PubSub.V1.Schema> GetSchemaAsync(global::Google.Cloud.PubSub.V1.GetSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSchemaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PubSub.V1.Schema> GetSchemaAsync(global::Google.Cloud.PubSub.V1.GetSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSchema, null, options, request);
      }
      /// <summary>
      /// Lists schemas in a project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.PubSub.V1.ListSchemasResponse ListSchemas(global::Google.Cloud.PubSub.V1.ListSchemasRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListSchemas(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists schemas in a project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.PubSub.V1.ListSchemasResponse ListSchemas(global::Google.Cloud.PubSub.V1.ListSchemasRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListSchemas, null, options, request);
      }
      /// <summary>
      /// Lists schemas in a project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PubSub.V1.ListSchemasResponse> ListSchemasAsync(global::Google.Cloud.PubSub.V1.ListSchemasRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListSchemasAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists schemas in a project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PubSub.V1.ListSchemasResponse> ListSchemasAsync(global::Google.Cloud.PubSub.V1.ListSchemasRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListSchemas, null, options, request);
      }
      /// <summary>
      /// Deletes a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteSchema(global::Google.Cloud.PubSub.V1.DeleteSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteSchema(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteSchema(global::Google.Cloud.PubSub.V1.DeleteSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteSchema, null, options, request);
      }
      /// <summary>
      /// Deletes a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteSchemaAsync(global::Google.Cloud.PubSub.V1.DeleteSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteSchemaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteSchemaAsync(global::Google.Cloud.PubSub.V1.DeleteSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteSchema, null, options, request);
      }
      /// <summary>
      /// Validates a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.PubSub.V1.ValidateSchemaResponse ValidateSchema(global::Google.Cloud.PubSub.V1.ValidateSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ValidateSchema(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Validates a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.PubSub.V1.ValidateSchemaResponse ValidateSchema(global::Google.Cloud.PubSub.V1.ValidateSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ValidateSchema, null, options, request);
      }
      /// <summary>
      /// Validates a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PubSub.V1.ValidateSchemaResponse> ValidateSchemaAsync(global::Google.Cloud.PubSub.V1.ValidateSchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ValidateSchemaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Validates a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PubSub.V1.ValidateSchemaResponse> ValidateSchemaAsync(global::Google.Cloud.PubSub.V1.ValidateSchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ValidateSchema, null, options, request);
      }
      /// <summary>
      /// Validates a message against a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.PubSub.V1.ValidateMessageResponse ValidateMessage(global::Google.Cloud.PubSub.V1.ValidateMessageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ValidateMessage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Validates a message against a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.PubSub.V1.ValidateMessageResponse ValidateMessage(global::Google.Cloud.PubSub.V1.ValidateMessageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ValidateMessage, null, options, request);
      }
      /// <summary>
      /// Validates a message against a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PubSub.V1.ValidateMessageResponse> ValidateMessageAsync(global::Google.Cloud.PubSub.V1.ValidateMessageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ValidateMessageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Validates a message against a schema.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.PubSub.V1.ValidateMessageResponse> ValidateMessageAsync(global::Google.Cloud.PubSub.V1.ValidateMessageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ValidateMessage, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SchemaServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SchemaServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SchemaServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateSchema, serviceImpl.CreateSchema)
          .AddMethod(__Method_GetSchema, serviceImpl.GetSchema)
          .AddMethod(__Method_ListSchemas, serviceImpl.ListSchemas)
          .AddMethod(__Method_DeleteSchema, serviceImpl.DeleteSchema)
          .AddMethod(__Method_ValidateSchema, serviceImpl.ValidateSchema)
          .AddMethod(__Method_ValidateMessage, serviceImpl.ValidateMessage).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SchemaServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateSchema, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.PubSub.V1.CreateSchemaRequest, global::Google.Cloud.PubSub.V1.Schema>(serviceImpl.CreateSchema));
      serviceBinder.AddMethod(__Method_GetSchema, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.PubSub.V1.GetSchemaRequest, global::Google.Cloud.PubSub.V1.Schema>(serviceImpl.GetSchema));
      serviceBinder.AddMethod(__Method_ListSchemas, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.PubSub.V1.ListSchemasRequest, global::Google.Cloud.PubSub.V1.ListSchemasResponse>(serviceImpl.ListSchemas));
      serviceBinder.AddMethod(__Method_DeleteSchema, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.PubSub.V1.DeleteSchemaRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteSchema));
      serviceBinder.AddMethod(__Method_ValidateSchema, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.PubSub.V1.ValidateSchemaRequest, global::Google.Cloud.PubSub.V1.ValidateSchemaResponse>(serviceImpl.ValidateSchema));
      serviceBinder.AddMethod(__Method_ValidateMessage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.PubSub.V1.ValidateMessageRequest, global::Google.Cloud.PubSub.V1.ValidateMessageResponse>(serviceImpl.ValidateMessage));
    }

  }
}
#endregion
