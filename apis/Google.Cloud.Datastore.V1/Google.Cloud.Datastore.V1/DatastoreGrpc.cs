// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/datastore/v1/datastore.proto
// </auto-generated>
// Original file comments:
// Copyright 2017 Google Inc.
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
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Google.Cloud.Datastore.V1 {
  /// <summary>
  /// Each RPC normalizes the partition IDs of the keys in its input entities,
  /// and always returns entities with keys with normalized partition IDs.
  /// This applies to all keys and entities, including those in values, except keys
  /// with both an empty path and an empty or unset partition ID. Normalization of
  /// input keys sets the project ID (if not already set) to the project ID from
  /// the request.
  /// </summary>
  public static partial class Datastore
  {
    static readonly string __ServiceName = "google.datastore.v1.Datastore";

    static readonly grpc::Marshaller<global::Google.Cloud.Datastore.V1.LookupRequest> __Marshaller_LookupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Datastore.V1.LookupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Datastore.V1.LookupResponse> __Marshaller_LookupResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Datastore.V1.LookupResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Datastore.V1.RunQueryRequest> __Marshaller_RunQueryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Datastore.V1.RunQueryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Datastore.V1.RunQueryResponse> __Marshaller_RunQueryResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Datastore.V1.RunQueryResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Datastore.V1.BeginTransactionRequest> __Marshaller_BeginTransactionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Datastore.V1.BeginTransactionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Datastore.V1.BeginTransactionResponse> __Marshaller_BeginTransactionResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Datastore.V1.BeginTransactionResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Datastore.V1.CommitRequest> __Marshaller_CommitRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Datastore.V1.CommitRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Datastore.V1.CommitResponse> __Marshaller_CommitResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Datastore.V1.CommitResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Datastore.V1.RollbackRequest> __Marshaller_RollbackRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Datastore.V1.RollbackRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Datastore.V1.RollbackResponse> __Marshaller_RollbackResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Datastore.V1.RollbackResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Datastore.V1.AllocateIdsRequest> __Marshaller_AllocateIdsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Datastore.V1.AllocateIdsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Datastore.V1.AllocateIdsResponse> __Marshaller_AllocateIdsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Datastore.V1.AllocateIdsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Datastore.V1.ReserveIdsRequest> __Marshaller_ReserveIdsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Datastore.V1.ReserveIdsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Datastore.V1.ReserveIdsResponse> __Marshaller_ReserveIdsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Datastore.V1.ReserveIdsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Datastore.V1.LookupRequest, global::Google.Cloud.Datastore.V1.LookupResponse> __Method_Lookup = new grpc::Method<global::Google.Cloud.Datastore.V1.LookupRequest, global::Google.Cloud.Datastore.V1.LookupResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Lookup",
        __Marshaller_LookupRequest,
        __Marshaller_LookupResponse);

    static readonly grpc::Method<global::Google.Cloud.Datastore.V1.RunQueryRequest, global::Google.Cloud.Datastore.V1.RunQueryResponse> __Method_RunQuery = new grpc::Method<global::Google.Cloud.Datastore.V1.RunQueryRequest, global::Google.Cloud.Datastore.V1.RunQueryResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RunQuery",
        __Marshaller_RunQueryRequest,
        __Marshaller_RunQueryResponse);

    static readonly grpc::Method<global::Google.Cloud.Datastore.V1.BeginTransactionRequest, global::Google.Cloud.Datastore.V1.BeginTransactionResponse> __Method_BeginTransaction = new grpc::Method<global::Google.Cloud.Datastore.V1.BeginTransactionRequest, global::Google.Cloud.Datastore.V1.BeginTransactionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "BeginTransaction",
        __Marshaller_BeginTransactionRequest,
        __Marshaller_BeginTransactionResponse);

    static readonly grpc::Method<global::Google.Cloud.Datastore.V1.CommitRequest, global::Google.Cloud.Datastore.V1.CommitResponse> __Method_Commit = new grpc::Method<global::Google.Cloud.Datastore.V1.CommitRequest, global::Google.Cloud.Datastore.V1.CommitResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Commit",
        __Marshaller_CommitRequest,
        __Marshaller_CommitResponse);

    static readonly grpc::Method<global::Google.Cloud.Datastore.V1.RollbackRequest, global::Google.Cloud.Datastore.V1.RollbackResponse> __Method_Rollback = new grpc::Method<global::Google.Cloud.Datastore.V1.RollbackRequest, global::Google.Cloud.Datastore.V1.RollbackResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Rollback",
        __Marshaller_RollbackRequest,
        __Marshaller_RollbackResponse);

    static readonly grpc::Method<global::Google.Cloud.Datastore.V1.AllocateIdsRequest, global::Google.Cloud.Datastore.V1.AllocateIdsResponse> __Method_AllocateIds = new grpc::Method<global::Google.Cloud.Datastore.V1.AllocateIdsRequest, global::Google.Cloud.Datastore.V1.AllocateIdsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AllocateIds",
        __Marshaller_AllocateIdsRequest,
        __Marshaller_AllocateIdsResponse);

    static readonly grpc::Method<global::Google.Cloud.Datastore.V1.ReserveIdsRequest, global::Google.Cloud.Datastore.V1.ReserveIdsResponse> __Method_ReserveIds = new grpc::Method<global::Google.Cloud.Datastore.V1.ReserveIdsRequest, global::Google.Cloud.Datastore.V1.ReserveIdsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReserveIds",
        __Marshaller_ReserveIdsRequest,
        __Marshaller_ReserveIdsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Datastore.V1.DatastoreReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Datastore</summary>
    public abstract partial class DatastoreBase
    {
      /// <summary>
      /// Looks up entities by key.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Datastore.V1.LookupResponse> Lookup(global::Google.Cloud.Datastore.V1.LookupRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Queries for entities.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Datastore.V1.RunQueryResponse> RunQuery(global::Google.Cloud.Datastore.V1.RunQueryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Begins a new transaction.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Datastore.V1.BeginTransactionResponse> BeginTransaction(global::Google.Cloud.Datastore.V1.BeginTransactionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Commits a transaction, optionally creating, deleting or modifying some
      /// entities.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Datastore.V1.CommitResponse> Commit(global::Google.Cloud.Datastore.V1.CommitRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Rolls back a transaction.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Datastore.V1.RollbackResponse> Rollback(global::Google.Cloud.Datastore.V1.RollbackRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Allocates IDs for the given keys, which is useful for referencing an entity
      /// before it is inserted.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Datastore.V1.AllocateIdsResponse> AllocateIds(global::Google.Cloud.Datastore.V1.AllocateIdsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Prevents the supplied keys' IDs from being auto-allocated by Cloud
      /// Datastore.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Datastore.V1.ReserveIdsResponse> ReserveIds(global::Google.Cloud.Datastore.V1.ReserveIdsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Datastore</summary>
    public partial class DatastoreClient : grpc::ClientBase<DatastoreClient>
    {
      /// <summary>Creates a new client for Datastore</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DatastoreClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Datastore that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DatastoreClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DatastoreClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DatastoreClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Looks up entities by key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Datastore.V1.LookupResponse Lookup(global::Google.Cloud.Datastore.V1.LookupRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Lookup(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Looks up entities by key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Datastore.V1.LookupResponse Lookup(global::Google.Cloud.Datastore.V1.LookupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Lookup, null, options, request);
      }
      /// <summary>
      /// Looks up entities by key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Datastore.V1.LookupResponse> LookupAsync(global::Google.Cloud.Datastore.V1.LookupRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return LookupAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Looks up entities by key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Datastore.V1.LookupResponse> LookupAsync(global::Google.Cloud.Datastore.V1.LookupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Lookup, null, options, request);
      }
      /// <summary>
      /// Queries for entities.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Datastore.V1.RunQueryResponse RunQuery(global::Google.Cloud.Datastore.V1.RunQueryRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RunQuery(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Queries for entities.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Datastore.V1.RunQueryResponse RunQuery(global::Google.Cloud.Datastore.V1.RunQueryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RunQuery, null, options, request);
      }
      /// <summary>
      /// Queries for entities.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Datastore.V1.RunQueryResponse> RunQueryAsync(global::Google.Cloud.Datastore.V1.RunQueryRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RunQueryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Queries for entities.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Datastore.V1.RunQueryResponse> RunQueryAsync(global::Google.Cloud.Datastore.V1.RunQueryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RunQuery, null, options, request);
      }
      /// <summary>
      /// Begins a new transaction.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Datastore.V1.BeginTransactionResponse BeginTransaction(global::Google.Cloud.Datastore.V1.BeginTransactionRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return BeginTransaction(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Begins a new transaction.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Datastore.V1.BeginTransactionResponse BeginTransaction(global::Google.Cloud.Datastore.V1.BeginTransactionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_BeginTransaction, null, options, request);
      }
      /// <summary>
      /// Begins a new transaction.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Datastore.V1.BeginTransactionResponse> BeginTransactionAsync(global::Google.Cloud.Datastore.V1.BeginTransactionRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return BeginTransactionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Begins a new transaction.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Datastore.V1.BeginTransactionResponse> BeginTransactionAsync(global::Google.Cloud.Datastore.V1.BeginTransactionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_BeginTransaction, null, options, request);
      }
      /// <summary>
      /// Commits a transaction, optionally creating, deleting or modifying some
      /// entities.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Datastore.V1.CommitResponse Commit(global::Google.Cloud.Datastore.V1.CommitRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Commit(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Commits a transaction, optionally creating, deleting or modifying some
      /// entities.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Datastore.V1.CommitResponse Commit(global::Google.Cloud.Datastore.V1.CommitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Commit, null, options, request);
      }
      /// <summary>
      /// Commits a transaction, optionally creating, deleting or modifying some
      /// entities.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Datastore.V1.CommitResponse> CommitAsync(global::Google.Cloud.Datastore.V1.CommitRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CommitAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Commits a transaction, optionally creating, deleting or modifying some
      /// entities.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Datastore.V1.CommitResponse> CommitAsync(global::Google.Cloud.Datastore.V1.CommitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Commit, null, options, request);
      }
      /// <summary>
      /// Rolls back a transaction.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Datastore.V1.RollbackResponse Rollback(global::Google.Cloud.Datastore.V1.RollbackRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Rollback(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Rolls back a transaction.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Datastore.V1.RollbackResponse Rollback(global::Google.Cloud.Datastore.V1.RollbackRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Rollback, null, options, request);
      }
      /// <summary>
      /// Rolls back a transaction.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Datastore.V1.RollbackResponse> RollbackAsync(global::Google.Cloud.Datastore.V1.RollbackRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RollbackAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Rolls back a transaction.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Datastore.V1.RollbackResponse> RollbackAsync(global::Google.Cloud.Datastore.V1.RollbackRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Rollback, null, options, request);
      }
      /// <summary>
      /// Allocates IDs for the given keys, which is useful for referencing an entity
      /// before it is inserted.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Datastore.V1.AllocateIdsResponse AllocateIds(global::Google.Cloud.Datastore.V1.AllocateIdsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AllocateIds(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Allocates IDs for the given keys, which is useful for referencing an entity
      /// before it is inserted.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Datastore.V1.AllocateIdsResponse AllocateIds(global::Google.Cloud.Datastore.V1.AllocateIdsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AllocateIds, null, options, request);
      }
      /// <summary>
      /// Allocates IDs for the given keys, which is useful for referencing an entity
      /// before it is inserted.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Datastore.V1.AllocateIdsResponse> AllocateIdsAsync(global::Google.Cloud.Datastore.V1.AllocateIdsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AllocateIdsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Allocates IDs for the given keys, which is useful for referencing an entity
      /// before it is inserted.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Datastore.V1.AllocateIdsResponse> AllocateIdsAsync(global::Google.Cloud.Datastore.V1.AllocateIdsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AllocateIds, null, options, request);
      }
      /// <summary>
      /// Prevents the supplied keys' IDs from being auto-allocated by Cloud
      /// Datastore.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Datastore.V1.ReserveIdsResponse ReserveIds(global::Google.Cloud.Datastore.V1.ReserveIdsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ReserveIds(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Prevents the supplied keys' IDs from being auto-allocated by Cloud
      /// Datastore.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Datastore.V1.ReserveIdsResponse ReserveIds(global::Google.Cloud.Datastore.V1.ReserveIdsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReserveIds, null, options, request);
      }
      /// <summary>
      /// Prevents the supplied keys' IDs from being auto-allocated by Cloud
      /// Datastore.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Datastore.V1.ReserveIdsResponse> ReserveIdsAsync(global::Google.Cloud.Datastore.V1.ReserveIdsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ReserveIdsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Prevents the supplied keys' IDs from being auto-allocated by Cloud
      /// Datastore.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Datastore.V1.ReserveIdsResponse> ReserveIdsAsync(global::Google.Cloud.Datastore.V1.ReserveIdsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReserveIds, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DatastoreClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DatastoreClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DatastoreBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Lookup, serviceImpl.Lookup)
          .AddMethod(__Method_RunQuery, serviceImpl.RunQuery)
          .AddMethod(__Method_BeginTransaction, serviceImpl.BeginTransaction)
          .AddMethod(__Method_Commit, serviceImpl.Commit)
          .AddMethod(__Method_Rollback, serviceImpl.Rollback)
          .AddMethod(__Method_AllocateIds, serviceImpl.AllocateIds)
          .AddMethod(__Method_ReserveIds, serviceImpl.ReserveIds).Build();
    }

  }
}
#endregion
