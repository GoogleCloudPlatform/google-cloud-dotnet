// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/language/v1/language_service.proto
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
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Google.Cloud.Language.V1 {
  /// <summary>
  /// Provides text analysis operations such as sentiment analysis and entity
  /// recognition.
  /// </summary>
  public static partial class LanguageService
  {
    static readonly string __ServiceName = "google.cloud.language.v1.LanguageService";

    static readonly grpc::Marshaller<global::Google.Cloud.Language.V1.AnalyzeSentimentRequest> __Marshaller_AnalyzeSentimentRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Language.V1.AnalyzeSentimentRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Language.V1.AnalyzeSentimentResponse> __Marshaller_AnalyzeSentimentResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Language.V1.AnalyzeSentimentResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest> __Marshaller_AnalyzeEntitiesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse> __Marshaller_AnalyzeEntitiesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest> __Marshaller_AnalyzeSyntaxRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse> __Marshaller_AnalyzeSyntaxResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Language.V1.AnnotateTextRequest> __Marshaller_AnnotateTextRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Language.V1.AnnotateTextRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Language.V1.AnnotateTextResponse> __Marshaller_AnnotateTextResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Language.V1.AnnotateTextResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Language.V1.AnalyzeSentimentRequest, global::Google.Cloud.Language.V1.AnalyzeSentimentResponse> __Method_AnalyzeSentiment = new grpc::Method<global::Google.Cloud.Language.V1.AnalyzeSentimentRequest, global::Google.Cloud.Language.V1.AnalyzeSentimentResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AnalyzeSentiment",
        __Marshaller_AnalyzeSentimentRequest,
        __Marshaller_AnalyzeSentimentResponse);

    static readonly grpc::Method<global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest, global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse> __Method_AnalyzeEntities = new grpc::Method<global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest, global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AnalyzeEntities",
        __Marshaller_AnalyzeEntitiesRequest,
        __Marshaller_AnalyzeEntitiesResponse);

    static readonly grpc::Method<global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest, global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse> __Method_AnalyzeSyntax = new grpc::Method<global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest, global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AnalyzeSyntax",
        __Marshaller_AnalyzeSyntaxRequest,
        __Marshaller_AnalyzeSyntaxResponse);

    static readonly grpc::Method<global::Google.Cloud.Language.V1.AnnotateTextRequest, global::Google.Cloud.Language.V1.AnnotateTextResponse> __Method_AnnotateText = new grpc::Method<global::Google.Cloud.Language.V1.AnnotateTextRequest, global::Google.Cloud.Language.V1.AnnotateTextResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AnnotateText",
        __Marshaller_AnnotateTextRequest,
        __Marshaller_AnnotateTextResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Language.V1.LanguageServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of LanguageService</summary>
    public abstract partial class LanguageServiceBase
    {
      /// <summary>
      /// Analyzes the sentiment of the provided text.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Language.V1.AnalyzeSentimentResponse> AnalyzeSentiment(global::Google.Cloud.Language.V1.AnalyzeSentimentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Finds named entities (currently proper names and common nouns) in the text
      /// along with entity types, salience, mentions for each entity, and
      /// other properties.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse> AnalyzeEntities(global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Analyzes the syntax of the text and provides sentence boundaries and
      /// tokenization along with part of speech tags, dependency trees, and other
      /// properties.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse> AnalyzeSyntax(global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// A convenience method that provides all the features that analyzeSentiment,
      /// analyzeEntities, and analyzeSyntax provide in one call.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Language.V1.AnnotateTextResponse> AnnotateText(global::Google.Cloud.Language.V1.AnnotateTextRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for LanguageService</summary>
    public partial class LanguageServiceClient : grpc::ClientBase<LanguageServiceClient>
    {
      /// <summary>Creates a new client for LanguageService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public LanguageServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for LanguageService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public LanguageServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected LanguageServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected LanguageServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Analyzes the sentiment of the provided text.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Language.V1.AnalyzeSentimentResponse AnalyzeSentiment(global::Google.Cloud.Language.V1.AnalyzeSentimentRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AnalyzeSentiment(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Analyzes the sentiment of the provided text.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Language.V1.AnalyzeSentimentResponse AnalyzeSentiment(global::Google.Cloud.Language.V1.AnalyzeSentimentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AnalyzeSentiment, null, options, request);
      }
      /// <summary>
      /// Analyzes the sentiment of the provided text.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Language.V1.AnalyzeSentimentResponse> AnalyzeSentimentAsync(global::Google.Cloud.Language.V1.AnalyzeSentimentRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AnalyzeSentimentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Analyzes the sentiment of the provided text.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Language.V1.AnalyzeSentimentResponse> AnalyzeSentimentAsync(global::Google.Cloud.Language.V1.AnalyzeSentimentRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AnalyzeSentiment, null, options, request);
      }
      /// <summary>
      /// Finds named entities (currently proper names and common nouns) in the text
      /// along with entity types, salience, mentions for each entity, and
      /// other properties.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse AnalyzeEntities(global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AnalyzeEntities(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Finds named entities (currently proper names and common nouns) in the text
      /// along with entity types, salience, mentions for each entity, and
      /// other properties.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse AnalyzeEntities(global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AnalyzeEntities, null, options, request);
      }
      /// <summary>
      /// Finds named entities (currently proper names and common nouns) in the text
      /// along with entity types, salience, mentions for each entity, and
      /// other properties.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AnalyzeEntitiesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Finds named entities (currently proper names and common nouns) in the text
      /// along with entity types, salience, mentions for each entity, and
      /// other properties.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AnalyzeEntities, null, options, request);
      }
      /// <summary>
      /// Analyzes the syntax of the text and provides sentence boundaries and
      /// tokenization along with part of speech tags, dependency trees, and other
      /// properties.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse AnalyzeSyntax(global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AnalyzeSyntax(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Analyzes the syntax of the text and provides sentence boundaries and
      /// tokenization along with part of speech tags, dependency trees, and other
      /// properties.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse AnalyzeSyntax(global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AnalyzeSyntax, null, options, request);
      }
      /// <summary>
      /// Analyzes the syntax of the text and provides sentence boundaries and
      /// tokenization along with part of speech tags, dependency trees, and other
      /// properties.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse> AnalyzeSyntaxAsync(global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AnalyzeSyntaxAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Analyzes the syntax of the text and provides sentence boundaries and
      /// tokenization along with part of speech tags, dependency trees, and other
      /// properties.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse> AnalyzeSyntaxAsync(global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AnalyzeSyntax, null, options, request);
      }
      /// <summary>
      /// A convenience method that provides all the features that analyzeSentiment,
      /// analyzeEntities, and analyzeSyntax provide in one call.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Language.V1.AnnotateTextResponse AnnotateText(global::Google.Cloud.Language.V1.AnnotateTextRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AnnotateText(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// A convenience method that provides all the features that analyzeSentiment,
      /// analyzeEntities, and analyzeSyntax provide in one call.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Language.V1.AnnotateTextResponse AnnotateText(global::Google.Cloud.Language.V1.AnnotateTextRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AnnotateText, null, options, request);
      }
      /// <summary>
      /// A convenience method that provides all the features that analyzeSentiment,
      /// analyzeEntities, and analyzeSyntax provide in one call.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Language.V1.AnnotateTextResponse> AnnotateTextAsync(global::Google.Cloud.Language.V1.AnnotateTextRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AnnotateTextAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// A convenience method that provides all the features that analyzeSentiment,
      /// analyzeEntities, and analyzeSyntax provide in one call.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Language.V1.AnnotateTextResponse> AnnotateTextAsync(global::Google.Cloud.Language.V1.AnnotateTextRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AnnotateText, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override LanguageServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new LanguageServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(LanguageServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AnalyzeSentiment, serviceImpl.AnalyzeSentiment)
          .AddMethod(__Method_AnalyzeEntities, serviceImpl.AnalyzeEntities)
          .AddMethod(__Method_AnalyzeSyntax, serviceImpl.AnalyzeSyntax)
          .AddMethod(__Method_AnnotateText, serviceImpl.AnnotateText).Build();
    }

  }
}
#endregion
