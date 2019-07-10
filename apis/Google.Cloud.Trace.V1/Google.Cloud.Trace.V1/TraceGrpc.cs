// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/devtools/cloudtrace/v1/trace.proto
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
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Trace.V1 {
  /// <summary>
  /// This file describes an API for collecting and viewing traces and spans
  /// within a trace.  A Trace is a collection of spans corresponding to a single
  /// operation or set of operations for an application. A span is an individual
  /// timed event which forms a node of the trace tree. Spans for a single trace
  /// may span multiple services.
  /// </summary>
  public static partial class TraceService
  {
    static readonly string __ServiceName = "google.devtools.cloudtrace.v1.TraceService";

    static readonly grpc::Marshaller<global::Google.Cloud.Trace.V1.ListTracesRequest> __Marshaller_google_devtools_cloudtrace_v1_ListTracesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Trace.V1.ListTracesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Trace.V1.ListTracesResponse> __Marshaller_google_devtools_cloudtrace_v1_ListTracesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Trace.V1.ListTracesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Trace.V1.GetTraceRequest> __Marshaller_google_devtools_cloudtrace_v1_GetTraceRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Trace.V1.GetTraceRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Trace.V1.Trace> __Marshaller_google_devtools_cloudtrace_v1_Trace = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Trace.V1.Trace.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Trace.V1.PatchTracesRequest> __Marshaller_google_devtools_cloudtrace_v1_PatchTracesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Trace.V1.PatchTracesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Trace.V1.ListTracesRequest, global::Google.Cloud.Trace.V1.ListTracesResponse> __Method_ListTraces = new grpc::Method<global::Google.Cloud.Trace.V1.ListTracesRequest, global::Google.Cloud.Trace.V1.ListTracesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListTraces",
        __Marshaller_google_devtools_cloudtrace_v1_ListTracesRequest,
        __Marshaller_google_devtools_cloudtrace_v1_ListTracesResponse);

    static readonly grpc::Method<global::Google.Cloud.Trace.V1.GetTraceRequest, global::Google.Cloud.Trace.V1.Trace> __Method_GetTrace = new grpc::Method<global::Google.Cloud.Trace.V1.GetTraceRequest, global::Google.Cloud.Trace.V1.Trace>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetTrace",
        __Marshaller_google_devtools_cloudtrace_v1_GetTraceRequest,
        __Marshaller_google_devtools_cloudtrace_v1_Trace);

    static readonly grpc::Method<global::Google.Cloud.Trace.V1.PatchTracesRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_PatchTraces = new grpc::Method<global::Google.Cloud.Trace.V1.PatchTracesRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PatchTraces",
        __Marshaller_google_devtools_cloudtrace_v1_PatchTracesRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Trace.V1.TraceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TraceService</summary>
    [grpc::BindServiceMethod(typeof(TraceService), "BindService")]
    public abstract partial class TraceServiceBase
    {
      /// <summary>
      /// Returns of a list of traces that match the specified filter conditions.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Trace.V1.ListTracesResponse> ListTraces(global::Google.Cloud.Trace.V1.ListTracesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets a single trace by its ID.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Trace.V1.Trace> GetTrace(global::Google.Cloud.Trace.V1.GetTraceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
      /// of a trace that you send matches that of an existing trace, any fields
      /// in the existing trace and its spans are overwritten by the provided values,
      /// and any new fields provided are merged with the existing trace data. If the
      /// ID does not match, a new trace is created.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> PatchTraces(global::Google.Cloud.Trace.V1.PatchTracesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TraceService</summary>
    public partial class TraceServiceClient : grpc::ClientBase<TraceServiceClient>
    {
      /// <summary>Creates a new client for TraceService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TraceServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TraceService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TraceServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TraceServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TraceServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns of a list of traces that match the specified filter conditions.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Trace.V1.ListTracesResponse ListTraces(global::Google.Cloud.Trace.V1.ListTracesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListTraces(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns of a list of traces that match the specified filter conditions.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Trace.V1.ListTracesResponse ListTraces(global::Google.Cloud.Trace.V1.ListTracesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListTraces, null, options, request);
      }
      /// <summary>
      /// Returns of a list of traces that match the specified filter conditions.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Trace.V1.ListTracesResponse> ListTracesAsync(global::Google.Cloud.Trace.V1.ListTracesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListTracesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns of a list of traces that match the specified filter conditions.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Trace.V1.ListTracesResponse> ListTracesAsync(global::Google.Cloud.Trace.V1.ListTracesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListTraces, null, options, request);
      }
      /// <summary>
      /// Gets a single trace by its ID.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Trace.V1.Trace GetTrace(global::Google.Cloud.Trace.V1.GetTraceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTrace(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a single trace by its ID.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Trace.V1.Trace GetTrace(global::Google.Cloud.Trace.V1.GetTraceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetTrace, null, options, request);
      }
      /// <summary>
      /// Gets a single trace by its ID.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Trace.V1.Trace> GetTraceAsync(global::Google.Cloud.Trace.V1.GetTraceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTraceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a single trace by its ID.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Trace.V1.Trace> GetTraceAsync(global::Google.Cloud.Trace.V1.GetTraceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetTrace, null, options, request);
      }
      /// <summary>
      /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
      /// of a trace that you send matches that of an existing trace, any fields
      /// in the existing trace and its spans are overwritten by the provided values,
      /// and any new fields provided are merged with the existing trace data. If the
      /// ID does not match, a new trace is created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty PatchTraces(global::Google.Cloud.Trace.V1.PatchTracesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PatchTraces(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
      /// of a trace that you send matches that of an existing trace, any fields
      /// in the existing trace and its spans are overwritten by the provided values,
      /// and any new fields provided are merged with the existing trace data. If the
      /// ID does not match, a new trace is created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty PatchTraces(global::Google.Cloud.Trace.V1.PatchTracesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PatchTraces, null, options, request);
      }
      /// <summary>
      /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
      /// of a trace that you send matches that of an existing trace, any fields
      /// in the existing trace and its spans are overwritten by the provided values,
      /// and any new fields provided are merged with the existing trace data. If the
      /// ID does not match, a new trace is created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> PatchTracesAsync(global::Google.Cloud.Trace.V1.PatchTracesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PatchTracesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
      /// of a trace that you send matches that of an existing trace, any fields
      /// in the existing trace and its spans are overwritten by the provided values,
      /// and any new fields provided are merged with the existing trace data. If the
      /// ID does not match, a new trace is created.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> PatchTracesAsync(global::Google.Cloud.Trace.V1.PatchTracesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PatchTraces, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TraceServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TraceServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TraceServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListTraces, serviceImpl.ListTraces)
          .AddMethod(__Method_GetTrace, serviceImpl.GetTrace)
          .AddMethod(__Method_PatchTraces, serviceImpl.PatchTraces).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TraceServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListTraces, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Trace.V1.ListTracesRequest, global::Google.Cloud.Trace.V1.ListTracesResponse>(serviceImpl.ListTraces));
      serviceBinder.AddMethod(__Method_GetTrace, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Trace.V1.GetTraceRequest, global::Google.Cloud.Trace.V1.Trace>(serviceImpl.GetTrace));
      serviceBinder.AddMethod(__Method_PatchTraces, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Trace.V1.PatchTracesRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.PatchTraces));
    }

  }
}
#endregion
