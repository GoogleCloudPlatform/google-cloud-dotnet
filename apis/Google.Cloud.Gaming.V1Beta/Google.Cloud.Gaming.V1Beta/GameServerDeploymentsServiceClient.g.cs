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
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Gaming.V1Beta
{
    /// <summary>Settings for <see cref="GameServerDeploymentsServiceClient"/> instances.</summary>
    public sealed partial class GameServerDeploymentsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GameServerDeploymentsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GameServerDeploymentsServiceSettings"/>.</returns>
        public static GameServerDeploymentsServiceSettings GetDefault() => new GameServerDeploymentsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="GameServerDeploymentsServiceSettings"/> object with default settings.
        /// </summary>
        public GameServerDeploymentsServiceSettings()
        {
        }

        private GameServerDeploymentsServiceSettings(GameServerDeploymentsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListGameServerDeploymentsSettings = existing.ListGameServerDeploymentsSettings;
            GetGameServerDeploymentSettings = existing.GetGameServerDeploymentSettings;
            CreateGameServerDeploymentSettings = existing.CreateGameServerDeploymentSettings;
            CreateGameServerDeploymentOperationsSettings = existing.CreateGameServerDeploymentOperationsSettings.Clone();
            DeleteGameServerDeploymentSettings = existing.DeleteGameServerDeploymentSettings;
            DeleteGameServerDeploymentOperationsSettings = existing.DeleteGameServerDeploymentOperationsSettings.Clone();
            UpdateGameServerDeploymentSettings = existing.UpdateGameServerDeploymentSettings;
            UpdateGameServerDeploymentOperationsSettings = existing.UpdateGameServerDeploymentOperationsSettings.Clone();
            GetGameServerDeploymentRolloutSettings = existing.GetGameServerDeploymentRolloutSettings;
            UpdateGameServerDeploymentRolloutSettings = existing.UpdateGameServerDeploymentRolloutSettings;
            UpdateGameServerDeploymentRolloutOperationsSettings = existing.UpdateGameServerDeploymentRolloutOperationsSettings.Clone();
            PreviewGameServerDeploymentRolloutSettings = existing.PreviewGameServerDeploymentRolloutSettings;
            FetchDeploymentStateSettings = existing.FetchDeploymentStateSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GameServerDeploymentsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerDeploymentsServiceClient.ListGameServerDeployments</c> and
        /// <c>GameServerDeploymentsServiceClient.ListGameServerDeploymentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGameServerDeploymentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerDeploymentsServiceClient.GetGameServerDeployment</c> and
        /// <c>GameServerDeploymentsServiceClient.GetGameServerDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGameServerDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerDeploymentsServiceClient.CreateGameServerDeployment</c> and
        /// <c>GameServerDeploymentsServiceClient.CreateGameServerDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGameServerDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>GameServerDeploymentsServiceClient.CreateGameServerDeployment</c> and
        /// <c>GameServerDeploymentsServiceClient.CreateGameServerDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateGameServerDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerDeploymentsServiceClient.DeleteGameServerDeployment</c> and
        /// <c>GameServerDeploymentsServiceClient.DeleteGameServerDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGameServerDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>GameServerDeploymentsServiceClient.DeleteGameServerDeployment</c> and
        /// <c>GameServerDeploymentsServiceClient.DeleteGameServerDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteGameServerDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerDeploymentsServiceClient.UpdateGameServerDeployment</c> and
        /// <c>GameServerDeploymentsServiceClient.UpdateGameServerDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGameServerDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>GameServerDeploymentsServiceClient.UpdateGameServerDeployment</c> and
        /// <c>GameServerDeploymentsServiceClient.UpdateGameServerDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateGameServerDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerDeploymentsServiceClient.GetGameServerDeploymentRollout</c> and
        /// <c>GameServerDeploymentsServiceClient.GetGameServerDeploymentRolloutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGameServerDeploymentRolloutSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerDeploymentsServiceClient.UpdateGameServerDeploymentRollout</c> and
        /// <c>GameServerDeploymentsServiceClient.UpdateGameServerDeploymentRolloutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGameServerDeploymentRolloutSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>GameServerDeploymentsServiceClient.UpdateGameServerDeploymentRollout</c> and
        /// <c>GameServerDeploymentsServiceClient.UpdateGameServerDeploymentRolloutAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateGameServerDeploymentRolloutOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerDeploymentsServiceClient.PreviewGameServerDeploymentRollout</c> and
        /// <c>GameServerDeploymentsServiceClient.PreviewGameServerDeploymentRolloutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PreviewGameServerDeploymentRolloutSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GameServerDeploymentsServiceClient.FetchDeploymentState</c> and
        /// <c>GameServerDeploymentsServiceClient.FetchDeploymentStateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchDeploymentStateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GameServerDeploymentsServiceSettings"/> object.</returns>
        public GameServerDeploymentsServiceSettings Clone() => new GameServerDeploymentsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GameServerDeploymentsServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class GameServerDeploymentsServiceClientBuilder : gaxgrpc::ClientBuilderBase<GameServerDeploymentsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GameServerDeploymentsServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref GameServerDeploymentsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GameServerDeploymentsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GameServerDeploymentsServiceClient Build()
        {
            GameServerDeploymentsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GameServerDeploymentsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GameServerDeploymentsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GameServerDeploymentsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GameServerDeploymentsServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<GameServerDeploymentsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GameServerDeploymentsServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => GameServerDeploymentsServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => GameServerDeploymentsServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GameServerDeploymentsServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>GameServerDeploymentsService client wrapper, for convenient use.</summary>
    public abstract partial class GameServerDeploymentsServiceClient
    {
        /// <summary>
        /// The default endpoint for the GameServerDeploymentsService service, which is a host of
        /// "gameservices.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "gameservices.googleapis.com:443";

        /// <summary>The default GameServerDeploymentsService scopes.</summary>
        /// <remarks>
        /// The default GameServerDeploymentsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="GameServerDeploymentsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GameServerDeploymentsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GameServerDeploymentsServiceClient"/>.</returns>
        public static stt::Task<GameServerDeploymentsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GameServerDeploymentsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GameServerDeploymentsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GameServerDeploymentsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GameServerDeploymentsServiceClient"/>.</returns>
        public static GameServerDeploymentsServiceClient Create() => new GameServerDeploymentsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GameServerDeploymentsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GameServerDeploymentsServiceSettings"/>.</param>
        /// <returns>The created <see cref="GameServerDeploymentsServiceClient"/>.</returns>
        internal static GameServerDeploymentsServiceClient Create(grpccore::CallInvoker callInvoker, GameServerDeploymentsServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GameServerDeploymentsService.GameServerDeploymentsServiceClient grpcClient = new GameServerDeploymentsService.GameServerDeploymentsServiceClient(callInvoker);
            return new GameServerDeploymentsServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC GameServerDeploymentsService client</summary>
        public virtual GameServerDeploymentsService.GameServerDeploymentsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Game Server Deployments in a given project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GameServerDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGameServerDeploymentsResponse, GameServerDeployment> ListGameServerDeployments(ListGameServerDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Game Server Deployments in a given project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GameServerDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGameServerDeploymentsResponse, GameServerDeployment> ListGameServerDeploymentsAsync(ListGameServerDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Game Server Deployments in a given project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GameServerDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGameServerDeploymentsResponse, GameServerDeployment> ListGameServerDeployments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGameServerDeployments(new ListGameServerDeploymentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Game Server Deployments in a given project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GameServerDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGameServerDeploymentsResponse, GameServerDeployment> ListGameServerDeploymentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGameServerDeploymentsAsync(new ListGameServerDeploymentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Game Server Deployments in a given project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GameServerDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGameServerDeploymentsResponse, GameServerDeployment> ListGameServerDeployments(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGameServerDeployments(new ListGameServerDeploymentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Game Server Deployments in a given project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GameServerDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGameServerDeploymentsResponse, GameServerDeployment> ListGameServerDeploymentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGameServerDeploymentsAsync(new ListGameServerDeploymentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GameServerDeployment GetGameServerDeployment(GetGameServerDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerDeployment> GetGameServerDeploymentAsync(GetGameServerDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerDeployment> GetGameServerDeploymentAsync(GetGameServerDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetGameServerDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Game Server Deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to retrieve. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GameServerDeployment GetGameServerDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGameServerDeployment(new GetGameServerDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Game Server Deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to retrieve. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerDeployment> GetGameServerDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGameServerDeploymentAsync(new GetGameServerDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Game Server Deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to retrieve. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerDeployment> GetGameServerDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            GetGameServerDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Game Server Deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to retrieve. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GameServerDeployment GetGameServerDeployment(GameServerDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGameServerDeployment(new GetGameServerDeploymentRequest
            {
                GameServerDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Game Server Deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to retrieve. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerDeployment> GetGameServerDeploymentAsync(GameServerDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGameServerDeploymentAsync(new GetGameServerDeploymentRequest
            {
                GameServerDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Game Server Deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to retrieve. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerDeployment> GetGameServerDeploymentAsync(GameServerDeploymentName name, st::CancellationToken cancellationToken) =>
            GetGameServerDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Game Server Deployment in a given project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerDeployment, OperationMetadata> CreateGameServerDeployment(CreateGameServerDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Game Server Deployment in a given project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> CreateGameServerDeploymentAsync(CreateGameServerDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Game Server Deployment in a given project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> CreateGameServerDeploymentAsync(CreateGameServerDeploymentRequest request, st::CancellationToken cancellationToken) =>
            CreateGameServerDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateGameServerDeployment</c>.</summary>
        public virtual lro::OperationsClient CreateGameServerDeploymentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGameServerDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GameServerDeployment, OperationMetadata> PollOnceCreateGameServerDeployment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GameServerDeployment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGameServerDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGameServerDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> PollOnceCreateGameServerDeploymentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GameServerDeployment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGameServerDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Game Server Deployment in a given project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="gameServerDeployment">
        /// Required. The Game Server Deployment resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerDeployment, OperationMetadata> CreateGameServerDeployment(string parent, GameServerDeployment gameServerDeployment, gaxgrpc::CallSettings callSettings = null) =>
            CreateGameServerDeployment(new CreateGameServerDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GameServerDeployment = gax::GaxPreconditions.CheckNotNull(gameServerDeployment, nameof(gameServerDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a new Game Server Deployment in a given project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="gameServerDeployment">
        /// Required. The Game Server Deployment resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> CreateGameServerDeploymentAsync(string parent, GameServerDeployment gameServerDeployment, gaxgrpc::CallSettings callSettings = null) =>
            CreateGameServerDeploymentAsync(new CreateGameServerDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GameServerDeployment = gax::GaxPreconditions.CheckNotNull(gameServerDeployment, nameof(gameServerDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a new Game Server Deployment in a given project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="gameServerDeployment">
        /// Required. The Game Server Deployment resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> CreateGameServerDeploymentAsync(string parent, GameServerDeployment gameServerDeployment, st::CancellationToken cancellationToken) =>
            CreateGameServerDeploymentAsync(parent, gameServerDeployment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Game Server Deployment in a given project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="gameServerDeployment">
        /// Required. The Game Server Deployment resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerDeployment, OperationMetadata> CreateGameServerDeployment(gagr::LocationName parent, GameServerDeployment gameServerDeployment, gaxgrpc::CallSettings callSettings = null) =>
            CreateGameServerDeployment(new CreateGameServerDeploymentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GameServerDeployment = gax::GaxPreconditions.CheckNotNull(gameServerDeployment, nameof(gameServerDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a new Game Server Deployment in a given project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="gameServerDeployment">
        /// Required. The Game Server Deployment resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> CreateGameServerDeploymentAsync(gagr::LocationName parent, GameServerDeployment gameServerDeployment, gaxgrpc::CallSettings callSettings = null) =>
            CreateGameServerDeploymentAsync(new CreateGameServerDeploymentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GameServerDeployment = gax::GaxPreconditions.CheckNotNull(gameServerDeployment, nameof(gameServerDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a new Game Server Deployment in a given project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="gameServerDeployment">
        /// Required. The Game Server Deployment resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> CreateGameServerDeploymentAsync(gagr::LocationName parent, GameServerDeployment gameServerDeployment, st::CancellationToken cancellationToken) =>
            CreateGameServerDeploymentAsync(parent, gameServerDeployment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerDeployment, OperationMetadata> DeleteGameServerDeployment(DeleteGameServerDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> DeleteGameServerDeploymentAsync(DeleteGameServerDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> DeleteGameServerDeploymentAsync(DeleteGameServerDeploymentRequest request, st::CancellationToken cancellationToken) =>
            DeleteGameServerDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteGameServerDeployment</c>.</summary>
        public virtual lro::OperationsClient DeleteGameServerDeploymentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGameServerDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GameServerDeployment, OperationMetadata> PollOnceDeleteGameServerDeployment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GameServerDeployment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGameServerDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGameServerDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> PollOnceDeleteGameServerDeploymentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GameServerDeployment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGameServerDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Game Server Deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to delete. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerDeployment, OperationMetadata> DeleteGameServerDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGameServerDeployment(new DeleteGameServerDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Game Server Deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to delete. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> DeleteGameServerDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGameServerDeploymentAsync(new DeleteGameServerDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Game Server Deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to delete. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> DeleteGameServerDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGameServerDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Game Server Deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to delete. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerDeployment, OperationMetadata> DeleteGameServerDeployment(GameServerDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGameServerDeployment(new DeleteGameServerDeploymentRequest
            {
                GameServerDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Game Server Deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to delete. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> DeleteGameServerDeploymentAsync(GameServerDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGameServerDeploymentAsync(new DeleteGameServerDeploymentRequest
            {
                GameServerDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Game Server Deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to delete. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> DeleteGameServerDeploymentAsync(GameServerDeploymentName name, st::CancellationToken cancellationToken) =>
            DeleteGameServerDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches a Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerDeployment, OperationMetadata> UpdateGameServerDeployment(UpdateGameServerDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches a Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> UpdateGameServerDeploymentAsync(UpdateGameServerDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches a Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> UpdateGameServerDeploymentAsync(UpdateGameServerDeploymentRequest request, st::CancellationToken cancellationToken) =>
            UpdateGameServerDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateGameServerDeployment</c>.</summary>
        public virtual lro::OperationsClient UpdateGameServerDeploymentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGameServerDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GameServerDeployment, OperationMetadata> PollOnceUpdateGameServerDeployment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GameServerDeployment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGameServerDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGameServerDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> PollOnceUpdateGameServerDeploymentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GameServerDeployment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGameServerDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Patches a Game Server Deployment.
        /// </summary>
        /// <param name="gameServerDeployment">
        /// Required. The Game Server Deployment to be updated.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. For the `FieldMask` definition, see
        /// 
        /// https:
        /// //developers.google.com/protocol-buffers
        /// // /docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerDeployment, OperationMetadata> UpdateGameServerDeployment(GameServerDeployment gameServerDeployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGameServerDeployment(new UpdateGameServerDeploymentRequest
            {
                GameServerDeployment = gax::GaxPreconditions.CheckNotNull(gameServerDeployment, nameof(gameServerDeployment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Patches a Game Server Deployment.
        /// </summary>
        /// <param name="gameServerDeployment">
        /// Required. The Game Server Deployment to be updated.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. For the `FieldMask` definition, see
        /// 
        /// https:
        /// //developers.google.com/protocol-buffers
        /// // /docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> UpdateGameServerDeploymentAsync(GameServerDeployment gameServerDeployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGameServerDeploymentAsync(new UpdateGameServerDeploymentRequest
            {
                GameServerDeployment = gax::GaxPreconditions.CheckNotNull(gameServerDeployment, nameof(gameServerDeployment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Patches a Game Server Deployment.
        /// </summary>
        /// <param name="gameServerDeployment">
        /// Required. The Game Server Deployment to be updated.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. For the `FieldMask` definition, see
        /// 
        /// https:
        /// //developers.google.com/protocol-buffers
        /// // /docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> UpdateGameServerDeploymentAsync(GameServerDeployment gameServerDeployment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGameServerDeploymentAsync(gameServerDeployment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details a single Game Server Deployment Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GameServerDeploymentRollout GetGameServerDeploymentRollout(GetGameServerDeploymentRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details a single Game Server Deployment Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerDeploymentRollout> GetGameServerDeploymentRolloutAsync(GetGameServerDeploymentRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details a single Game Server Deployment Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerDeploymentRollout> GetGameServerDeploymentRolloutAsync(GetGameServerDeploymentRolloutRequest request, st::CancellationToken cancellationToken) =>
            GetGameServerDeploymentRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details a single Game Server Deployment Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to retrieve. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GameServerDeploymentRollout GetGameServerDeploymentRollout(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGameServerDeploymentRollout(new GetGameServerDeploymentRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details a single Game Server Deployment Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to retrieve. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerDeploymentRollout> GetGameServerDeploymentRolloutAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGameServerDeploymentRolloutAsync(new GetGameServerDeploymentRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details a single Game Server Deployment Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to retrieve. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerDeploymentRollout> GetGameServerDeploymentRolloutAsync(string name, st::CancellationToken cancellationToken) =>
            GetGameServerDeploymentRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details a single Game Server Deployment Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to retrieve. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GameServerDeploymentRollout GetGameServerDeploymentRollout(GameServerDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGameServerDeploymentRollout(new GetGameServerDeploymentRolloutRequest
            {
                GameServerDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details a single Game Server Deployment Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to retrieve. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerDeploymentRollout> GetGameServerDeploymentRolloutAsync(GameServerDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGameServerDeploymentRolloutAsync(new GetGameServerDeploymentRolloutRequest
            {
                GameServerDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details a single Game Server Deployment Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Game Server Deployment to retrieve. Uses the form:
        /// 
        /// `projects/{project}/locations/{location}/gameServerDeployments/{deployment}/rollout`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GameServerDeploymentRollout> GetGameServerDeploymentRolloutAsync(GameServerDeploymentName name, st::CancellationToken cancellationToken) =>
            GetGameServerDeploymentRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches a single Game Server Deployment Rollout.
        /// The method will not return an error if the update does not affect any
        /// existing realms. For example - if the default_game_server_config is changed
        /// but all existing realms use the override, that is valid. Similarly, if a
        /// non existing realm is explicitly called out in game_server_config_overrides
        /// field, that will also not result in an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerDeployment, OperationMetadata> UpdateGameServerDeploymentRollout(UpdateGameServerDeploymentRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches a single Game Server Deployment Rollout.
        /// The method will not return an error if the update does not affect any
        /// existing realms. For example - if the default_game_server_config is changed
        /// but all existing realms use the override, that is valid. Similarly, if a
        /// non existing realm is explicitly called out in game_server_config_overrides
        /// field, that will also not result in an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> UpdateGameServerDeploymentRolloutAsync(UpdateGameServerDeploymentRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches a single Game Server Deployment Rollout.
        /// The method will not return an error if the update does not affect any
        /// existing realms. For example - if the default_game_server_config is changed
        /// but all existing realms use the override, that is valid. Similarly, if a
        /// non existing realm is explicitly called out in game_server_config_overrides
        /// field, that will also not result in an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> UpdateGameServerDeploymentRolloutAsync(UpdateGameServerDeploymentRolloutRequest request, st::CancellationToken cancellationToken) =>
            UpdateGameServerDeploymentRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateGameServerDeploymentRollout</c>.</summary>
        public virtual lro::OperationsClient UpdateGameServerDeploymentRolloutOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGameServerDeploymentRollout</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GameServerDeployment, OperationMetadata> PollOnceUpdateGameServerDeploymentRollout(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GameServerDeployment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGameServerDeploymentRolloutOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGameServerDeploymentRollout</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> PollOnceUpdateGameServerDeploymentRolloutAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GameServerDeployment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGameServerDeploymentRolloutOperationsClient, callSettings);

        /// <summary>
        /// Patches a single Game Server Deployment Rollout.
        /// The method will not return an error if the update does not affect any
        /// existing realms. For example - if the default_game_server_config is changed
        /// but all existing realms use the override, that is valid. Similarly, if a
        /// non existing realm is explicitly called out in game_server_config_overrides
        /// field, that will also not result in an error.
        /// </summary>
        /// <param name="rollout">
        /// Required. The Game Server Deployment Rollout to be updated.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. For the `FieldMask` definition, see
        /// 
        /// https:
        /// //developers.google.com/protocol-buffers
        /// // /docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GameServerDeployment, OperationMetadata> UpdateGameServerDeploymentRollout(GameServerDeploymentRollout rollout, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGameServerDeploymentRollout(new UpdateGameServerDeploymentRolloutRequest
            {
                Rollout = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Patches a single Game Server Deployment Rollout.
        /// The method will not return an error if the update does not affect any
        /// existing realms. For example - if the default_game_server_config is changed
        /// but all existing realms use the override, that is valid. Similarly, if a
        /// non existing realm is explicitly called out in game_server_config_overrides
        /// field, that will also not result in an error.
        /// </summary>
        /// <param name="rollout">
        /// Required. The Game Server Deployment Rollout to be updated.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. For the `FieldMask` definition, see
        /// 
        /// https:
        /// //developers.google.com/protocol-buffers
        /// // /docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> UpdateGameServerDeploymentRolloutAsync(GameServerDeploymentRollout rollout, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGameServerDeploymentRolloutAsync(new UpdateGameServerDeploymentRolloutRequest
            {
                Rollout = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Patches a single Game Server Deployment Rollout.
        /// The method will not return an error if the update does not affect any
        /// existing realms. For example - if the default_game_server_config is changed
        /// but all existing realms use the override, that is valid. Similarly, if a
        /// non existing realm is explicitly called out in game_server_config_overrides
        /// field, that will also not result in an error.
        /// </summary>
        /// <param name="rollout">
        /// Required. The Game Server Deployment Rollout to be updated.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. For the `FieldMask` definition, see
        /// 
        /// https:
        /// //developers.google.com/protocol-buffers
        /// // /docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> UpdateGameServerDeploymentRolloutAsync(GameServerDeploymentRollout rollout, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGameServerDeploymentRolloutAsync(rollout, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Previews the Game Server Deployment Rollout. This API does not mutate the
        /// Rollout resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PreviewGameServerDeploymentRolloutResponse PreviewGameServerDeploymentRollout(PreviewGameServerDeploymentRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Previews the Game Server Deployment Rollout. This API does not mutate the
        /// Rollout resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreviewGameServerDeploymentRolloutResponse> PreviewGameServerDeploymentRolloutAsync(PreviewGameServerDeploymentRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Previews the Game Server Deployment Rollout. This API does not mutate the
        /// Rollout resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreviewGameServerDeploymentRolloutResponse> PreviewGameServerDeploymentRolloutAsync(PreviewGameServerDeploymentRolloutRequest request, st::CancellationToken cancellationToken) =>
            PreviewGameServerDeploymentRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves information about the current state of the Game Server
        /// Ddeployment. Gathers all the Agones fleets and Agones autoscalers,
        /// including fleets running an older version of the Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchDeploymentStateResponse FetchDeploymentState(FetchDeploymentStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves information about the current state of the Game Server
        /// Ddeployment. Gathers all the Agones fleets and Agones autoscalers,
        /// including fleets running an older version of the Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchDeploymentStateResponse> FetchDeploymentStateAsync(FetchDeploymentStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves information about the current state of the Game Server
        /// Ddeployment. Gathers all the Agones fleets and Agones autoscalers,
        /// including fleets running an older version of the Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchDeploymentStateResponse> FetchDeploymentStateAsync(FetchDeploymentStateRequest request, st::CancellationToken cancellationToken) =>
            FetchDeploymentStateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GameServerDeploymentsService client wrapper implementation, for convenient use.</summary>
    public sealed partial class GameServerDeploymentsServiceClientImpl : GameServerDeploymentsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListGameServerDeploymentsRequest, ListGameServerDeploymentsResponse> _callListGameServerDeployments;

        private readonly gaxgrpc::ApiCall<GetGameServerDeploymentRequest, GameServerDeployment> _callGetGameServerDeployment;

        private readonly gaxgrpc::ApiCall<CreateGameServerDeploymentRequest, lro::Operation> _callCreateGameServerDeployment;

        private readonly gaxgrpc::ApiCall<DeleteGameServerDeploymentRequest, lro::Operation> _callDeleteGameServerDeployment;

        private readonly gaxgrpc::ApiCall<UpdateGameServerDeploymentRequest, lro::Operation> _callUpdateGameServerDeployment;

        private readonly gaxgrpc::ApiCall<GetGameServerDeploymentRolloutRequest, GameServerDeploymentRollout> _callGetGameServerDeploymentRollout;

        private readonly gaxgrpc::ApiCall<UpdateGameServerDeploymentRolloutRequest, lro::Operation> _callUpdateGameServerDeploymentRollout;

        private readonly gaxgrpc::ApiCall<PreviewGameServerDeploymentRolloutRequest, PreviewGameServerDeploymentRolloutResponse> _callPreviewGameServerDeploymentRollout;

        private readonly gaxgrpc::ApiCall<FetchDeploymentStateRequest, FetchDeploymentStateResponse> _callFetchDeploymentState;

        /// <summary>
        /// Constructs a client wrapper for the GameServerDeploymentsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="GameServerDeploymentsServiceSettings"/> used within this client.
        /// </param>
        public GameServerDeploymentsServiceClientImpl(GameServerDeploymentsService.GameServerDeploymentsServiceClient grpcClient, GameServerDeploymentsServiceSettings settings)
        {
            GrpcClient = grpcClient;
            GameServerDeploymentsServiceSettings effectiveSettings = settings ?? GameServerDeploymentsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateGameServerDeploymentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateGameServerDeploymentOperationsSettings);
            DeleteGameServerDeploymentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteGameServerDeploymentOperationsSettings);
            UpdateGameServerDeploymentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateGameServerDeploymentOperationsSettings);
            UpdateGameServerDeploymentRolloutOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateGameServerDeploymentRolloutOperationsSettings);
            _callListGameServerDeployments = clientHelper.BuildApiCall<ListGameServerDeploymentsRequest, ListGameServerDeploymentsResponse>(grpcClient.ListGameServerDeploymentsAsync, grpcClient.ListGameServerDeployments, effectiveSettings.ListGameServerDeploymentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGameServerDeployments);
            Modify_ListGameServerDeploymentsApiCall(ref _callListGameServerDeployments);
            _callGetGameServerDeployment = clientHelper.BuildApiCall<GetGameServerDeploymentRequest, GameServerDeployment>(grpcClient.GetGameServerDeploymentAsync, grpcClient.GetGameServerDeployment, effectiveSettings.GetGameServerDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGameServerDeployment);
            Modify_GetGameServerDeploymentApiCall(ref _callGetGameServerDeployment);
            _callCreateGameServerDeployment = clientHelper.BuildApiCall<CreateGameServerDeploymentRequest, lro::Operation>(grpcClient.CreateGameServerDeploymentAsync, grpcClient.CreateGameServerDeployment, effectiveSettings.CreateGameServerDeploymentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGameServerDeployment);
            Modify_CreateGameServerDeploymentApiCall(ref _callCreateGameServerDeployment);
            _callDeleteGameServerDeployment = clientHelper.BuildApiCall<DeleteGameServerDeploymentRequest, lro::Operation>(grpcClient.DeleteGameServerDeploymentAsync, grpcClient.DeleteGameServerDeployment, effectiveSettings.DeleteGameServerDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGameServerDeployment);
            Modify_DeleteGameServerDeploymentApiCall(ref _callDeleteGameServerDeployment);
            _callUpdateGameServerDeployment = clientHelper.BuildApiCall<UpdateGameServerDeploymentRequest, lro::Operation>(grpcClient.UpdateGameServerDeploymentAsync, grpcClient.UpdateGameServerDeployment, effectiveSettings.UpdateGameServerDeploymentSettings).WithGoogleRequestParam("game_server_deployment.name", request => request.GameServerDeployment?.Name);
            Modify_ApiCall(ref _callUpdateGameServerDeployment);
            Modify_UpdateGameServerDeploymentApiCall(ref _callUpdateGameServerDeployment);
            _callGetGameServerDeploymentRollout = clientHelper.BuildApiCall<GetGameServerDeploymentRolloutRequest, GameServerDeploymentRollout>(grpcClient.GetGameServerDeploymentRolloutAsync, grpcClient.GetGameServerDeploymentRollout, effectiveSettings.GetGameServerDeploymentRolloutSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGameServerDeploymentRollout);
            Modify_GetGameServerDeploymentRolloutApiCall(ref _callGetGameServerDeploymentRollout);
            _callUpdateGameServerDeploymentRollout = clientHelper.BuildApiCall<UpdateGameServerDeploymentRolloutRequest, lro::Operation>(grpcClient.UpdateGameServerDeploymentRolloutAsync, grpcClient.UpdateGameServerDeploymentRollout, effectiveSettings.UpdateGameServerDeploymentRolloutSettings).WithGoogleRequestParam("rollout.name", request => request.Rollout?.Name);
            Modify_ApiCall(ref _callUpdateGameServerDeploymentRollout);
            Modify_UpdateGameServerDeploymentRolloutApiCall(ref _callUpdateGameServerDeploymentRollout);
            _callPreviewGameServerDeploymentRollout = clientHelper.BuildApiCall<PreviewGameServerDeploymentRolloutRequest, PreviewGameServerDeploymentRolloutResponse>(grpcClient.PreviewGameServerDeploymentRolloutAsync, grpcClient.PreviewGameServerDeploymentRollout, effectiveSettings.PreviewGameServerDeploymentRolloutSettings).WithGoogleRequestParam("rollout.name", request => request.Rollout?.Name);
            Modify_ApiCall(ref _callPreviewGameServerDeploymentRollout);
            Modify_PreviewGameServerDeploymentRolloutApiCall(ref _callPreviewGameServerDeploymentRollout);
            _callFetchDeploymentState = clientHelper.BuildApiCall<FetchDeploymentStateRequest, FetchDeploymentStateResponse>(grpcClient.FetchDeploymentStateAsync, grpcClient.FetchDeploymentState, effectiveSettings.FetchDeploymentStateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFetchDeploymentState);
            Modify_FetchDeploymentStateApiCall(ref _callFetchDeploymentState);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListGameServerDeploymentsApiCall(ref gaxgrpc::ApiCall<ListGameServerDeploymentsRequest, ListGameServerDeploymentsResponse> call);

        partial void Modify_GetGameServerDeploymentApiCall(ref gaxgrpc::ApiCall<GetGameServerDeploymentRequest, GameServerDeployment> call);

        partial void Modify_CreateGameServerDeploymentApiCall(ref gaxgrpc::ApiCall<CreateGameServerDeploymentRequest, lro::Operation> call);

        partial void Modify_DeleteGameServerDeploymentApiCall(ref gaxgrpc::ApiCall<DeleteGameServerDeploymentRequest, lro::Operation> call);

        partial void Modify_UpdateGameServerDeploymentApiCall(ref gaxgrpc::ApiCall<UpdateGameServerDeploymentRequest, lro::Operation> call);

        partial void Modify_GetGameServerDeploymentRolloutApiCall(ref gaxgrpc::ApiCall<GetGameServerDeploymentRolloutRequest, GameServerDeploymentRollout> call);

        partial void Modify_UpdateGameServerDeploymentRolloutApiCall(ref gaxgrpc::ApiCall<UpdateGameServerDeploymentRolloutRequest, lro::Operation> call);

        partial void Modify_PreviewGameServerDeploymentRolloutApiCall(ref gaxgrpc::ApiCall<PreviewGameServerDeploymentRolloutRequest, PreviewGameServerDeploymentRolloutResponse> call);

        partial void Modify_FetchDeploymentStateApiCall(ref gaxgrpc::ApiCall<FetchDeploymentStateRequest, FetchDeploymentStateResponse> call);

        partial void OnConstruction(GameServerDeploymentsService.GameServerDeploymentsServiceClient grpcClient, GameServerDeploymentsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GameServerDeploymentsService client</summary>
        public override GameServerDeploymentsService.GameServerDeploymentsServiceClient GrpcClient { get; }

        partial void Modify_ListGameServerDeploymentsRequest(ref ListGameServerDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGameServerDeploymentRequest(ref GetGameServerDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGameServerDeploymentRequest(ref CreateGameServerDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGameServerDeploymentRequest(ref DeleteGameServerDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGameServerDeploymentRequest(ref UpdateGameServerDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGameServerDeploymentRolloutRequest(ref GetGameServerDeploymentRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGameServerDeploymentRolloutRequest(ref UpdateGameServerDeploymentRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PreviewGameServerDeploymentRolloutRequest(ref PreviewGameServerDeploymentRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchDeploymentStateRequest(ref FetchDeploymentStateRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Game Server Deployments in a given project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GameServerDeployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListGameServerDeploymentsResponse, GameServerDeployment> ListGameServerDeployments(ListGameServerDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGameServerDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGameServerDeploymentsRequest, ListGameServerDeploymentsResponse, GameServerDeployment>(_callListGameServerDeployments, request, callSettings);
        }

        /// <summary>
        /// Lists Game Server Deployments in a given project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GameServerDeployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGameServerDeploymentsResponse, GameServerDeployment> ListGameServerDeploymentsAsync(ListGameServerDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGameServerDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGameServerDeploymentsRequest, ListGameServerDeploymentsResponse, GameServerDeployment>(_callListGameServerDeployments, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GameServerDeployment GetGameServerDeployment(GetGameServerDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGameServerDeploymentRequest(ref request, ref callSettings);
            return _callGetGameServerDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GameServerDeployment> GetGameServerDeploymentAsync(GetGameServerDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGameServerDeploymentRequest(ref request, ref callSettings);
            return _callGetGameServerDeployment.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateGameServerDeployment</c>.</summary>
        public override lro::OperationsClient CreateGameServerDeploymentOperationsClient { get; }

        /// <summary>
        /// Creates a new Game Server Deployment in a given project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GameServerDeployment, OperationMetadata> CreateGameServerDeployment(CreateGameServerDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGameServerDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<GameServerDeployment, OperationMetadata>(_callCreateGameServerDeployment.Sync(request, callSettings), CreateGameServerDeploymentOperationsClient);
        }

        /// <summary>
        /// Creates a new Game Server Deployment in a given project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> CreateGameServerDeploymentAsync(CreateGameServerDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGameServerDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<GameServerDeployment, OperationMetadata>(await _callCreateGameServerDeployment.Async(request, callSettings).ConfigureAwait(false), CreateGameServerDeploymentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteGameServerDeployment</c>.</summary>
        public override lro::OperationsClient DeleteGameServerDeploymentOperationsClient { get; }

        /// <summary>
        /// Deletes a single Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GameServerDeployment, OperationMetadata> DeleteGameServerDeployment(DeleteGameServerDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGameServerDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<GameServerDeployment, OperationMetadata>(_callDeleteGameServerDeployment.Sync(request, callSettings), DeleteGameServerDeploymentOperationsClient);
        }

        /// <summary>
        /// Deletes a single Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> DeleteGameServerDeploymentAsync(DeleteGameServerDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGameServerDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<GameServerDeployment, OperationMetadata>(await _callDeleteGameServerDeployment.Async(request, callSettings).ConfigureAwait(false), DeleteGameServerDeploymentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateGameServerDeployment</c>.</summary>
        public override lro::OperationsClient UpdateGameServerDeploymentOperationsClient { get; }

        /// <summary>
        /// Patches a Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GameServerDeployment, OperationMetadata> UpdateGameServerDeployment(UpdateGameServerDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGameServerDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<GameServerDeployment, OperationMetadata>(_callUpdateGameServerDeployment.Sync(request, callSettings), UpdateGameServerDeploymentOperationsClient);
        }

        /// <summary>
        /// Patches a Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> UpdateGameServerDeploymentAsync(UpdateGameServerDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGameServerDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<GameServerDeployment, OperationMetadata>(await _callUpdateGameServerDeployment.Async(request, callSettings).ConfigureAwait(false), UpdateGameServerDeploymentOperationsClient);
        }

        /// <summary>
        /// Gets details a single Game Server Deployment Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GameServerDeploymentRollout GetGameServerDeploymentRollout(GetGameServerDeploymentRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGameServerDeploymentRolloutRequest(ref request, ref callSettings);
            return _callGetGameServerDeploymentRollout.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details a single Game Server Deployment Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GameServerDeploymentRollout> GetGameServerDeploymentRolloutAsync(GetGameServerDeploymentRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGameServerDeploymentRolloutRequest(ref request, ref callSettings);
            return _callGetGameServerDeploymentRollout.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateGameServerDeploymentRollout</c>.</summary>
        public override lro::OperationsClient UpdateGameServerDeploymentRolloutOperationsClient { get; }

        /// <summary>
        /// Patches a single Game Server Deployment Rollout.
        /// The method will not return an error if the update does not affect any
        /// existing realms. For example - if the default_game_server_config is changed
        /// but all existing realms use the override, that is valid. Similarly, if a
        /// non existing realm is explicitly called out in game_server_config_overrides
        /// field, that will also not result in an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GameServerDeployment, OperationMetadata> UpdateGameServerDeploymentRollout(UpdateGameServerDeploymentRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGameServerDeploymentRolloutRequest(ref request, ref callSettings);
            return new lro::Operation<GameServerDeployment, OperationMetadata>(_callUpdateGameServerDeploymentRollout.Sync(request, callSettings), UpdateGameServerDeploymentRolloutOperationsClient);
        }

        /// <summary>
        /// Patches a single Game Server Deployment Rollout.
        /// The method will not return an error if the update does not affect any
        /// existing realms. For example - if the default_game_server_config is changed
        /// but all existing realms use the override, that is valid. Similarly, if a
        /// non existing realm is explicitly called out in game_server_config_overrides
        /// field, that will also not result in an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GameServerDeployment, OperationMetadata>> UpdateGameServerDeploymentRolloutAsync(UpdateGameServerDeploymentRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGameServerDeploymentRolloutRequest(ref request, ref callSettings);
            return new lro::Operation<GameServerDeployment, OperationMetadata>(await _callUpdateGameServerDeploymentRollout.Async(request, callSettings).ConfigureAwait(false), UpdateGameServerDeploymentRolloutOperationsClient);
        }

        /// <summary>
        /// Previews the Game Server Deployment Rollout. This API does not mutate the
        /// Rollout resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PreviewGameServerDeploymentRolloutResponse PreviewGameServerDeploymentRollout(PreviewGameServerDeploymentRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PreviewGameServerDeploymentRolloutRequest(ref request, ref callSettings);
            return _callPreviewGameServerDeploymentRollout.Sync(request, callSettings);
        }

        /// <summary>
        /// Previews the Game Server Deployment Rollout. This API does not mutate the
        /// Rollout resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PreviewGameServerDeploymentRolloutResponse> PreviewGameServerDeploymentRolloutAsync(PreviewGameServerDeploymentRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PreviewGameServerDeploymentRolloutRequest(ref request, ref callSettings);
            return _callPreviewGameServerDeploymentRollout.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves information about the current state of the Game Server
        /// Ddeployment. Gathers all the Agones fleets and Agones autoscalers,
        /// including fleets running an older version of the Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchDeploymentStateResponse FetchDeploymentState(FetchDeploymentStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchDeploymentStateRequest(ref request, ref callSettings);
            return _callFetchDeploymentState.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves information about the current state of the Game Server
        /// Ddeployment. Gathers all the Agones fleets and Agones autoscalers,
        /// including fleets running an older version of the Game Server Deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchDeploymentStateResponse> FetchDeploymentStateAsync(FetchDeploymentStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchDeploymentStateRequest(ref request, ref callSettings);
            return _callFetchDeploymentState.Async(request, callSettings);
        }
    }

    public partial class ListGameServerDeploymentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGameServerDeploymentsResponse : gaxgrpc::IPageResponse<GameServerDeployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GameServerDeployment> GetEnumerator() => GameServerDeployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class GameServerDeploymentsService
    {
        public partial class GameServerDeploymentsServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
