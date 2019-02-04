// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/texttospeech/v1/cloud_tts.proto
// </auto-generated>
// Original file comments:
// Copyright 2018 Google LLC.
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
//
#pragma warning disable 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.TextToSpeech.V1 {
  /// <summary>
  /// Service that implements Google Cloud Text-to-Speech API.
  /// </summary>
  public static partial class TextToSpeech
  {
    static readonly string __ServiceName = "google.cloud.texttospeech.v1.TextToSpeech";

    static readonly grpc::Marshaller<global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest> __Marshaller_ListVoicesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse> __Marshaller_ListVoicesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest> __Marshaller_SynthesizeSpeechRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse> __Marshaller_SynthesizeSpeechResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest, global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse> __Method_ListVoices = new grpc::Method<global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest, global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListVoices",
        __Marshaller_ListVoicesRequest,
        __Marshaller_ListVoicesResponse);

    static readonly grpc::Method<global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest, global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse> __Method_SynthesizeSpeech = new grpc::Method<global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest, global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SynthesizeSpeech",
        __Marshaller_SynthesizeSpeechRequest,
        __Marshaller_SynthesizeSpeechResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.TextToSpeech.V1.CloudTtsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TextToSpeech</summary>
    public abstract partial class TextToSpeechBase
    {
      /// <summary>
      /// Returns a list of Voice supported for synthesis.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse> ListVoices(global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Synthesizes speech synchronously: receive results after all text input
      /// has been processed.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse> SynthesizeSpeech(global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TextToSpeech</summary>
    public partial class TextToSpeechClient : grpc::ClientBase<TextToSpeechClient>
    {
      /// <summary>Creates a new client for TextToSpeech</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TextToSpeechClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TextToSpeech that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TextToSpeechClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TextToSpeechClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TextToSpeechClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns a list of Voice supported for synthesis.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse ListVoices(global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListVoices(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns a list of Voice supported for synthesis.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse ListVoices(global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListVoices, null, options, request);
      }
      /// <summary>
      /// Returns a list of Voice supported for synthesis.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse> ListVoicesAsync(global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListVoicesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns a list of Voice supported for synthesis.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.TextToSpeech.V1.ListVoicesResponse> ListVoicesAsync(global::Google.Cloud.TextToSpeech.V1.ListVoicesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListVoices, null, options, request);
      }
      /// <summary>
      /// Synthesizes speech synchronously: receive results after all text input
      /// has been processed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse SynthesizeSpeech(global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SynthesizeSpeech(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Synthesizes speech synchronously: receive results after all text input
      /// has been processed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse SynthesizeSpeech(global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SynthesizeSpeech, null, options, request);
      }
      /// <summary>
      /// Synthesizes speech synchronously: receive results after all text input
      /// has been processed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse> SynthesizeSpeechAsync(global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SynthesizeSpeechAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Synthesizes speech synchronously: receive results after all text input
      /// has been processed.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechResponse> SynthesizeSpeechAsync(global::Google.Cloud.TextToSpeech.V1.SynthesizeSpeechRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SynthesizeSpeech, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TextToSpeechClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TextToSpeechClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TextToSpeechBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListVoices, serviceImpl.ListVoices)
          .AddMethod(__Method_SynthesizeSpeech, serviceImpl.SynthesizeSpeech).Build();
    }

  }
}
#endregion
