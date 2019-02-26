// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/devtools/clouderrorreporting/v1beta1/report_errors_service.proto
// </auto-generated>
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
#pragma warning disable 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.ErrorReporting.V1Beta1 {
  /// <summary>
  /// An API for reporting error events.
  /// </summary>
  public static partial class ReportErrorsService
  {
    static readonly string __ServiceName = "google.devtools.clouderrorreporting.v1beta1.ReportErrorsService";

    static readonly grpc::Marshaller<global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventRequest> __Marshaller_ReportErrorEventRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventResponse> __Marshaller_ReportErrorEventResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventRequest, global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventResponse> __Method_ReportErrorEvent = new grpc::Method<global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventRequest, global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReportErrorEvent",
        __Marshaller_ReportErrorEventRequest,
        __Marshaller_ReportErrorEventResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorsServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ReportErrorsService</summary>
    public abstract partial class ReportErrorsServiceBase
    {
      /// <summary>
      /// Report an individual error event.
      ///
      /// This endpoint accepts &lt;strong>either&lt;/strong> an OAuth token,
      /// &lt;strong>or&lt;/strong> an
      /// &lt;a href="https://support.google.com/cloud/answer/6158862">API key&lt;/a>
      /// for authentication. To use an API key, append it to the URL as the value of
      /// a `key` parameter. For example:
      /// &lt;pre>POST
      /// https://clouderrorreporting.googleapis.com/v1beta1/projects/example-project/events:report?key=123ABC456&lt;/pre>
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventResponse> ReportErrorEvent(global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ReportErrorsService</summary>
    public partial class ReportErrorsServiceClient : grpc::ClientBase<ReportErrorsServiceClient>
    {
      /// <summary>Creates a new client for ReportErrorsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ReportErrorsServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ReportErrorsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ReportErrorsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ReportErrorsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ReportErrorsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Report an individual error event.
      ///
      /// This endpoint accepts &lt;strong>either&lt;/strong> an OAuth token,
      /// &lt;strong>or&lt;/strong> an
      /// &lt;a href="https://support.google.com/cloud/answer/6158862">API key&lt;/a>
      /// for authentication. To use an API key, append it to the URL as the value of
      /// a `key` parameter. For example:
      /// &lt;pre>POST
      /// https://clouderrorreporting.googleapis.com/v1beta1/projects/example-project/events:report?key=123ABC456&lt;/pre>
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventResponse ReportErrorEvent(global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReportErrorEvent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Report an individual error event.
      ///
      /// This endpoint accepts &lt;strong>either&lt;/strong> an OAuth token,
      /// &lt;strong>or&lt;/strong> an
      /// &lt;a href="https://support.google.com/cloud/answer/6158862">API key&lt;/a>
      /// for authentication. To use an API key, append it to the URL as the value of
      /// a `key` parameter. For example:
      /// &lt;pre>POST
      /// https://clouderrorreporting.googleapis.com/v1beta1/projects/example-project/events:report?key=123ABC456&lt;/pre>
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventResponse ReportErrorEvent(global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReportErrorEvent, null, options, request);
      }
      /// <summary>
      /// Report an individual error event.
      ///
      /// This endpoint accepts &lt;strong>either&lt;/strong> an OAuth token,
      /// &lt;strong>or&lt;/strong> an
      /// &lt;a href="https://support.google.com/cloud/answer/6158862">API key&lt;/a>
      /// for authentication. To use an API key, append it to the URL as the value of
      /// a `key` parameter. For example:
      /// &lt;pre>POST
      /// https://clouderrorreporting.googleapis.com/v1beta1/projects/example-project/events:report?key=123ABC456&lt;/pre>
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventResponse> ReportErrorEventAsync(global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReportErrorEventAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Report an individual error event.
      ///
      /// This endpoint accepts &lt;strong>either&lt;/strong> an OAuth token,
      /// &lt;strong>or&lt;/strong> an
      /// &lt;a href="https://support.google.com/cloud/answer/6158862">API key&lt;/a>
      /// for authentication. To use an API key, append it to the URL as the value of
      /// a `key` parameter. For example:
      /// &lt;pre>POST
      /// https://clouderrorreporting.googleapis.com/v1beta1/projects/example-project/events:report?key=123ABC456&lt;/pre>
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventResponse> ReportErrorEventAsync(global::Google.Cloud.ErrorReporting.V1Beta1.ReportErrorEventRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReportErrorEvent, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ReportErrorsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ReportErrorsServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ReportErrorsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ReportErrorEvent, serviceImpl.ReportErrorEvent).Build();
    }

  }
}
#endregion
