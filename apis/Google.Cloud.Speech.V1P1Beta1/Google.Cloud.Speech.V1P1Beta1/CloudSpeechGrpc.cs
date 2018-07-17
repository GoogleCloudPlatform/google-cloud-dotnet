// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/speech/v1p1beta1/cloud_speech.proto
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

namespace Google.Cloud.Speech.V1P1Beta1 {
  /// <summary>
  /// Service that implements Google Cloud Speech API.
  /// </summary>
  public static partial class Speech
  {
    static readonly string __ServiceName = "google.cloud.speech.v1p1beta1.Speech";

    static readonly grpc::Marshaller<global::Google.Cloud.Speech.V1P1Beta1.RecognizeRequest> __Marshaller_RecognizeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Speech.V1P1Beta1.RecognizeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Speech.V1P1Beta1.RecognizeResponse> __Marshaller_RecognizeResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Speech.V1P1Beta1.RecognizeResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Speech.V1P1Beta1.LongRunningRecognizeRequest> __Marshaller_LongRunningRecognizeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Speech.V1P1Beta1.LongRunningRecognizeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_Operation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.LongRunning.Operation.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Speech.V1P1Beta1.StreamingRecognizeRequest> __Marshaller_StreamingRecognizeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Speech.V1P1Beta1.StreamingRecognizeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Speech.V1P1Beta1.StreamingRecognizeResponse> __Marshaller_StreamingRecognizeResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Speech.V1P1Beta1.StreamingRecognizeResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Speech.V1P1Beta1.RecognizeRequest, global::Google.Cloud.Speech.V1P1Beta1.RecognizeResponse> __Method_Recognize = new grpc::Method<global::Google.Cloud.Speech.V1P1Beta1.RecognizeRequest, global::Google.Cloud.Speech.V1P1Beta1.RecognizeResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Recognize",
        __Marshaller_RecognizeRequest,
        __Marshaller_RecognizeResponse);

    static readonly grpc::Method<global::Google.Cloud.Speech.V1P1Beta1.LongRunningRecognizeRequest, global::Google.LongRunning.Operation> __Method_LongRunningRecognize = new grpc::Method<global::Google.Cloud.Speech.V1P1Beta1.LongRunningRecognizeRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "LongRunningRecognize",
        __Marshaller_LongRunningRecognizeRequest,
        __Marshaller_Operation);

    static readonly grpc::Method<global::Google.Cloud.Speech.V1P1Beta1.StreamingRecognizeRequest, global::Google.Cloud.Speech.V1P1Beta1.StreamingRecognizeResponse> __Method_StreamingRecognize = new grpc::Method<global::Google.Cloud.Speech.V1P1Beta1.StreamingRecognizeRequest, global::Google.Cloud.Speech.V1P1Beta1.StreamingRecognizeResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "StreamingRecognize",
        __Marshaller_StreamingRecognizeRequest,
        __Marshaller_StreamingRecognizeResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Speech.V1P1Beta1.CloudSpeechReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Speech</summary>
    public abstract partial class SpeechBase
    {
      /// <summary>
      /// Performs synchronous speech recognition: receive results after all audio
      /// has been sent and processed.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Speech.V1P1Beta1.RecognizeResponse> Recognize(global::Google.Cloud.Speech.V1P1Beta1.RecognizeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Performs asynchronous speech recognition: receive results via the
      /// google.longrunning.Operations interface. Returns either an
      /// `Operation.error` or an `Operation.response` which contains
      /// a `LongRunningRecognizeResponse` message.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> LongRunningRecognize(global::Google.Cloud.Speech.V1P1Beta1.LongRunningRecognizeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Performs bidirectional streaming speech recognition: receive results while
      /// sending audio. This method is only available via the gRPC API (not REST).
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task StreamingRecognize(grpc::IAsyncStreamReader<global::Google.Cloud.Speech.V1P1Beta1.StreamingRecognizeRequest> requestStream, grpc::IServerStreamWriter<global::Google.Cloud.Speech.V1P1Beta1.StreamingRecognizeResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Speech</summary>
    public partial class SpeechClient : grpc::ClientBase<SpeechClient>
    {
      /// <summary>Creates a new client for Speech</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SpeechClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Speech that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SpeechClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SpeechClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SpeechClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Performs synchronous speech recognition: receive results after all audio
      /// has been sent and processed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Speech.V1P1Beta1.RecognizeResponse Recognize(global::Google.Cloud.Speech.V1P1Beta1.RecognizeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Recognize(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Performs synchronous speech recognition: receive results after all audio
      /// has been sent and processed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Speech.V1P1Beta1.RecognizeResponse Recognize(global::Google.Cloud.Speech.V1P1Beta1.RecognizeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Recognize, null, options, request);
      }
      /// <summary>
      /// Performs synchronous speech recognition: receive results after all audio
      /// has been sent and processed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Speech.V1P1Beta1.RecognizeResponse> RecognizeAsync(global::Google.Cloud.Speech.V1P1Beta1.RecognizeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RecognizeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Performs synchronous speech recognition: receive results after all audio
      /// has been sent and processed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Speech.V1P1Beta1.RecognizeResponse> RecognizeAsync(global::Google.Cloud.Speech.V1P1Beta1.RecognizeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Recognize, null, options, request);
      }
      /// <summary>
      /// Performs asynchronous speech recognition: receive results via the
      /// google.longrunning.Operations interface. Returns either an
      /// `Operation.error` or an `Operation.response` which contains
      /// a `LongRunningRecognizeResponse` message.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation LongRunningRecognize(global::Google.Cloud.Speech.V1P1Beta1.LongRunningRecognizeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LongRunningRecognize(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Performs asynchronous speech recognition: receive results via the
      /// google.longrunning.Operations interface. Returns either an
      /// `Operation.error` or an `Operation.response` which contains
      /// a `LongRunningRecognizeResponse` message.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation LongRunningRecognize(global::Google.Cloud.Speech.V1P1Beta1.LongRunningRecognizeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_LongRunningRecognize, null, options, request);
      }
      /// <summary>
      /// Performs asynchronous speech recognition: receive results via the
      /// google.longrunning.Operations interface. Returns either an
      /// `Operation.error` or an `Operation.response` which contains
      /// a `LongRunningRecognizeResponse` message.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> LongRunningRecognizeAsync(global::Google.Cloud.Speech.V1P1Beta1.LongRunningRecognizeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LongRunningRecognizeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Performs asynchronous speech recognition: receive results via the
      /// google.longrunning.Operations interface. Returns either an
      /// `Operation.error` or an `Operation.response` which contains
      /// a `LongRunningRecognizeResponse` message.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> LongRunningRecognizeAsync(global::Google.Cloud.Speech.V1P1Beta1.LongRunningRecognizeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_LongRunningRecognize, null, options, request);
      }
      /// <summary>
      /// Performs bidirectional streaming speech recognition: receive results while
      /// sending audio. This method is only available via the gRPC API (not REST).
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Cloud.Speech.V1P1Beta1.StreamingRecognizeRequest, global::Google.Cloud.Speech.V1P1Beta1.StreamingRecognizeResponse> StreamingRecognize(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StreamingRecognize(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Performs bidirectional streaming speech recognition: receive results while
      /// sending audio. This method is only available via the gRPC API (not REST).
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Cloud.Speech.V1P1Beta1.StreamingRecognizeRequest, global::Google.Cloud.Speech.V1P1Beta1.StreamingRecognizeResponse> StreamingRecognize(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_StreamingRecognize, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SpeechClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SpeechClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SpeechBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Recognize, serviceImpl.Recognize)
          .AddMethod(__Method_LongRunningRecognize, serviceImpl.LongRunningRecognize)
          .AddMethod(__Method_StreamingRecognize, serviceImpl.StreamingRecognize).Build();
    }

  }
}
#endregion
