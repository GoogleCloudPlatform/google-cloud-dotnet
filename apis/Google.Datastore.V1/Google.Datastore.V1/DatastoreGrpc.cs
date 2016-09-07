// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/datastore/v1/datastore.proto
// Original file comments:
// Copyright 2016 Google Inc.
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
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Google.Datastore.V1 {
  /// <summary>
  ///  Each RPC normalizes the partition IDs of the keys in its input entities,
  ///  and always returns entities with keys with normalized partition IDs.
  ///  This applies to all keys and entities, including those in values, except keys
  ///  with both an empty path and an empty or unset partition ID. Normalization of
  ///  input keys sets the project ID (if not already set) to the project ID from
  ///  the request.
  /// </summary>
  public static class Datastore
  {
    static readonly string __ServiceName = "google.datastore.v1.Datastore";

    static readonly Marshaller<global::Google.Datastore.V1.LookupRequest> __Marshaller_LookupRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Datastore.V1.LookupRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Datastore.V1.LookupResponse> __Marshaller_LookupResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Datastore.V1.LookupResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Datastore.V1.RunQueryRequest> __Marshaller_RunQueryRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Datastore.V1.RunQueryRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Datastore.V1.RunQueryResponse> __Marshaller_RunQueryResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Datastore.V1.RunQueryResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Datastore.V1.BeginTransactionRequest> __Marshaller_BeginTransactionRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Datastore.V1.BeginTransactionRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Datastore.V1.BeginTransactionResponse> __Marshaller_BeginTransactionResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Datastore.V1.BeginTransactionResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Datastore.V1.CommitRequest> __Marshaller_CommitRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Datastore.V1.CommitRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Datastore.V1.CommitResponse> __Marshaller_CommitResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Datastore.V1.CommitResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Datastore.V1.RollbackRequest> __Marshaller_RollbackRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Datastore.V1.RollbackRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Datastore.V1.RollbackResponse> __Marshaller_RollbackResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Datastore.V1.RollbackResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Datastore.V1.AllocateIdsRequest> __Marshaller_AllocateIdsRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Datastore.V1.AllocateIdsRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Datastore.V1.AllocateIdsResponse> __Marshaller_AllocateIdsResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Datastore.V1.AllocateIdsResponse.Parser.ParseFrom);

    static readonly Method<global::Google.Datastore.V1.LookupRequest, global::Google.Datastore.V1.LookupResponse> __Method_Lookup = new Method<global::Google.Datastore.V1.LookupRequest, global::Google.Datastore.V1.LookupResponse>(
        MethodType.Unary,
        __ServiceName,
        "Lookup",
        __Marshaller_LookupRequest,
        __Marshaller_LookupResponse);

    static readonly Method<global::Google.Datastore.V1.RunQueryRequest, global::Google.Datastore.V1.RunQueryResponse> __Method_RunQuery = new Method<global::Google.Datastore.V1.RunQueryRequest, global::Google.Datastore.V1.RunQueryResponse>(
        MethodType.Unary,
        __ServiceName,
        "RunQuery",
        __Marshaller_RunQueryRequest,
        __Marshaller_RunQueryResponse);

    static readonly Method<global::Google.Datastore.V1.BeginTransactionRequest, global::Google.Datastore.V1.BeginTransactionResponse> __Method_BeginTransaction = new Method<global::Google.Datastore.V1.BeginTransactionRequest, global::Google.Datastore.V1.BeginTransactionResponse>(
        MethodType.Unary,
        __ServiceName,
        "BeginTransaction",
        __Marshaller_BeginTransactionRequest,
        __Marshaller_BeginTransactionResponse);

    static readonly Method<global::Google.Datastore.V1.CommitRequest, global::Google.Datastore.V1.CommitResponse> __Method_Commit = new Method<global::Google.Datastore.V1.CommitRequest, global::Google.Datastore.V1.CommitResponse>(
        MethodType.Unary,
        __ServiceName,
        "Commit",
        __Marshaller_CommitRequest,
        __Marshaller_CommitResponse);

    static readonly Method<global::Google.Datastore.V1.RollbackRequest, global::Google.Datastore.V1.RollbackResponse> __Method_Rollback = new Method<global::Google.Datastore.V1.RollbackRequest, global::Google.Datastore.V1.RollbackResponse>(
        MethodType.Unary,
        __ServiceName,
        "Rollback",
        __Marshaller_RollbackRequest,
        __Marshaller_RollbackResponse);

    static readonly Method<global::Google.Datastore.V1.AllocateIdsRequest, global::Google.Datastore.V1.AllocateIdsResponse> __Method_AllocateIds = new Method<global::Google.Datastore.V1.AllocateIdsRequest, global::Google.Datastore.V1.AllocateIdsResponse>(
        MethodType.Unary,
        __ServiceName,
        "AllocateIds",
        __Marshaller_AllocateIdsRequest,
        __Marshaller_AllocateIdsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Datastore.V1.DatastoreReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Datastore</summary>
    public abstract class DatastoreBase
    {
      /// <summary>
      ///  Looks up entities by key.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Datastore.V1.LookupResponse> Lookup(global::Google.Datastore.V1.LookupRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Queries for entities.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Datastore.V1.RunQueryResponse> RunQuery(global::Google.Datastore.V1.RunQueryRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Begins a new transaction.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Datastore.V1.BeginTransactionResponse> BeginTransaction(global::Google.Datastore.V1.BeginTransactionRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Commits a transaction, optionally creating, deleting or modifying some
      ///  entities.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Datastore.V1.CommitResponse> Commit(global::Google.Datastore.V1.CommitRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Rolls back a transaction.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Datastore.V1.RollbackResponse> Rollback(global::Google.Datastore.V1.RollbackRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Allocates IDs for the given keys, which is useful for referencing an entity
      ///  before it is inserted.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Datastore.V1.AllocateIdsResponse> AllocateIds(global::Google.Datastore.V1.AllocateIdsRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Datastore</summary>
    public class DatastoreClient : ClientBase<DatastoreClient>
    {
      /// <summary>Creates a new client for Datastore</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DatastoreClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Datastore that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DatastoreClient(CallInvoker callInvoker) : base(callInvoker)
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
      ///  Looks up entities by key.
      /// </summary>
      public virtual global::Google.Datastore.V1.LookupResponse Lookup(global::Google.Datastore.V1.LookupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Lookup(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Looks up entities by key.
      /// </summary>
      public virtual global::Google.Datastore.V1.LookupResponse Lookup(global::Google.Datastore.V1.LookupRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Lookup, null, options, request);
      }
      /// <summary>
      ///  Looks up entities by key.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Datastore.V1.LookupResponse> LookupAsync(global::Google.Datastore.V1.LookupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return LookupAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Looks up entities by key.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Datastore.V1.LookupResponse> LookupAsync(global::Google.Datastore.V1.LookupRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Lookup, null, options, request);
      }
      /// <summary>
      ///  Queries for entities.
      /// </summary>
      public virtual global::Google.Datastore.V1.RunQueryResponse RunQuery(global::Google.Datastore.V1.RunQueryRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RunQuery(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Queries for entities.
      /// </summary>
      public virtual global::Google.Datastore.V1.RunQueryResponse RunQuery(global::Google.Datastore.V1.RunQueryRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RunQuery, null, options, request);
      }
      /// <summary>
      ///  Queries for entities.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Datastore.V1.RunQueryResponse> RunQueryAsync(global::Google.Datastore.V1.RunQueryRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RunQueryAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Queries for entities.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Datastore.V1.RunQueryResponse> RunQueryAsync(global::Google.Datastore.V1.RunQueryRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RunQuery, null, options, request);
      }
      /// <summary>
      ///  Begins a new transaction.
      /// </summary>
      public virtual global::Google.Datastore.V1.BeginTransactionResponse BeginTransaction(global::Google.Datastore.V1.BeginTransactionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return BeginTransaction(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Begins a new transaction.
      /// </summary>
      public virtual global::Google.Datastore.V1.BeginTransactionResponse BeginTransaction(global::Google.Datastore.V1.BeginTransactionRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_BeginTransaction, null, options, request);
      }
      /// <summary>
      ///  Begins a new transaction.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Datastore.V1.BeginTransactionResponse> BeginTransactionAsync(global::Google.Datastore.V1.BeginTransactionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return BeginTransactionAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Begins a new transaction.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Datastore.V1.BeginTransactionResponse> BeginTransactionAsync(global::Google.Datastore.V1.BeginTransactionRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_BeginTransaction, null, options, request);
      }
      /// <summary>
      ///  Commits a transaction, optionally creating, deleting or modifying some
      ///  entities.
      /// </summary>
      public virtual global::Google.Datastore.V1.CommitResponse Commit(global::Google.Datastore.V1.CommitRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Commit(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Commits a transaction, optionally creating, deleting or modifying some
      ///  entities.
      /// </summary>
      public virtual global::Google.Datastore.V1.CommitResponse Commit(global::Google.Datastore.V1.CommitRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Commit, null, options, request);
      }
      /// <summary>
      ///  Commits a transaction, optionally creating, deleting or modifying some
      ///  entities.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Datastore.V1.CommitResponse> CommitAsync(global::Google.Datastore.V1.CommitRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CommitAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Commits a transaction, optionally creating, deleting or modifying some
      ///  entities.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Datastore.V1.CommitResponse> CommitAsync(global::Google.Datastore.V1.CommitRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Commit, null, options, request);
      }
      /// <summary>
      ///  Rolls back a transaction.
      /// </summary>
      public virtual global::Google.Datastore.V1.RollbackResponse Rollback(global::Google.Datastore.V1.RollbackRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Rollback(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Rolls back a transaction.
      /// </summary>
      public virtual global::Google.Datastore.V1.RollbackResponse Rollback(global::Google.Datastore.V1.RollbackRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Rollback, null, options, request);
      }
      /// <summary>
      ///  Rolls back a transaction.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Datastore.V1.RollbackResponse> RollbackAsync(global::Google.Datastore.V1.RollbackRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RollbackAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Rolls back a transaction.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Datastore.V1.RollbackResponse> RollbackAsync(global::Google.Datastore.V1.RollbackRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Rollback, null, options, request);
      }
      /// <summary>
      ///  Allocates IDs for the given keys, which is useful for referencing an entity
      ///  before it is inserted.
      /// </summary>
      public virtual global::Google.Datastore.V1.AllocateIdsResponse AllocateIds(global::Google.Datastore.V1.AllocateIdsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AllocateIds(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Allocates IDs for the given keys, which is useful for referencing an entity
      ///  before it is inserted.
      /// </summary>
      public virtual global::Google.Datastore.V1.AllocateIdsResponse AllocateIds(global::Google.Datastore.V1.AllocateIdsRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AllocateIds, null, options, request);
      }
      /// <summary>
      ///  Allocates IDs for the given keys, which is useful for referencing an entity
      ///  before it is inserted.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Datastore.V1.AllocateIdsResponse> AllocateIdsAsync(global::Google.Datastore.V1.AllocateIdsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AllocateIdsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Allocates IDs for the given keys, which is useful for referencing an entity
      ///  before it is inserted.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Datastore.V1.AllocateIdsResponse> AllocateIdsAsync(global::Google.Datastore.V1.AllocateIdsRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AllocateIds, null, options, request);
      }
      protected override DatastoreClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DatastoreClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(DatastoreBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Lookup, serviceImpl.Lookup)
          .AddMethod(__Method_RunQuery, serviceImpl.RunQuery)
          .AddMethod(__Method_BeginTransaction, serviceImpl.BeginTransaction)
          .AddMethod(__Method_Commit, serviceImpl.Commit)
          .AddMethod(__Method_Rollback, serviceImpl.Rollback)
          .AddMethod(__Method_AllocateIds, serviceImpl.AllocateIds).Build();
    }

  }
}
#endregion
