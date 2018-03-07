// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/logging/v2/logging_metrics.proto
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

namespace Google.Cloud.Logging.V2 {
  /// <summary>
  /// Service for configuring logs-based metrics.
  /// </summary>
  public static partial class MetricsServiceV2
  {
    static readonly string __ServiceName = "google.logging.v2.MetricsServiceV2";

    static readonly grpc::Marshaller<global::Google.Cloud.Logging.V2.ListLogMetricsRequest> __Marshaller_ListLogMetricsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Logging.V2.ListLogMetricsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Logging.V2.ListLogMetricsResponse> __Marshaller_ListLogMetricsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Logging.V2.ListLogMetricsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Logging.V2.GetLogMetricRequest> __Marshaller_GetLogMetricRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Logging.V2.GetLogMetricRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Logging.V2.LogMetric> __Marshaller_LogMetric = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Logging.V2.LogMetric.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Logging.V2.CreateLogMetricRequest> __Marshaller_CreateLogMetricRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Logging.V2.CreateLogMetricRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Logging.V2.UpdateLogMetricRequest> __Marshaller_UpdateLogMetricRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Logging.V2.UpdateLogMetricRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Logging.V2.DeleteLogMetricRequest> __Marshaller_DeleteLogMetricRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Logging.V2.DeleteLogMetricRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Logging.V2.ListLogMetricsRequest, global::Google.Cloud.Logging.V2.ListLogMetricsResponse> __Method_ListLogMetrics = new grpc::Method<global::Google.Cloud.Logging.V2.ListLogMetricsRequest, global::Google.Cloud.Logging.V2.ListLogMetricsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListLogMetrics",
        __Marshaller_ListLogMetricsRequest,
        __Marshaller_ListLogMetricsResponse);

    static readonly grpc::Method<global::Google.Cloud.Logging.V2.GetLogMetricRequest, global::Google.Cloud.Logging.V2.LogMetric> __Method_GetLogMetric = new grpc::Method<global::Google.Cloud.Logging.V2.GetLogMetricRequest, global::Google.Cloud.Logging.V2.LogMetric>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetLogMetric",
        __Marshaller_GetLogMetricRequest,
        __Marshaller_LogMetric);

    static readonly grpc::Method<global::Google.Cloud.Logging.V2.CreateLogMetricRequest, global::Google.Cloud.Logging.V2.LogMetric> __Method_CreateLogMetric = new grpc::Method<global::Google.Cloud.Logging.V2.CreateLogMetricRequest, global::Google.Cloud.Logging.V2.LogMetric>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateLogMetric",
        __Marshaller_CreateLogMetricRequest,
        __Marshaller_LogMetric);

    static readonly grpc::Method<global::Google.Cloud.Logging.V2.UpdateLogMetricRequest, global::Google.Cloud.Logging.V2.LogMetric> __Method_UpdateLogMetric = new grpc::Method<global::Google.Cloud.Logging.V2.UpdateLogMetricRequest, global::Google.Cloud.Logging.V2.LogMetric>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateLogMetric",
        __Marshaller_UpdateLogMetricRequest,
        __Marshaller_LogMetric);

    static readonly grpc::Method<global::Google.Cloud.Logging.V2.DeleteLogMetricRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteLogMetric = new grpc::Method<global::Google.Cloud.Logging.V2.DeleteLogMetricRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteLogMetric",
        __Marshaller_DeleteLogMetricRequest,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Logging.V2.LoggingMetricsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MetricsServiceV2</summary>
    public abstract partial class MetricsServiceV2Base
    {
      /// <summary>
      /// Lists logs-based metrics.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Logging.V2.ListLogMetricsResponse> ListLogMetrics(global::Google.Cloud.Logging.V2.ListLogMetricsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets a logs-based metric.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Logging.V2.LogMetric> GetLogMetric(global::Google.Cloud.Logging.V2.GetLogMetricRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a logs-based metric.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Logging.V2.LogMetric> CreateLogMetric(global::Google.Cloud.Logging.V2.CreateLogMetricRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates or updates a logs-based metric.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Logging.V2.LogMetric> UpdateLogMetric(global::Google.Cloud.Logging.V2.UpdateLogMetricRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes a logs-based metric.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteLogMetric(global::Google.Cloud.Logging.V2.DeleteLogMetricRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MetricsServiceV2</summary>
    public partial class MetricsServiceV2Client : grpc::ClientBase<MetricsServiceV2Client>
    {
      /// <summary>Creates a new client for MetricsServiceV2</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MetricsServiceV2Client(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MetricsServiceV2 that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MetricsServiceV2Client(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MetricsServiceV2Client() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MetricsServiceV2Client(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Lists logs-based metrics.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Logging.V2.ListLogMetricsResponse ListLogMetrics(global::Google.Cloud.Logging.V2.ListLogMetricsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListLogMetrics(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists logs-based metrics.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Logging.V2.ListLogMetricsResponse ListLogMetrics(global::Google.Cloud.Logging.V2.ListLogMetricsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListLogMetrics, null, options, request);
      }
      /// <summary>
      /// Lists logs-based metrics.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Logging.V2.ListLogMetricsResponse> ListLogMetricsAsync(global::Google.Cloud.Logging.V2.ListLogMetricsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListLogMetricsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists logs-based metrics.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Logging.V2.ListLogMetricsResponse> ListLogMetricsAsync(global::Google.Cloud.Logging.V2.ListLogMetricsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListLogMetrics, null, options, request);
      }
      /// <summary>
      /// Gets a logs-based metric.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Logging.V2.LogMetric GetLogMetric(global::Google.Cloud.Logging.V2.GetLogMetricRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetLogMetric(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a logs-based metric.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Logging.V2.LogMetric GetLogMetric(global::Google.Cloud.Logging.V2.GetLogMetricRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetLogMetric, null, options, request);
      }
      /// <summary>
      /// Gets a logs-based metric.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Logging.V2.LogMetric> GetLogMetricAsync(global::Google.Cloud.Logging.V2.GetLogMetricRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetLogMetricAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a logs-based metric.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Logging.V2.LogMetric> GetLogMetricAsync(global::Google.Cloud.Logging.V2.GetLogMetricRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetLogMetric, null, options, request);
      }
      /// <summary>
      /// Creates a logs-based metric.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Logging.V2.LogMetric CreateLogMetric(global::Google.Cloud.Logging.V2.CreateLogMetricRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateLogMetric(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a logs-based metric.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Logging.V2.LogMetric CreateLogMetric(global::Google.Cloud.Logging.V2.CreateLogMetricRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateLogMetric, null, options, request);
      }
      /// <summary>
      /// Creates a logs-based metric.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Logging.V2.LogMetric> CreateLogMetricAsync(global::Google.Cloud.Logging.V2.CreateLogMetricRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateLogMetricAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a logs-based metric.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Logging.V2.LogMetric> CreateLogMetricAsync(global::Google.Cloud.Logging.V2.CreateLogMetricRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateLogMetric, null, options, request);
      }
      /// <summary>
      /// Creates or updates a logs-based metric.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Logging.V2.LogMetric UpdateLogMetric(global::Google.Cloud.Logging.V2.UpdateLogMetricRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateLogMetric(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or updates a logs-based metric.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Logging.V2.LogMetric UpdateLogMetric(global::Google.Cloud.Logging.V2.UpdateLogMetricRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateLogMetric, null, options, request);
      }
      /// <summary>
      /// Creates or updates a logs-based metric.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Logging.V2.LogMetric> UpdateLogMetricAsync(global::Google.Cloud.Logging.V2.UpdateLogMetricRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateLogMetricAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or updates a logs-based metric.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Logging.V2.LogMetric> UpdateLogMetricAsync(global::Google.Cloud.Logging.V2.UpdateLogMetricRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateLogMetric, null, options, request);
      }
      /// <summary>
      /// Deletes a logs-based metric.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteLogMetric(global::Google.Cloud.Logging.V2.DeleteLogMetricRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteLogMetric(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a logs-based metric.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteLogMetric(global::Google.Cloud.Logging.V2.DeleteLogMetricRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteLogMetric, null, options, request);
      }
      /// <summary>
      /// Deletes a logs-based metric.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteLogMetricAsync(global::Google.Cloud.Logging.V2.DeleteLogMetricRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteLogMetricAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a logs-based metric.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteLogMetricAsync(global::Google.Cloud.Logging.V2.DeleteLogMetricRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteLogMetric, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MetricsServiceV2Client NewInstance(ClientBaseConfiguration configuration)
      {
        return new MetricsServiceV2Client(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MetricsServiceV2Base serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListLogMetrics, serviceImpl.ListLogMetrics)
          .AddMethod(__Method_GetLogMetric, serviceImpl.GetLogMetric)
          .AddMethod(__Method_CreateLogMetric, serviceImpl.CreateLogMetric)
          .AddMethod(__Method_UpdateLogMetric, serviceImpl.UpdateLogMetric)
          .AddMethod(__Method_DeleteLogMetric, serviceImpl.DeleteLogMetric).Build();
    }

  }
}
#endregion
