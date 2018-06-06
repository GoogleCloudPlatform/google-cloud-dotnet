// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/bigtable/v2/bigtable.proto
// </auto-generated>
// Original file comments:
// Copyright 2018 Google Inc.
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

using grpc = global::Grpc.Core;

namespace Google.Cloud.Bigtable.V2 {
  /// <summary>
  /// Service for reading from and writing to existing Bigtable tables.
  /// </summary>
  public static partial class Bigtable
  {
    static readonly string __ServiceName = "google.bigtable.v2.Bigtable";

    static readonly grpc::Marshaller<global::Google.Cloud.Bigtable.V2.ReadRowsRequest> __Marshaller_ReadRowsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Bigtable.V2.ReadRowsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Bigtable.V2.ReadRowsResponse> __Marshaller_ReadRowsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Bigtable.V2.ReadRowsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Bigtable.V2.SampleRowKeysRequest> __Marshaller_SampleRowKeysRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Bigtable.V2.SampleRowKeysRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Bigtable.V2.SampleRowKeysResponse> __Marshaller_SampleRowKeysResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Bigtable.V2.SampleRowKeysResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Bigtable.V2.MutateRowRequest> __Marshaller_MutateRowRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Bigtable.V2.MutateRowRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Bigtable.V2.MutateRowResponse> __Marshaller_MutateRowResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Bigtable.V2.MutateRowResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Bigtable.V2.MutateRowsRequest> __Marshaller_MutateRowsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Bigtable.V2.MutateRowsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Bigtable.V2.MutateRowsResponse> __Marshaller_MutateRowsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Bigtable.V2.MutateRowsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Bigtable.V2.CheckAndMutateRowRequest> __Marshaller_CheckAndMutateRowRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Bigtable.V2.CheckAndMutateRowRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Bigtable.V2.CheckAndMutateRowResponse> __Marshaller_CheckAndMutateRowResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Bigtable.V2.CheckAndMutateRowResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowRequest> __Marshaller_ReadModifyWriteRowRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowResponse> __Marshaller_ReadModifyWriteRowResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Bigtable.V2.ReadRowsRequest, global::Google.Cloud.Bigtable.V2.ReadRowsResponse> __Method_ReadRows = new grpc::Method<global::Google.Cloud.Bigtable.V2.ReadRowsRequest, global::Google.Cloud.Bigtable.V2.ReadRowsResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ReadRows",
        __Marshaller_ReadRowsRequest,
        __Marshaller_ReadRowsResponse);

    static readonly grpc::Method<global::Google.Cloud.Bigtable.V2.SampleRowKeysRequest, global::Google.Cloud.Bigtable.V2.SampleRowKeysResponse> __Method_SampleRowKeys = new grpc::Method<global::Google.Cloud.Bigtable.V2.SampleRowKeysRequest, global::Google.Cloud.Bigtable.V2.SampleRowKeysResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "SampleRowKeys",
        __Marshaller_SampleRowKeysRequest,
        __Marshaller_SampleRowKeysResponse);

    static readonly grpc::Method<global::Google.Cloud.Bigtable.V2.MutateRowRequest, global::Google.Cloud.Bigtable.V2.MutateRowResponse> __Method_MutateRow = new grpc::Method<global::Google.Cloud.Bigtable.V2.MutateRowRequest, global::Google.Cloud.Bigtable.V2.MutateRowResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateRow",
        __Marshaller_MutateRowRequest,
        __Marshaller_MutateRowResponse);

    static readonly grpc::Method<global::Google.Cloud.Bigtable.V2.MutateRowsRequest, global::Google.Cloud.Bigtable.V2.MutateRowsResponse> __Method_MutateRows = new grpc::Method<global::Google.Cloud.Bigtable.V2.MutateRowsRequest, global::Google.Cloud.Bigtable.V2.MutateRowsResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "MutateRows",
        __Marshaller_MutateRowsRequest,
        __Marshaller_MutateRowsResponse);

    static readonly grpc::Method<global::Google.Cloud.Bigtable.V2.CheckAndMutateRowRequest, global::Google.Cloud.Bigtable.V2.CheckAndMutateRowResponse> __Method_CheckAndMutateRow = new grpc::Method<global::Google.Cloud.Bigtable.V2.CheckAndMutateRowRequest, global::Google.Cloud.Bigtable.V2.CheckAndMutateRowResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CheckAndMutateRow",
        __Marshaller_CheckAndMutateRowRequest,
        __Marshaller_CheckAndMutateRowResponse);

    static readonly grpc::Method<global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowRequest, global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowResponse> __Method_ReadModifyWriteRow = new grpc::Method<global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowRequest, global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadModifyWriteRow",
        __Marshaller_ReadModifyWriteRowRequest,
        __Marshaller_ReadModifyWriteRowResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Bigtable.V2.BigtableReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Bigtable</summary>
    public abstract partial class BigtableBase
    {
      /// <summary>
      /// Streams back the contents of all requested rows in key order, optionally
      /// applying the same Reader filter to each. Depending on their size,
      /// rows and cells may be broken up across multiple responses, but
      /// atomicity of each row will still be preserved. See the
      /// ReadRowsResponse documentation for details.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task ReadRows(global::Google.Cloud.Bigtable.V2.ReadRowsRequest request, grpc::IServerStreamWriter<global::Google.Cloud.Bigtable.V2.ReadRowsResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns a sample of row keys in the table. The returned row keys will
      /// delimit contiguous sections of the table of approximately equal size,
      /// which can be used to break up the data for distributed tasks like
      /// mapreduces.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task SampleRowKeys(global::Google.Cloud.Bigtable.V2.SampleRowKeysRequest request, grpc::IServerStreamWriter<global::Google.Cloud.Bigtable.V2.SampleRowKeysResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Mutates a row atomically. Cells already present in the row are left
      /// unchanged unless explicitly changed by `mutation`.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Bigtable.V2.MutateRowResponse> MutateRow(global::Google.Cloud.Bigtable.V2.MutateRowRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Mutates multiple rows in a batch. Each individual row is mutated
      /// atomically as in MutateRow, but the entire batch is not executed
      /// atomically.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task MutateRows(global::Google.Cloud.Bigtable.V2.MutateRowsRequest request, grpc::IServerStreamWriter<global::Google.Cloud.Bigtable.V2.MutateRowsResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Mutates a row atomically based on the output of a predicate Reader filter.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Bigtable.V2.CheckAndMutateRowResponse> CheckAndMutateRow(global::Google.Cloud.Bigtable.V2.CheckAndMutateRowRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Modifies a row atomically on the server. The method reads the latest
      /// existing timestamp and value from the specified columns and writes a new
      /// entry based on pre-defined read/modify/write rules. The new value for the
      /// timestamp is the greater of the existing timestamp or the current server
      /// time. The method returns the new contents of all modified cells.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowResponse> ReadModifyWriteRow(global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Bigtable</summary>
    public partial class BigtableClient : grpc::ClientBase<BigtableClient>
    {
      /// <summary>Creates a new client for Bigtable</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public BigtableClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Bigtable that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public BigtableClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected BigtableClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected BigtableClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Streams back the contents of all requested rows in key order, optionally
      /// applying the same Reader filter to each. Depending on their size,
      /// rows and cells may be broken up across multiple responses, but
      /// atomicity of each row will still be preserved. See the
      /// ReadRowsResponse documentation for details.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Google.Cloud.Bigtable.V2.ReadRowsResponse> ReadRows(global::Google.Cloud.Bigtable.V2.ReadRowsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadRows(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Streams back the contents of all requested rows in key order, optionally
      /// applying the same Reader filter to each. Depending on their size,
      /// rows and cells may be broken up across multiple responses, but
      /// atomicity of each row will still be preserved. See the
      /// ReadRowsResponse documentation for details.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Google.Cloud.Bigtable.V2.ReadRowsResponse> ReadRows(global::Google.Cloud.Bigtable.V2.ReadRowsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ReadRows, null, options, request);
      }
      /// <summary>
      /// Returns a sample of row keys in the table. The returned row keys will
      /// delimit contiguous sections of the table of approximately equal size,
      /// which can be used to break up the data for distributed tasks like
      /// mapreduces.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Google.Cloud.Bigtable.V2.SampleRowKeysResponse> SampleRowKeys(global::Google.Cloud.Bigtable.V2.SampleRowKeysRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SampleRowKeys(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns a sample of row keys in the table. The returned row keys will
      /// delimit contiguous sections of the table of approximately equal size,
      /// which can be used to break up the data for distributed tasks like
      /// mapreduces.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Google.Cloud.Bigtable.V2.SampleRowKeysResponse> SampleRowKeys(global::Google.Cloud.Bigtable.V2.SampleRowKeysRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_SampleRowKeys, null, options, request);
      }
      /// <summary>
      /// Mutates a row atomically. Cells already present in the row are left
      /// unchanged unless explicitly changed by `mutation`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Bigtable.V2.MutateRowResponse MutateRow(global::Google.Cloud.Bigtable.V2.MutateRowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateRow(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Mutates a row atomically. Cells already present in the row are left
      /// unchanged unless explicitly changed by `mutation`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Bigtable.V2.MutateRowResponse MutateRow(global::Google.Cloud.Bigtable.V2.MutateRowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateRow, null, options, request);
      }
      /// <summary>
      /// Mutates a row atomically. Cells already present in the row are left
      /// unchanged unless explicitly changed by `mutation`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Bigtable.V2.MutateRowResponse> MutateRowAsync(global::Google.Cloud.Bigtable.V2.MutateRowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateRowAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Mutates a row atomically. Cells already present in the row are left
      /// unchanged unless explicitly changed by `mutation`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Bigtable.V2.MutateRowResponse> MutateRowAsync(global::Google.Cloud.Bigtable.V2.MutateRowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateRow, null, options, request);
      }
      /// <summary>
      /// Mutates multiple rows in a batch. Each individual row is mutated
      /// atomically as in MutateRow, but the entire batch is not executed
      /// atomically.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Google.Cloud.Bigtable.V2.MutateRowsResponse> MutateRows(global::Google.Cloud.Bigtable.V2.MutateRowsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateRows(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Mutates multiple rows in a batch. Each individual row is mutated
      /// atomically as in MutateRow, but the entire batch is not executed
      /// atomically.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Google.Cloud.Bigtable.V2.MutateRowsResponse> MutateRows(global::Google.Cloud.Bigtable.V2.MutateRowsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_MutateRows, null, options, request);
      }
      /// <summary>
      /// Mutates a row atomically based on the output of a predicate Reader filter.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Bigtable.V2.CheckAndMutateRowResponse CheckAndMutateRow(global::Google.Cloud.Bigtable.V2.CheckAndMutateRowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckAndMutateRow(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Mutates a row atomically based on the output of a predicate Reader filter.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Bigtable.V2.CheckAndMutateRowResponse CheckAndMutateRow(global::Google.Cloud.Bigtable.V2.CheckAndMutateRowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CheckAndMutateRow, null, options, request);
      }
      /// <summary>
      /// Mutates a row atomically based on the output of a predicate Reader filter.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Bigtable.V2.CheckAndMutateRowResponse> CheckAndMutateRowAsync(global::Google.Cloud.Bigtable.V2.CheckAndMutateRowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckAndMutateRowAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Mutates a row atomically based on the output of a predicate Reader filter.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Bigtable.V2.CheckAndMutateRowResponse> CheckAndMutateRowAsync(global::Google.Cloud.Bigtable.V2.CheckAndMutateRowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CheckAndMutateRow, null, options, request);
      }
      /// <summary>
      /// Modifies a row atomically on the server. The method reads the latest
      /// existing timestamp and value from the specified columns and writes a new
      /// entry based on pre-defined read/modify/write rules. The new value for the
      /// timestamp is the greater of the existing timestamp or the current server
      /// time. The method returns the new contents of all modified cells.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowResponse ReadModifyWriteRow(global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadModifyWriteRow(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Modifies a row atomically on the server. The method reads the latest
      /// existing timestamp and value from the specified columns and writes a new
      /// entry based on pre-defined read/modify/write rules. The new value for the
      /// timestamp is the greater of the existing timestamp or the current server
      /// time. The method returns the new contents of all modified cells.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowResponse ReadModifyWriteRow(global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReadModifyWriteRow, null, options, request);
      }
      /// <summary>
      /// Modifies a row atomically on the server. The method reads the latest
      /// existing timestamp and value from the specified columns and writes a new
      /// entry based on pre-defined read/modify/write rules. The new value for the
      /// timestamp is the greater of the existing timestamp or the current server
      /// time. The method returns the new contents of all modified cells.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadModifyWriteRowAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Modifies a row atomically on the server. The method reads the latest
      /// existing timestamp and value from the specified columns and writes a new
      /// entry based on pre-defined read/modify/write rules. The new value for the
      /// timestamp is the greater of the existing timestamp or the current server
      /// time. The method returns the new contents of all modified cells.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(global::Google.Cloud.Bigtable.V2.ReadModifyWriteRowRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReadModifyWriteRow, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override BigtableClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BigtableClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(BigtableBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ReadRows, serviceImpl.ReadRows)
          .AddMethod(__Method_SampleRowKeys, serviceImpl.SampleRowKeys)
          .AddMethod(__Method_MutateRow, serviceImpl.MutateRow)
          .AddMethod(__Method_MutateRows, serviceImpl.MutateRows)
          .AddMethod(__Method_CheckAndMutateRow, serviceImpl.CheckAndMutateRow)
          .AddMethod(__Method_ReadModifyWriteRow, serviceImpl.ReadModifyWriteRow).Build();
    }

  }
}
#endregion
