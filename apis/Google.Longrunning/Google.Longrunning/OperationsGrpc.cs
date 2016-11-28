// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/longrunning/operations.proto
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

namespace Google.LongRunning {
  /// <summary>
  ///  Manages long-running operations with an API service.
  ///
  ///  When an API method normally takes long time to complete, it can be designed
  ///  to return [Operation][google.longrunning.Operation] to the client, and the client can use this
  ///  interface to receive the real response asynchronously by polling the
  ///  operation resource, or pass the operation resource to another API (such as
  ///  Google Cloud Pub/Sub API) to receive the response.  Any API service that
  ///  returns long-running operations should implement the `Operations` interface
  ///  so developers can have a consistent client experience.
  /// </summary>
  public static class Operations
  {
    static readonly string __ServiceName = "google.longrunning.Operations";

    static readonly Marshaller<global::Google.LongRunning.GetOperationRequest> __Marshaller_GetOperationRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.LongRunning.GetOperationRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.LongRunning.Operation> __Marshaller_Operation = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.LongRunning.Operation.Parser.ParseFrom);
    static readonly Marshaller<global::Google.LongRunning.ListOperationsRequest> __Marshaller_ListOperationsRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.LongRunning.ListOperationsRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.LongRunning.ListOperationsResponse> __Marshaller_ListOperationsResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.LongRunning.ListOperationsResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.LongRunning.CancelOperationRequest> __Marshaller_CancelOperationRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.LongRunning.CancelOperationRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly Marshaller<global::Google.LongRunning.DeleteOperationRequest> __Marshaller_DeleteOperationRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.LongRunning.DeleteOperationRequest.Parser.ParseFrom);

    static readonly Method<global::Google.LongRunning.GetOperationRequest, global::Google.LongRunning.Operation> __Method_GetOperation = new Method<global::Google.LongRunning.GetOperationRequest, global::Google.LongRunning.Operation>(
        MethodType.Unary,
        __ServiceName,
        "GetOperation",
        __Marshaller_GetOperationRequest,
        __Marshaller_Operation);

    static readonly Method<global::Google.LongRunning.ListOperationsRequest, global::Google.LongRunning.ListOperationsResponse> __Method_ListOperations = new Method<global::Google.LongRunning.ListOperationsRequest, global::Google.LongRunning.ListOperationsResponse>(
        MethodType.Unary,
        __ServiceName,
        "ListOperations",
        __Marshaller_ListOperationsRequest,
        __Marshaller_ListOperationsResponse);

    static readonly Method<global::Google.LongRunning.CancelOperationRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CancelOperation = new Method<global::Google.LongRunning.CancelOperationRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "CancelOperation",
        __Marshaller_CancelOperationRequest,
        __Marshaller_Empty);

    static readonly Method<global::Google.LongRunning.DeleteOperationRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteOperation = new Method<global::Google.LongRunning.DeleteOperationRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        MethodType.Unary,
        __ServiceName,
        "DeleteOperation",
        __Marshaller_DeleteOperationRequest,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.LongRunning.OperationsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Operations</summary>
    public abstract class OperationsBase
    {
      /// <summary>
      ///  Gets the latest state of a long-running operation.  Clients can use this
      ///  method to poll the operation result at intervals as recommended by the API
      ///  service.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> GetOperation(global::Google.LongRunning.GetOperationRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Lists operations that match the specified filter in the request. If the
      ///  server doesn't support this method, it returns `UNIMPLEMENTED`.
      ///
      ///  NOTE: the `name` binding below allows API services to override the binding
      ///  to use different resource name schemes, such as `users/*/operations`.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.ListOperationsResponse> ListOperations(global::Google.LongRunning.ListOperationsRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Starts asynchronous cancellation on a long-running operation.  The server
      ///  makes a best effort to cancel the operation, but success is not
      ///  guaranteed.  If the server doesn't support this method, it returns
      ///  `google.rpc.Code.UNIMPLEMENTED`.  Clients can use
      ///  [Operations.GetOperation][google.longrunning.Operations.GetOperation] or
      ///  other methods to check whether the cancellation succeeded or whether the
      ///  operation completed despite cancellation. On successful cancellation,
      ///  the operation is not deleted; instead, it becomes an operation with
      ///  an [Operation.error][google.longrunning.Operation.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
      ///  corresponding to `Code.CANCELLED`.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> CancelOperation(global::Google.LongRunning.CancelOperationRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Deletes a long-running operation. This method indicates that the client is
      ///  no longer interested in the operation result. It does not cancel the
      ///  operation. If the server doesn't support this method, it returns
      ///  `google.rpc.Code.UNIMPLEMENTED`.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteOperation(global::Google.LongRunning.DeleteOperationRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Operations</summary>
    public class OperationsClient : ClientBase<OperationsClient>
    {
      /// <summary>Creates a new client for Operations</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public OperationsClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Operations that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public OperationsClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected OperationsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected OperationsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  Gets the latest state of a long-running operation.  Clients can use this
      ///  method to poll the operation result at intervals as recommended by the API
      ///  service.
      /// </summary>
      public virtual global::Google.LongRunning.Operation GetOperation(global::Google.LongRunning.GetOperationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetOperation(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets the latest state of a long-running operation.  Clients can use this
      ///  method to poll the operation result at intervals as recommended by the API
      ///  service.
      /// </summary>
      public virtual global::Google.LongRunning.Operation GetOperation(global::Google.LongRunning.GetOperationRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetOperation, null, options, request);
      }
      /// <summary>
      ///  Gets the latest state of a long-running operation.  Clients can use this
      ///  method to poll the operation result at intervals as recommended by the API
      ///  service.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.LongRunning.Operation> GetOperationAsync(global::Google.LongRunning.GetOperationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetOperationAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets the latest state of a long-running operation.  Clients can use this
      ///  method to poll the operation result at intervals as recommended by the API
      ///  service.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.LongRunning.Operation> GetOperationAsync(global::Google.LongRunning.GetOperationRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetOperation, null, options, request);
      }
      /// <summary>
      ///  Lists operations that match the specified filter in the request. If the
      ///  server doesn't support this method, it returns `UNIMPLEMENTED`.
      ///
      ///  NOTE: the `name` binding below allows API services to override the binding
      ///  to use different resource name schemes, such as `users/*/operations`.
      /// </summary>
      public virtual global::Google.LongRunning.ListOperationsResponse ListOperations(global::Google.LongRunning.ListOperationsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListOperations(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Lists operations that match the specified filter in the request. If the
      ///  server doesn't support this method, it returns `UNIMPLEMENTED`.
      ///
      ///  NOTE: the `name` binding below allows API services to override the binding
      ///  to use different resource name schemes, such as `users/*/operations`.
      /// </summary>
      public virtual global::Google.LongRunning.ListOperationsResponse ListOperations(global::Google.LongRunning.ListOperationsRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListOperations, null, options, request);
      }
      /// <summary>
      ///  Lists operations that match the specified filter in the request. If the
      ///  server doesn't support this method, it returns `UNIMPLEMENTED`.
      ///
      ///  NOTE: the `name` binding below allows API services to override the binding
      ///  to use different resource name schemes, such as `users/*/operations`.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.LongRunning.ListOperationsResponse> ListOperationsAsync(global::Google.LongRunning.ListOperationsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListOperationsAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Lists operations that match the specified filter in the request. If the
      ///  server doesn't support this method, it returns `UNIMPLEMENTED`.
      ///
      ///  NOTE: the `name` binding below allows API services to override the binding
      ///  to use different resource name schemes, such as `users/*/operations`.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.LongRunning.ListOperationsResponse> ListOperationsAsync(global::Google.LongRunning.ListOperationsRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListOperations, null, options, request);
      }
      /// <summary>
      ///  Starts asynchronous cancellation on a long-running operation.  The server
      ///  makes a best effort to cancel the operation, but success is not
      ///  guaranteed.  If the server doesn't support this method, it returns
      ///  `google.rpc.Code.UNIMPLEMENTED`.  Clients can use
      ///  [Operations.GetOperation][google.longrunning.Operations.GetOperation] or
      ///  other methods to check whether the cancellation succeeded or whether the
      ///  operation completed despite cancellation. On successful cancellation,
      ///  the operation is not deleted; instead, it becomes an operation with
      ///  an [Operation.error][google.longrunning.Operation.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
      ///  corresponding to `Code.CANCELLED`.
      /// </summary>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty CancelOperation(global::Google.LongRunning.CancelOperationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CancelOperation(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Starts asynchronous cancellation on a long-running operation.  The server
      ///  makes a best effort to cancel the operation, but success is not
      ///  guaranteed.  If the server doesn't support this method, it returns
      ///  `google.rpc.Code.UNIMPLEMENTED`.  Clients can use
      ///  [Operations.GetOperation][google.longrunning.Operations.GetOperation] or
      ///  other methods to check whether the cancellation succeeded or whether the
      ///  operation completed despite cancellation. On successful cancellation,
      ///  the operation is not deleted; instead, it becomes an operation with
      ///  an [Operation.error][google.longrunning.Operation.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
      ///  corresponding to `Code.CANCELLED`.
      /// </summary>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty CancelOperation(global::Google.LongRunning.CancelOperationRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CancelOperation, null, options, request);
      }
      /// <summary>
      ///  Starts asynchronous cancellation on a long-running operation.  The server
      ///  makes a best effort to cancel the operation, but success is not
      ///  guaranteed.  If the server doesn't support this method, it returns
      ///  `google.rpc.Code.UNIMPLEMENTED`.  Clients can use
      ///  [Operations.GetOperation][google.longrunning.Operations.GetOperation] or
      ///  other methods to check whether the cancellation succeeded or whether the
      ///  operation completed despite cancellation. On successful cancellation,
      ///  the operation is not deleted; instead, it becomes an operation with
      ///  an [Operation.error][google.longrunning.Operation.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
      ///  corresponding to `Code.CANCELLED`.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> CancelOperationAsync(global::Google.LongRunning.CancelOperationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CancelOperationAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Starts asynchronous cancellation on a long-running operation.  The server
      ///  makes a best effort to cancel the operation, but success is not
      ///  guaranteed.  If the server doesn't support this method, it returns
      ///  `google.rpc.Code.UNIMPLEMENTED`.  Clients can use
      ///  [Operations.GetOperation][google.longrunning.Operations.GetOperation] or
      ///  other methods to check whether the cancellation succeeded or whether the
      ///  operation completed despite cancellation. On successful cancellation,
      ///  the operation is not deleted; instead, it becomes an operation with
      ///  an [Operation.error][google.longrunning.Operation.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
      ///  corresponding to `Code.CANCELLED`.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> CancelOperationAsync(global::Google.LongRunning.CancelOperationRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CancelOperation, null, options, request);
      }
      /// <summary>
      ///  Deletes a long-running operation. This method indicates that the client is
      ///  no longer interested in the operation result. It does not cancel the
      ///  operation. If the server doesn't support this method, it returns
      ///  `google.rpc.Code.UNIMPLEMENTED`.
      /// </summary>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteOperation(global::Google.LongRunning.DeleteOperationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteOperation(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Deletes a long-running operation. This method indicates that the client is
      ///  no longer interested in the operation result. It does not cancel the
      ///  operation. If the server doesn't support this method, it returns
      ///  `google.rpc.Code.UNIMPLEMENTED`.
      /// </summary>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteOperation(global::Google.LongRunning.DeleteOperationRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteOperation, null, options, request);
      }
      /// <summary>
      ///  Deletes a long-running operation. This method indicates that the client is
      ///  no longer interested in the operation result. It does not cancel the
      ///  operation. If the server doesn't support this method, it returns
      ///  `google.rpc.Code.UNIMPLEMENTED`.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteOperationAsync(global::Google.LongRunning.DeleteOperationRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteOperationAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Deletes a long-running operation. This method indicates that the client is
      ///  no longer interested in the operation result. It does not cancel the
      ///  operation. If the server doesn't support this method, it returns
      ///  `google.rpc.Code.UNIMPLEMENTED`.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteOperationAsync(global::Google.LongRunning.DeleteOperationRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteOperation, null, options, request);
      }
      protected override OperationsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OperationsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(OperationsBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetOperation, serviceImpl.GetOperation)
          .AddMethod(__Method_ListOperations, serviceImpl.ListOperations)
          .AddMethod(__Method_CancelOperation, serviceImpl.CancelOperation)
          .AddMethod(__Method_DeleteOperation, serviceImpl.DeleteOperation).Build();
    }

  }
}
#endregion
