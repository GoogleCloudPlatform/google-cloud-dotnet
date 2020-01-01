// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Language.V1
{
    /// <summary>Settings for <see cref="LanguageServiceClient"/> instances.</summary>
    public sealed partial class LanguageServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LanguageServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LanguageServiceSettings"/>.</returns>
        public static LanguageServiceSettings GetDefault() => new LanguageServiceSettings();

        /// <summary>Constructs a new <see cref="LanguageServiceSettings"/> object with default settings.</summary>
        public LanguageServiceSettings()
        {
        }

        private LanguageServiceSettings(LanguageServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AnalyzeSentimentSettings = existing.AnalyzeSentimentSettings;
            AnalyzeEntitiesSettings = existing.AnalyzeEntitiesSettings;
            AnalyzeEntitySentimentSettings = existing.AnalyzeEntitySentimentSettings;
            AnalyzeSyntaxSettings = existing.AnalyzeSyntaxSettings;
            ClassifyTextSettings = existing.ClassifyTextSettings;
            AnnotateTextSettings = existing.AnnotateTextSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LanguageServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LanguageServiceClient.AnalyzeSentiment</c> and <c>LanguageServiceClient.AnalyzeSentimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Initial timeout: 600000 milliseconds.</description></item>
        /// <item><description>Timeout multiplier: 1</description></item>
        /// <item><description>Timeout maximum delay: 600000 milliseconds.</description></item>
        /// <item><description>Total timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AnalyzeSentimentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(retryBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(100), maxDelay: sys::TimeSpan.FromMilliseconds(60000), delayMultiplier: 1.3), timeoutBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(600000), maxDelay: sys::TimeSpan.FromMilliseconds(600000), delayMultiplier: 1), totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)), retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable))));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LanguageServiceClient.AnalyzeEntities</c> and <c>LanguageServiceClient.AnalyzeEntitiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Initial timeout: 600000 milliseconds.</description></item>
        /// <item><description>Timeout multiplier: 1</description></item>
        /// <item><description>Timeout maximum delay: 600000 milliseconds.</description></item>
        /// <item><description>Total timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AnalyzeEntitiesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(retryBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(100), maxDelay: sys::TimeSpan.FromMilliseconds(60000), delayMultiplier: 1.3), timeoutBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(600000), maxDelay: sys::TimeSpan.FromMilliseconds(600000), delayMultiplier: 1), totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)), retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable))));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LanguageServiceClient.AnalyzeEntitySentiment</c> and <c>LanguageServiceClient.AnalyzeEntitySentimentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Initial timeout: 600000 milliseconds.</description></item>
        /// <item><description>Timeout multiplier: 1</description></item>
        /// <item><description>Timeout maximum delay: 600000 milliseconds.</description></item>
        /// <item><description>Total timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AnalyzeEntitySentimentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(retryBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(100), maxDelay: sys::TimeSpan.FromMilliseconds(60000), delayMultiplier: 1.3), timeoutBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(600000), maxDelay: sys::TimeSpan.FromMilliseconds(600000), delayMultiplier: 1), totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)), retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable))));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LanguageServiceClient.AnalyzeSyntax</c> and <c>LanguageServiceClient.AnalyzeSyntaxAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Initial timeout: 600000 milliseconds.</description></item>
        /// <item><description>Timeout multiplier: 1</description></item>
        /// <item><description>Timeout maximum delay: 600000 milliseconds.</description></item>
        /// <item><description>Total timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AnalyzeSyntaxSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(retryBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(100), maxDelay: sys::TimeSpan.FromMilliseconds(60000), delayMultiplier: 1.3), timeoutBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(600000), maxDelay: sys::TimeSpan.FromMilliseconds(600000), delayMultiplier: 1), totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)), retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable))));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LanguageServiceClient.ClassifyText</c> and <c>LanguageServiceClient.ClassifyTextAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Initial timeout: 600000 milliseconds.</description></item>
        /// <item><description>Timeout multiplier: 1</description></item>
        /// <item><description>Timeout maximum delay: 600000 milliseconds.</description></item>
        /// <item><description>Total timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ClassifyTextSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(retryBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(100), maxDelay: sys::TimeSpan.FromMilliseconds(60000), delayMultiplier: 1.3), timeoutBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(600000), maxDelay: sys::TimeSpan.FromMilliseconds(600000), delayMultiplier: 1), totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)), retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable))));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LanguageServiceClient.AnnotateText</c> and <c>LanguageServiceClient.AnnotateTextAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Initial timeout: 600000 milliseconds.</description></item>
        /// <item><description>Timeout multiplier: 1</description></item>
        /// <item><description>Timeout maximum delay: 600000 milliseconds.</description></item>
        /// <item><description>Total timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AnnotateTextSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(retryBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(100), maxDelay: sys::TimeSpan.FromMilliseconds(60000), delayMultiplier: 1.3), timeoutBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(600000), maxDelay: sys::TimeSpan.FromMilliseconds(600000), delayMultiplier: 1), totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)), retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable))));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LanguageServiceSettings"/> object.</returns>
        public LanguageServiceSettings Clone() => new LanguageServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LanguageServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class LanguageServiceClientBuilder : gaxgrpc::ClientBuilderBase<LanguageServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LanguageServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override LanguageServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LanguageServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        public override async stt::Task<LanguageServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LanguageServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => LanguageServiceClient.DefaultEndpoint;

        /// <inheritdoc/>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => LanguageServiceClient.DefaultScopes;

        /// <inheritdoc/>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LanguageServiceClient.ChannelPool;
    }

    /// <summary>LanguageService client wrapper, for convenient use.</summary>
    public abstract partial class LanguageServiceClient
    {
        /// <summary>
        /// The default endpoint for the LanguageService service, which is a host of "language.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("language.googleapis.com", 443);

        /// <summary>The default LanguageService scopes.</summary>
        /// <remarks>
        /// The default LanguageService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-language</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-language",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="LanguageServiceClient"/>, applying defaults for all unspecified
        /// settings, and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = await ImageAnnotatorClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="LanguageServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="LanguageServiceClient"/>.</returns>
        public static async stt::Task<LanguageServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, LanguageServiceSettings settings = null)
        {
            grpccore::Channel channel = await ChannelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="LanguageServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where 
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="LanguageServiceSettings"/>.</param>
        /// <returns>The created <see cref="LanguageServiceClient"/>.</returns>
        public static LanguageServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, LanguageServiceSettings settings = null)
        {
            grpccore::Channel channel = ChannelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="LanguageServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="LanguageServiceSettings"/>.</param>
        /// <returns>The created <see cref="LanguageServiceClient"/>.</returns>
        public static LanguageServiceClient Create(grpccore::Channel channel, LanguageServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="LanguageServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LanguageServiceSettings"/>.</param>
        /// <returns>The created <see cref="LanguageServiceClient"/>.</returns>
        public static LanguageServiceClient Create(grpccore::CallInvoker callInvoker, LanguageServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LanguageService.LanguageServiceClient grpcClient = new LanguageService.LanguageServiceClient(callInvoker);
            return new LanguageServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by
        /// <see cref="Create(grpccore::CallInvoker,LanguageServiceSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,LanguageServiceSettings)"/>. Channels which weren't
        /// automatically created are not affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to
        /// <see cref="Create(grpccore::CallInvoker,LanguageServiceSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,LanguageServiceSettings)"/> will create new channels, which
        /// could in turn be shut down by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC LanguageService client</summary>
        public virtual LanguageService.LanguageServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeSentimentResponse AnalyzeSentiment(AnalyzeSentimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(AnalyzeSentimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(AnalyzeSentimentRequest request, st::CancellationToken cancellationToken) =>
            AnalyzeSentimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate sentence offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeSentimentResponse AnalyzeSentiment(Document document, EncodingType encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeSentiment(new AnalyzeSentimentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType,
            }, callSettings);

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate sentence offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(Document document, EncodingType encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeSentimentAsync(new AnalyzeSentimentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType,
            }, callSettings);

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate sentence offsets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(Document document, EncodingType encodingType, st::CancellationToken cancellationToken) =>
            AnalyzeSentimentAsync(document, encodingType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeSentimentResponse AnalyzeSentiment(Document document, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeSentiment(new AnalyzeSentimentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
            }, callSettings);

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(Document document, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeSentimentAsync(new AnalyzeSentimentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
            }, callSettings);

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(Document document, st::CancellationToken cancellationToken) =>
            AnalyzeSentimentAsync(document, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeEntitiesResponse AnalyzeEntities(AnalyzeEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(AnalyzeEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(AnalyzeEntitiesRequest request, st::CancellationToken cancellationToken) =>
            AnalyzeEntitiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeEntitiesResponse AnalyzeEntities(Document document, EncodingType encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeEntities(new AnalyzeEntitiesRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType,
            }, callSettings);

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(Document document, EncodingType encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeEntitiesAsync(new AnalyzeEntitiesRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType,
            }, callSettings);

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(Document document, EncodingType encodingType, st::CancellationToken cancellationToken) =>
            AnalyzeEntitiesAsync(document, encodingType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeEntitySentimentResponse AnalyzeEntitySentiment(AnalyzeEntitySentimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeEntitySentimentResponse> AnalyzeEntitySentimentAsync(AnalyzeEntitySentimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeEntitySentimentResponse> AnalyzeEntitySentimentAsync(AnalyzeEntitySentimentRequest request, st::CancellationToken cancellationToken) =>
            AnalyzeEntitySentimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeEntitySentimentResponse AnalyzeEntitySentiment(Document document, EncodingType encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeEntitySentiment(new AnalyzeEntitySentimentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType,
            }, callSettings);

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeEntitySentimentResponse> AnalyzeEntitySentimentAsync(Document document, EncodingType encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeEntitySentimentAsync(new AnalyzeEntitySentimentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType,
            }, callSettings);

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeEntitySentimentResponse> AnalyzeEntitySentimentAsync(Document document, EncodingType encodingType, st::CancellationToken cancellationToken) =>
            AnalyzeEntitySentimentAsync(document, encodingType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeSyntaxResponse AnalyzeSyntax(AnalyzeSyntaxRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeSyntaxResponse> AnalyzeSyntaxAsync(AnalyzeSyntaxRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeSyntaxResponse> AnalyzeSyntaxAsync(AnalyzeSyntaxRequest request, st::CancellationToken cancellationToken) =>
            AnalyzeSyntaxAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeSyntaxResponse AnalyzeSyntax(Document document, EncodingType encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeSyntax(new AnalyzeSyntaxRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType,
            }, callSettings);

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeSyntaxResponse> AnalyzeSyntaxAsync(Document document, EncodingType encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeSyntaxAsync(new AnalyzeSyntaxRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType,
            }, callSettings);

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeSyntaxResponse> AnalyzeSyntaxAsync(Document document, EncodingType encodingType, st::CancellationToken cancellationToken) =>
            AnalyzeSyntaxAsync(document, encodingType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Classifies a document into categories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClassifyTextResponse ClassifyText(ClassifyTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Classifies a document into categories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClassifyTextResponse> ClassifyTextAsync(ClassifyTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Classifies a document into categories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClassifyTextResponse> ClassifyTextAsync(ClassifyTextRequest request, st::CancellationToken cancellationToken) =>
            ClassifyTextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Classifies a document into categories.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClassifyTextResponse ClassifyText(Document document, gaxgrpc::CallSettings callSettings = null) =>
            ClassifyText(new ClassifyTextRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
            }, callSettings);

        /// <summary>
        /// Classifies a document into categories.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClassifyTextResponse> ClassifyTextAsync(Document document, gaxgrpc::CallSettings callSettings = null) =>
            ClassifyTextAsync(new ClassifyTextRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
            }, callSettings);

        /// <summary>
        /// Classifies a document into categories.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClassifyTextResponse> ClassifyTextAsync(Document document, st::CancellationToken cancellationToken) =>
            ClassifyTextAsync(document, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// A convenience method that provides all the features that analyzeSentiment,
        /// analyzeEntities, and analyzeSyntax provide in one call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotateTextResponse AnnotateText(AnnotateTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// A convenience method that provides all the features that analyzeSentiment,
        /// analyzeEntities, and analyzeSyntax provide in one call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateTextResponse> AnnotateTextAsync(AnnotateTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// A convenience method that provides all the features that analyzeSentiment,
        /// analyzeEntities, and analyzeSyntax provide in one call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateTextResponse> AnnotateTextAsync(AnnotateTextRequest request, st::CancellationToken cancellationToken) =>
            AnnotateTextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// A convenience method that provides all the features that analyzeSentiment,
        /// analyzeEntities, and analyzeSyntax provide in one call.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="features">
        /// The enabled features.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotateTextResponse AnnotateText(Document document, AnnotateTextRequest.Types.Features features, EncodingType encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateText(new AnnotateTextRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                Features = gax::GaxPreconditions.CheckNotNull(features, nameof(features)),
                EncodingType = encodingType,
            }, callSettings);

        /// <summary>
        /// A convenience method that provides all the features that analyzeSentiment,
        /// analyzeEntities, and analyzeSyntax provide in one call.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="features">
        /// The enabled features.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateTextResponse> AnnotateTextAsync(Document document, AnnotateTextRequest.Types.Features features, EncodingType encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateTextAsync(new AnnotateTextRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                Features = gax::GaxPreconditions.CheckNotNull(features, nameof(features)),
                EncodingType = encodingType,
            }, callSettings);

        /// <summary>
        /// A convenience method that provides all the features that analyzeSentiment,
        /// analyzeEntities, and analyzeSyntax provide in one call.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="features">
        /// The enabled features.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateTextResponse> AnnotateTextAsync(Document document, AnnotateTextRequest.Types.Features features, EncodingType encodingType, st::CancellationToken cancellationToken) =>
            AnnotateTextAsync(document, features, encodingType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LanguageService client wrapper implementation, for convenient use.</summary>
    public sealed partial class LanguageServiceClientImpl : LanguageServiceClient
    {
        private readonly gaxgrpc::ApiCall<AnalyzeSentimentRequest, AnalyzeSentimentResponse> _callAnalyzeSentiment;

        private readonly gaxgrpc::ApiCall<AnalyzeEntitiesRequest, AnalyzeEntitiesResponse> _callAnalyzeEntities;

        private readonly gaxgrpc::ApiCall<AnalyzeEntitySentimentRequest, AnalyzeEntitySentimentResponse> _callAnalyzeEntitySentiment;

        private readonly gaxgrpc::ApiCall<AnalyzeSyntaxRequest, AnalyzeSyntaxResponse> _callAnalyzeSyntax;

        private readonly gaxgrpc::ApiCall<ClassifyTextRequest, ClassifyTextResponse> _callClassifyText;

        private readonly gaxgrpc::ApiCall<AnnotateTextRequest, AnnotateTextResponse> _callAnnotateText;

        /// <summary>
        /// Constructs a client wrapper for the LanguageService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LanguageServiceSettings"/> used within this client.</param>
        public LanguageServiceClientImpl(LanguageService.LanguageServiceClient grpcClient, LanguageServiceSettings settings)
        {
            GrpcClient = grpcClient;
            LanguageServiceSettings effectiveSettings = settings ?? LanguageServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callAnalyzeSentiment = clientHelper.BuildApiCall<AnalyzeSentimentRequest, AnalyzeSentimentResponse>(grpcClient.AnalyzeSentimentAsync, grpcClient.AnalyzeSentiment, effectiveSettings.AnalyzeSentimentSettings);
            Modify_ApiCall(ref _callAnalyzeSentiment);
            Modify_AnalyzeSentimentApiCall(ref _callAnalyzeSentiment);
            _callAnalyzeEntities = clientHelper.BuildApiCall<AnalyzeEntitiesRequest, AnalyzeEntitiesResponse>(grpcClient.AnalyzeEntitiesAsync, grpcClient.AnalyzeEntities, effectiveSettings.AnalyzeEntitiesSettings);
            Modify_ApiCall(ref _callAnalyzeEntities);
            Modify_AnalyzeEntitiesApiCall(ref _callAnalyzeEntities);
            _callAnalyzeEntitySentiment = clientHelper.BuildApiCall<AnalyzeEntitySentimentRequest, AnalyzeEntitySentimentResponse>(grpcClient.AnalyzeEntitySentimentAsync, grpcClient.AnalyzeEntitySentiment, effectiveSettings.AnalyzeEntitySentimentSettings);
            Modify_ApiCall(ref _callAnalyzeEntitySentiment);
            Modify_AnalyzeEntitySentimentApiCall(ref _callAnalyzeEntitySentiment);
            _callAnalyzeSyntax = clientHelper.BuildApiCall<AnalyzeSyntaxRequest, AnalyzeSyntaxResponse>(grpcClient.AnalyzeSyntaxAsync, grpcClient.AnalyzeSyntax, effectiveSettings.AnalyzeSyntaxSettings);
            Modify_ApiCall(ref _callAnalyzeSyntax);
            Modify_AnalyzeSyntaxApiCall(ref _callAnalyzeSyntax);
            _callClassifyText = clientHelper.BuildApiCall<ClassifyTextRequest, ClassifyTextResponse>(grpcClient.ClassifyTextAsync, grpcClient.ClassifyText, effectiveSettings.ClassifyTextSettings);
            Modify_ApiCall(ref _callClassifyText);
            Modify_ClassifyTextApiCall(ref _callClassifyText);
            _callAnnotateText = clientHelper.BuildApiCall<AnnotateTextRequest, AnnotateTextResponse>(grpcClient.AnnotateTextAsync, grpcClient.AnnotateText, effectiveSettings.AnnotateTextSettings);
            Modify_ApiCall(ref _callAnnotateText);
            Modify_AnnotateTextApiCall(ref _callAnnotateText);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AnalyzeSentimentApiCall(ref gaxgrpc::ApiCall<AnalyzeSentimentRequest, AnalyzeSentimentResponse> call);

        partial void Modify_AnalyzeEntitiesApiCall(ref gaxgrpc::ApiCall<AnalyzeEntitiesRequest, AnalyzeEntitiesResponse> call);

        partial void Modify_AnalyzeEntitySentimentApiCall(ref gaxgrpc::ApiCall<AnalyzeEntitySentimentRequest, AnalyzeEntitySentimentResponse> call);

        partial void Modify_AnalyzeSyntaxApiCall(ref gaxgrpc::ApiCall<AnalyzeSyntaxRequest, AnalyzeSyntaxResponse> call);

        partial void Modify_ClassifyTextApiCall(ref gaxgrpc::ApiCall<ClassifyTextRequest, ClassifyTextResponse> call);

        partial void Modify_AnnotateTextApiCall(ref gaxgrpc::ApiCall<AnnotateTextRequest, AnnotateTextResponse> call);

        partial void OnConstruction(LanguageService.LanguageServiceClient grpcClient, LanguageServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LanguageService client</summary>
        public override LanguageService.LanguageServiceClient GrpcClient { get; }

        partial void Modify_AnalyzeSentimentRequest(ref AnalyzeSentimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AnalyzeEntitiesRequest(ref AnalyzeEntitiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AnalyzeEntitySentimentRequest(ref AnalyzeEntitySentimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AnalyzeSyntaxRequest(ref AnalyzeSyntaxRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ClassifyTextRequest(ref ClassifyTextRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AnnotateTextRequest(ref AnnotateTextRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalyzeSentimentResponse AnalyzeSentiment(AnalyzeSentimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeSentimentRequest(ref request, ref callSettings);
            return _callAnalyzeSentiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(AnalyzeSentimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeSentimentRequest(ref request, ref callSettings);
            return _callAnalyzeSentiment.Async(request, callSettings);
        }

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalyzeEntitiesResponse AnalyzeEntities(AnalyzeEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeEntitiesRequest(ref request, ref callSettings);
            return _callAnalyzeEntities.Sync(request, callSettings);
        }

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(AnalyzeEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeEntitiesRequest(ref request, ref callSettings);
            return _callAnalyzeEntities.Async(request, callSettings);
        }

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalyzeEntitySentimentResponse AnalyzeEntitySentiment(AnalyzeEntitySentimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeEntitySentimentRequest(ref request, ref callSettings);
            return _callAnalyzeEntitySentiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnalyzeEntitySentimentResponse> AnalyzeEntitySentimentAsync(AnalyzeEntitySentimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeEntitySentimentRequest(ref request, ref callSettings);
            return _callAnalyzeEntitySentiment.Async(request, callSettings);
        }

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalyzeSyntaxResponse AnalyzeSyntax(AnalyzeSyntaxRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeSyntaxRequest(ref request, ref callSettings);
            return _callAnalyzeSyntax.Sync(request, callSettings);
        }

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnalyzeSyntaxResponse> AnalyzeSyntaxAsync(AnalyzeSyntaxRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeSyntaxRequest(ref request, ref callSettings);
            return _callAnalyzeSyntax.Async(request, callSettings);
        }

        /// <summary>
        /// Classifies a document into categories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ClassifyTextResponse ClassifyText(ClassifyTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ClassifyTextRequest(ref request, ref callSettings);
            return _callClassifyText.Sync(request, callSettings);
        }

        /// <summary>
        /// Classifies a document into categories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ClassifyTextResponse> ClassifyTextAsync(ClassifyTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ClassifyTextRequest(ref request, ref callSettings);
            return _callClassifyText.Async(request, callSettings);
        }

        /// <summary>
        /// A convenience method that provides all the features that analyzeSentiment,
        /// analyzeEntities, and analyzeSyntax provide in one call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnnotateTextResponse AnnotateText(AnnotateTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnnotateTextRequest(ref request, ref callSettings);
            return _callAnnotateText.Sync(request, callSettings);
        }

        /// <summary>
        /// A convenience method that provides all the features that analyzeSentiment,
        /// analyzeEntities, and analyzeSyntax provide in one call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnnotateTextResponse> AnnotateTextAsync(AnnotateTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnnotateTextRequest(ref request, ref callSettings);
            return _callAnnotateText.Async(request, callSettings);
        }
    }
}
