// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/language/v1/language_service.proto
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

namespace Google.Cloud.Language.V1 {
  /// <summary>
  ///  Provides text analysis operations such as sentiment analysis and entity
  ///  recognition.
  /// </summary>
  public static class LanguageService
  {
    static readonly string __ServiceName = "google.cloud.language.v1.LanguageService";

    static readonly Marshaller<global::Google.Cloud.Language.V1.AnalyzeSentimentRequest> __Marshaller_AnalyzeSentimentRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Language.V1.AnalyzeSentimentRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Language.V1.AnalyzeSentimentResponse> __Marshaller_AnalyzeSentimentResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Language.V1.AnalyzeSentimentResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest> __Marshaller_AnalyzeEntitiesRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse> __Marshaller_AnalyzeEntitiesResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest> __Marshaller_AnalyzeSyntaxRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse> __Marshaller_AnalyzeSyntaxResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Language.V1.AnnotateTextRequest> __Marshaller_AnnotateTextRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Language.V1.AnnotateTextRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Cloud.Language.V1.AnnotateTextResponse> __Marshaller_AnnotateTextResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Language.V1.AnnotateTextResponse.Parser.ParseFrom);

    static readonly Method<global::Google.Cloud.Language.V1.AnalyzeSentimentRequest, global::Google.Cloud.Language.V1.AnalyzeSentimentResponse> __Method_AnalyzeSentiment = new Method<global::Google.Cloud.Language.V1.AnalyzeSentimentRequest, global::Google.Cloud.Language.V1.AnalyzeSentimentResponse>(
        MethodType.Unary,
        __ServiceName,
        "AnalyzeSentiment",
        __Marshaller_AnalyzeSentimentRequest,
        __Marshaller_AnalyzeSentimentResponse);

    static readonly Method<global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest, global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse> __Method_AnalyzeEntities = new Method<global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest, global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse>(
        MethodType.Unary,
        __ServiceName,
        "AnalyzeEntities",
        __Marshaller_AnalyzeEntitiesRequest,
        __Marshaller_AnalyzeEntitiesResponse);

    static readonly Method<global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest, global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse> __Method_AnalyzeSyntax = new Method<global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest, global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse>(
        MethodType.Unary,
        __ServiceName,
        "AnalyzeSyntax",
        __Marshaller_AnalyzeSyntaxRequest,
        __Marshaller_AnalyzeSyntaxResponse);

    static readonly Method<global::Google.Cloud.Language.V1.AnnotateTextRequest, global::Google.Cloud.Language.V1.AnnotateTextResponse> __Method_AnnotateText = new Method<global::Google.Cloud.Language.V1.AnnotateTextRequest, global::Google.Cloud.Language.V1.AnnotateTextResponse>(
        MethodType.Unary,
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
    public abstract class LanguageServiceBase
    {
      /// <summary>
      ///  Analyzes the sentiment of the provided text.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Language.V1.AnalyzeSentimentResponse> AnalyzeSentiment(global::Google.Cloud.Language.V1.AnalyzeSentimentRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Finds named entities (currently finds proper names) in the text,
      ///  entity types, salience, mentions for each entity, and other properties.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse> AnalyzeEntities(global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Analyzes the syntax of the text and provides sentence boundaries and
      ///  tokenization along with part of speech tags, dependency trees, and other
      ///  properties.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse> AnalyzeSyntax(global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  A convenience method that provides all the features that analyzeSentiment,
      ///  analyzeEntities, and analyzeSyntax provide in one call.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Language.V1.AnnotateTextResponse> AnnotateText(global::Google.Cloud.Language.V1.AnnotateTextRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for LanguageService</summary>
    public class LanguageServiceClient : ClientBase<LanguageServiceClient>
    {
      /// <summary>Creates a new client for LanguageService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public LanguageServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for LanguageService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public LanguageServiceClient(CallInvoker callInvoker) : base(callInvoker)
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
      ///  Analyzes the sentiment of the provided text.
      /// </summary>
      public virtual global::Google.Cloud.Language.V1.AnalyzeSentimentResponse AnalyzeSentiment(global::Google.Cloud.Language.V1.AnalyzeSentimentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AnalyzeSentiment(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Analyzes the sentiment of the provided text.
      /// </summary>
      public virtual global::Google.Cloud.Language.V1.AnalyzeSentimentResponse AnalyzeSentiment(global::Google.Cloud.Language.V1.AnalyzeSentimentRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AnalyzeSentiment, null, options, request);
      }
      /// <summary>
      ///  Analyzes the sentiment of the provided text.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Cloud.Language.V1.AnalyzeSentimentResponse> AnalyzeSentimentAsync(global::Google.Cloud.Language.V1.AnalyzeSentimentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AnalyzeSentimentAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Analyzes the sentiment of the provided text.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Cloud.Language.V1.AnalyzeSentimentResponse> AnalyzeSentimentAsync(global::Google.Cloud.Language.V1.AnalyzeSentimentRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AnalyzeSentiment, null, options, request);
      }
      /// <summary>
      ///  Finds named entities (currently finds proper names) in the text,
      ///  entity types, salience, mentions for each entity, and other properties.
      /// </summary>
      public virtual global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse AnalyzeEntities(global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AnalyzeEntities(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Finds named entities (currently finds proper names) in the text,
      ///  entity types, salience, mentions for each entity, and other properties.
      /// </summary>
      public virtual global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse AnalyzeEntities(global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AnalyzeEntities, null, options, request);
      }
      /// <summary>
      ///  Finds named entities (currently finds proper names) in the text,
      ///  entity types, salience, mentions for each entity, and other properties.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AnalyzeEntitiesAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Finds named entities (currently finds proper names) in the text,
      ///  entity types, salience, mentions for each entity, and other properties.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Cloud.Language.V1.AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(global::Google.Cloud.Language.V1.AnalyzeEntitiesRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AnalyzeEntities, null, options, request);
      }
      /// <summary>
      ///  Analyzes the syntax of the text and provides sentence boundaries and
      ///  tokenization along with part of speech tags, dependency trees, and other
      ///  properties.
      /// </summary>
      public virtual global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse AnalyzeSyntax(global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AnalyzeSyntax(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Analyzes the syntax of the text and provides sentence boundaries and
      ///  tokenization along with part of speech tags, dependency trees, and other
      ///  properties.
      /// </summary>
      public virtual global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse AnalyzeSyntax(global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AnalyzeSyntax, null, options, request);
      }
      /// <summary>
      ///  Analyzes the syntax of the text and provides sentence boundaries and
      ///  tokenization along with part of speech tags, dependency trees, and other
      ///  properties.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse> AnalyzeSyntaxAsync(global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AnalyzeSyntaxAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Analyzes the syntax of the text and provides sentence boundaries and
      ///  tokenization along with part of speech tags, dependency trees, and other
      ///  properties.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Cloud.Language.V1.AnalyzeSyntaxResponse> AnalyzeSyntaxAsync(global::Google.Cloud.Language.V1.AnalyzeSyntaxRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AnalyzeSyntax, null, options, request);
      }
      /// <summary>
      ///  A convenience method that provides all the features that analyzeSentiment,
      ///  analyzeEntities, and analyzeSyntax provide in one call.
      /// </summary>
      public virtual global::Google.Cloud.Language.V1.AnnotateTextResponse AnnotateText(global::Google.Cloud.Language.V1.AnnotateTextRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AnnotateText(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  A convenience method that provides all the features that analyzeSentiment,
      ///  analyzeEntities, and analyzeSyntax provide in one call.
      /// </summary>
      public virtual global::Google.Cloud.Language.V1.AnnotateTextResponse AnnotateText(global::Google.Cloud.Language.V1.AnnotateTextRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AnnotateText, null, options, request);
      }
      /// <summary>
      ///  A convenience method that provides all the features that analyzeSentiment,
      ///  analyzeEntities, and analyzeSyntax provide in one call.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Cloud.Language.V1.AnnotateTextResponse> AnnotateTextAsync(global::Google.Cloud.Language.V1.AnnotateTextRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AnnotateTextAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  A convenience method that provides all the features that analyzeSentiment,
      ///  analyzeEntities, and analyzeSyntax provide in one call.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Cloud.Language.V1.AnnotateTextResponse> AnnotateTextAsync(global::Google.Cloud.Language.V1.AnnotateTextRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AnnotateText, null, options, request);
      }
      protected override LanguageServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new LanguageServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(LanguageServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AnalyzeSentiment, serviceImpl.AnalyzeSentiment)
          .AddMethod(__Method_AnalyzeEntities, serviceImpl.AnalyzeEntities)
          .AddMethod(__Method_AnalyzeSyntax, serviceImpl.AnalyzeSyntax)
          .AddMethod(__Method_AnnotateText, serviceImpl.AnnotateText).Build();
    }

  }
}
#endregion
