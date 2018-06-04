﻿// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.PubSub.V1.Tasks;
using Grpc.Auth;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

// This class uses TaskHelper.ConfigureAwait, rather than directly calling .ConfigureAwait().
// When running in a non-test environment this indirectly calls .ConfigureAwait(false).
// Disable the ConfigureAwaitChecker warning:
#pragma warning disable ConfigureAwaitChecker // CAC001

namespace Google.Cloud.PubSub.V1
{
    /// <summary>
    /// A PubSub subscriber that is associated with a specific <see cref="SubscriptionName"/>.
    /// </summary>
    /// <remarks>
    /// <para>To receive messages, the <see cref="StartAsync"/> method must be called,
    /// with a suitable message handler.</para>
    /// <para>The message handler <see cref="Reply"/> states whether to acknowledge the message;
    /// if acknowledged then (under normal conditions) it will not be received on this subscription again.</para>
    /// <para>But note that it is always possible to receive duplicate messages. This services
    /// guarantees "at least once" delivery, not "only once" delivery.</para>
    /// </remarks>
    public abstract class SubscriberClient
    {
        /// <summary>
        /// Reply from a message handler; whether to <see cref="Ack"/>
        /// or <see cref="Nack"/> the message to the server. 
        /// </summary>
        public enum Reply
        {
            /// <summary>
            /// Message not handled successfully.
            /// </summary>
            Nack = 0,

            /// <summary>
            /// Message handled successfully.
            /// </summary>
            Ack = 1,
        }

        /// <summary>
        /// Settings for <see cref="SubscriberClient"/>.
        /// Defaults will be used for <c>null</c> properties.
        /// </summary>
        public sealed class Settings
        {
            /// <summary>
            /// Create a new instance.
            /// </summary>
            public Settings() { }

            internal Settings(Settings other)
            {
                FlowControlSettings = other.FlowControlSettings;
                StreamAckDeadline = other.StreamAckDeadline;
                AckExtensionWindow = other.AckExtensionWindow;
                Scheduler = other.Scheduler;
            }

            /// <summary>
            /// Flow control settings.
            /// If <c>null</c>, uses flow control settings from <see cref="DefaultFlowControlSettings"/>. 
            /// </summary>
            public FlowControlSettings FlowControlSettings { get; set; }

            /// <summary>
            /// The lease time before which a message must either be ACKed
            /// or have its lease extended. This is truncated to the nearest second.
            /// If <c>null</c>, uses the default of <see cref="DefaultStreamAckDeadline"/>.
            /// </summary>
            public TimeSpan? StreamAckDeadline { get; set; }

            /// <summary>
            /// Duration before <see cref="StreamAckDeadline"/> at which the message ACK deadline
            /// is automatically extended.
            /// If <c>null</c>, uses the default of <see cref="DefaultAckExtensionWindow"/>.
            /// </summary>
            public TimeSpan? AckExtensionWindow { get; set; }

            /// <summary>
            /// The <see cref="IScheduler"/> used to schedule delays.
            /// If <c>null</c>, the default <see cref="SystemScheduler"/> is used.
            /// This is usually only used for testing.
            /// </summary>
            public IScheduler Scheduler { get; set; }

            internal void Validate()
            {
                GaxPreconditions.CheckArgumentRange(StreamAckDeadline, nameof(StreamAckDeadline), MinimumStreamAckDeadline, MaximumStreamAckDeadline);
                var maxAckExtension = TimeSpan.FromTicks((StreamAckDeadline ?? DefaultStreamAckDeadline).Ticks / 2);
                GaxPreconditions.CheckArgumentRange(AckExtensionWindow, nameof(AckExtensionWindow), MinimumAckExtensionWindow, maxAckExtension);
            }

            /// <summary>
            /// Create a clone of this object.
            /// </summary>
            /// <returns>A clone of this object.</returns>
            public Settings Clone() => new Settings(this);
        }

        /// <summary>
        /// Settings for creating <see cref="SubscriberServiceApiClient"/>s.
        /// </summary>
        public sealed class ClientCreationSettings
        {
            /// <summary>
            /// Instantiate with the specified settings.
            /// </summary>
            /// <param name="clientCount">Optional.
            /// The number of <see cref="SubscriberServiceApiClient"/>s to create and use within a <see cref="SubscriberClient"/> instance.</param>
            /// <param name="subscriberServiceApiSettings">Optional. The settings to use when creating <see cref="SubscriberServiceApiClient"/> instances.</param>
            /// <param name="credentials">Optional. Credentials to use when creating <see cref="SubscriberServiceApiClient"/> instances.</param>
            /// <param name="serviceEndpoint">Optional.
            /// The <see cref="ServiceEndpoint"/> to use when creating <see cref="SubscriberServiceApiClient"/> instances.</param>
            public ClientCreationSettings(
                int? clientCount = null,
                SubscriberServiceApiSettings subscriberServiceApiSettings = null,
                ChannelCredentials credentials = null,
                ServiceEndpoint serviceEndpoint = null)
            {
                ClientCount = clientCount;
                SubscriberServiceApiSettings = subscriberServiceApiSettings;
                Credentials = credentials;
                ServiceEndpoint = serviceEndpoint;
            }

            /// <summary>
            /// The number of <see cref="SubscriberServiceApiClient"/>s to create and use within a <see cref="SubscriberClient"/> instance.
            /// If set, must be in the range 1 to 256 (inclusive).
            /// If <c>null</c>, defaults to the CPU count on the machine this is being executed on.
            /// </summary>
            public int? ClientCount { get; }

            /// <summary>
            /// The settings to use when creating <see cref="SubscriberServiceApiClient"/> instances.
            /// If <c>null</c>, defaults to <see cref="SubscriberServiceApiSettings.GetDefault"/>.
            /// </summary>
            public SubscriberServiceApiSettings SubscriberServiceApiSettings { get; }

            /// <summary>
            /// Credentials to use when creating <see cref="SubscriberServiceApiClient"/> instances.
            /// If <c>null</c>, defaults to using the default credentials.
            /// </summary>
            public ChannelCredentials Credentials { get; }

            /// <summary>
            /// The <see cref="ServiceEndpoint"/> to use when creating <see cref="SubscriberServiceApiClient"/> instances.
            /// If <c>null</c>, defaults to <see cref="SubscriberServiceApiClient.DefaultEndpoint"/>.
            /// </summary>
            public ServiceEndpoint ServiceEndpoint { get; }

            internal void Validate()
            {
                // Fairly arbitrary upper limit.
                GaxPreconditions.CheckArgumentRange(ClientCount ?? 1, nameof(ClientCount), 1, 256);
            }
        }

        /// <summary>
        /// Default <see cref="FlowControlSettings"/> for <see cref="SubscriberClient"/>.
        /// Allows 10,000 outstanding messages; and 20Mb outstanding bytes.
        /// </summary>
        /// <returns>Default <see cref="FlowControlSettings"/> for <see cref="SubscriberClient"/>.</returns>
        public static FlowControlSettings DefaultFlowControlSettings { get; } = new FlowControlSettings(10_000, 20_000_000);

        /// <summary>
        /// The service-defined minimum message ACKnowledgement deadline of 10 seconds.
        /// </summary>
        public static TimeSpan MinimumStreamAckDeadline { get; } = TimeSpan.FromSeconds(10);

        /// <summary>
        /// The service-defined maximum message ACKnowledgement deadline of 10 minutes.
        /// </summary>
        public static TimeSpan MaximumStreamAckDeadline { get; } = TimeSpan.FromMinutes(10);

        /// <summary>
        /// The default message ACKnowledgement deadline of 60 seconds.
        /// </summary>
        public static TimeSpan DefaultStreamAckDeadline { get; } = TimeSpan.FromSeconds(60);

        /// <summary>
        /// The minimum message ACKnowledgement extension window of 50 milliseconds.
        /// </summary>
        public static TimeSpan MinimumAckExtensionWindow { get; } = TimeSpan.FromMilliseconds(50);

        /// <summary>
        /// The default message ACKnowlegdment extension window of 15 seconds.
        /// </summary>
        public static TimeSpan DefaultAckExtensionWindow { get; } = TimeSpan.FromSeconds(15);

        /// <summary>
        /// Create a <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.
        /// The default <paramref name="settings"/> and <paramref name="clientCreationSettings"/> are suitable for machines with
        /// high network bandwidth (e.g. Google Compute Engine instances). If running with more limited network bandwidth, some
        /// settings may need changing; especially <see cref="Settings.StreamAckDeadline"/>.
        /// </summary>
        /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from.</param>
        /// <param name="clientCreationSettings">Optional. <see cref="ClientCreationSettings"/> specifying how to create
        /// <see cref="SubscriberClient"/>s.</param>
        /// <param name="settings">Optional. <see cref="Settings"/> for creating a <see cref="SubscriberClient"/>.</param>
        /// <returns>A <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.</returns>
        public static async Task<SubscriberClient> CreateAsync(SubscriptionName subscriptionName, ClientCreationSettings clientCreationSettings = null, Settings settings = null)
        {
            GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName));
            clientCreationSettings?.Validate();
            // Clone settings, just in case user modifies them and an await happens in this method
            settings = settings?.Clone() ?? new Settings();
            var clientCount = clientCreationSettings?.ClientCount ?? Environment.ProcessorCount;
            var channelCredentials = clientCreationSettings?.Credentials;
            // Use default credentials if none given.
            if (channelCredentials == null)
            {
                var credentials = await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false);
                if (credentials.IsCreateScopedRequired)
                {
                    credentials = credentials.CreateScoped(SubscriberServiceApiClient.DefaultScopes);
                }
                channelCredentials = credentials.ToChannelCredentials();
            }
            // Create the channels and clients, and register shutdown functions for each channel
            var endpoint = clientCreationSettings?.ServiceEndpoint ?? SubscriberServiceApiClient.DefaultEndpoint;
            var clients = new SubscriberServiceApiClient[clientCount];
            var shutdowns = new Func<Task>[clientCount];
            // Set channel send/recv message size to unlimited. It defaults to ~4Mb which causes failures.
            var channelOptions = new[]
            {
                new ChannelOption(ChannelOptions.MaxSendMessageLength, -1),
                new ChannelOption(ChannelOptions.MaxReceiveMessageLength, -1),
            };
            for (int i = 0; i < clientCount; i++)
            {
                var channel = new Channel(endpoint.Host, endpoint.Port, channelCredentials, channelOptions);
                clients[i] = SubscriberServiceApiClient.Create(channel, clientCreationSettings?.SubscriberServiceApiSettings);
                shutdowns[i] = channel.ShutdownAsync;
            }
            Task Shutdown() => Task.WhenAll(shutdowns.Select(x => x()));
            return new SubscriberClientImpl(subscriptionName, clients, settings, Shutdown);
        }

        /// <summary>
        /// Create a <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.
        /// The gRPC <see cref="Channel"/>s underlying the provided <see cref="SubscriberServiceApiClient"/>s must have their
        /// maximum send and maximum receive sizes set to unlimited, otherwise performance will be severly affected,
        /// possibly causing a deadlock.
        /// The default <paramref name="settings"/> are suitable for machines with high network bandwidth (e.g. Google
        /// Compute Engine instances). If running with more limited network bandwidth, some settings may need changing;
        /// especially <see cref="Settings.StreamAckDeadline"/>.
        /// </summary>
        /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from.</param>
        /// <param name="clients">The <see cref="SubscriberServiceApiClient"/>s to use in a <see cref="SubscriberClient"/>.
        /// For high performance, these should all use distinct <see cref="Channel"/>s.</param>
        /// <param name="settings">Optional. <see cref="Settings"/> for creating a <see cref="SubscriberClient"/>.</param>
        /// <returns>A <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.</returns>
        public static SubscriberClient Create(SubscriptionName subscriptionName, IEnumerable<SubscriberServiceApiClient> clients, Settings settings = null) =>
            new SubscriberClientImpl(subscriptionName, clients, settings?.Clone() ?? new Settings(), null);

        /// <summary>
        /// The associated <see cref="SubscriptionName"/>.
        /// </summary>
        public virtual SubscriptionName SubscriptionName => throw new NotImplementedException();

        /// <summary>
        /// Starts receiving messages. The returned <see cref="Task"/> completes when either <see cref="StopAsync(CancellationToken)"/> is called
        /// or if an unrecoverable fault occurs. See <see cref="StopAsync(CancellationToken)"/> for more details.
        /// This method cannot be called more than once per <see cref="SubscriberClient"/> instance.
        /// </summary>
        /// <param name="handlerAsync">The handler function that is passed all received messages.
        /// This function may be called on multiple threads concurrently. Return <see cref="Reply.Ack"/> from this function
        /// to ACKnowledge this message (implying it won't be received again); or return <see cref="Reply.Nack"/> to Not
        /// ACKnowledge this message (implying it will be received again). If this function throws any Exception, then
        /// it behaves as if it returned <see cref="Reply.Nack"/>.</param>
        /// <returns>A <see cref="Task"/> that completes when the subscriber is stopped, or if an unrecoverable error occurs.</returns>
        public virtual Task StartAsync(Func<PubsubMessage, CancellationToken, Task<Reply>> handlerAsync) => throw new NotImplementedException();

        /// <summary>
        /// Stop this <see cref="SubscriberClient"/>. Cancelling <paramref name="hardStopToken"/> aborts the
        /// clean stop process, and may leave some handled messages un-ACKnowledged.
        /// The returned <see cref="Task"/> completes when all handled messages have been ACKnowledged.
        /// The returned <see cref="Task"/> faults if there is an unrecoverable error with the underlying service.
        /// The returned <see cref="Task"/> cancels if <paramref name="hardStopToken"/> is cancelled.
        /// </summary>
        /// <param name="hardStopToken">Cancel this <see cref="CancellationToken"/> to abort handlers and ACKnowledgement.</param>
        /// <returns>A <see cref="Task"/> that completes when all handled messages have been ACKnowledged;
        /// faults on unrecoverable service errors; or cancels if <paramref name="hardStopToken"/> is cancelled.</returns>
        public virtual Task StopAsync(CancellationToken hardStopToken) => throw new NotImplementedException();

        /// <summary>
        /// Stop this <see cref="SubscriberClient"/>. If <paramref name="timeout"/> expires, the
        /// clean stop process will be aborted, and may leave some handled messages un-ACKnowledged.
        /// The returned <see cref="Task"/> completes when all handled messages have been ACKnowledged.
        /// The returned <see cref="Task"/> faults if there is an unrecoverable error with the underlying service.
        /// The returned <see cref="Task"/> cancels if <paramref name="timeout"/> expires.
        /// </summary>
        /// <param name="timeout">After this period, abort handling and ACKnowledging messages.</param>
        /// <returns>A <see cref="Task"/> that completes when all handled messages have been ACKnowledged;
        /// faults on unrecoverable service errors; or cancels if <paramref name="timeout"/> expires.</returns>
        public virtual Task StopAsync(TimeSpan timeout) => StopAsync(new CancellationTokenSource(timeout).Token);
    }

    /// <summary>
    /// Implementation of <see cref="SubscriberClient"/>. 
    /// </summary>
    public sealed class SubscriberClientImpl : SubscriberClient
    {
        // TODO: Logging

        /// <summary>
        /// Instantiate a <see cref="SubscriberClientImpl"/> associated with the specified <see cref="SubscriptionName"/>.
        /// </summary>
        /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from.</param>
        /// <param name="clients">The <see cref="SubscriberServiceApiClient"/>s to use in a <see cref="SubscriberClient"/>.
        /// For high performance, these should all use distinct <see cref="Channel"/>s.</param>
        /// <param name="settings"><see cref="SubscriberClient.Settings"/> for creating a <see cref="SubscriberClient"/>.</param>
        /// <param name="shutdown">Function to call on this <see cref="SubscriberClientImpl"/> shutdown.</param>
        public SubscriberClientImpl(SubscriptionName subscriptionName, IEnumerable<SubscriberServiceApiClient> clients, Settings settings, Func<Task> shutdown)
            : this(subscriptionName, clients, settings, shutdown, TaskHelper.Default) { }

        internal SubscriberClientImpl(SubscriptionName subscriptionName, IEnumerable<SubscriberServiceApiClient> clients, Settings settings, Func<Task> shutdown, TaskHelper taskHelper)
        {
            SubscriptionName = GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName));
            GaxPreconditions.CheckNotNull(clients, nameof(clients));
            _clients = clients.ToArray();
            GaxPreconditions.CheckArgument(_clients.Length > 0, nameof(clients), "Must contain at least one client");
            GaxPreconditions.CheckArgument(_clients.All(x => x != null), nameof(clients), "All elements must be non-null");
            GaxPreconditions.CheckNotNull(settings, nameof(settings));
            settings.Validate();
            _modifyDeadlineSeconds = (int)((settings.StreamAckDeadline ?? DefaultStreamAckDeadline).TotalSeconds);
            // Enforce server-side constraint on _modifyDeadlineSeconds.
            GaxPreconditions.CheckArgument(_modifyDeadlineSeconds >= 10 && _modifyDeadlineSeconds <= 600, nameof(settings.StreamAckDeadline), "Must be between 10 and 600 seconds");
            _autoExtendInterval = TimeSpan.FromSeconds(_modifyDeadlineSeconds) - (settings.AckExtensionWindow ?? DefaultAckExtensionWindow);
            if (_autoExtendInterval < TimeSpan.FromSeconds(5))
            {
                // Silently use a sensible lower limit on _autoExtendInterval.
                _autoExtendInterval = TimeSpan.FromSeconds(5);
            }
            _shutdown = shutdown;
            _scheduler = settings.Scheduler ?? SystemScheduler.Instance;
            _taskHelper = GaxPreconditions.CheckNotNull(taskHelper, nameof(taskHelper));
            _flowControlSettings = settings.FlowControlSettings ?? DefaultFlowControlSettings;
            _maxAckExtendQueue = (int)Math.Min(_flowControlSettings.MaxOutstandingElementCount ?? long.MaxValue, 20_000);
        }

        private readonly object _lock = new object();
        private readonly SubscriberServiceApiClient[] _clients;
        private readonly Func<Task> _shutdown;
        private readonly TimeSpan _autoExtendInterval; // Interval between message lease auto-extends
        private readonly int _modifyDeadlineSeconds; // Value to use as new deadline when lease auto-extends
        private readonly int _maxAckExtendQueue; // Maximum count of acks/extends to push to server in a single messages
        private readonly IScheduler _scheduler;
        private readonly TaskHelper _taskHelper;
        private readonly FlowControlSettings _flowControlSettings;

        private TaskCompletionSource<int> _mainTcs;
        private CancellationTokenSource _globalSoftStopCts; // soft-stop is guarenteed to occur before hard-stop.
        private CancellationTokenSource _globalHardStopCts;

        /// <inheritdoc />
        public override SubscriptionName SubscriptionName { get; }

        /// <inheritdoc />
        public override Task StartAsync(Func<PubsubMessage, CancellationToken, Task<Reply>> handlerAsync)
        {
            lock (_lock)
            {
                GaxPreconditions.CheckState(_mainTcs == null, "Can only start an instance once.");
                _mainTcs = new TaskCompletionSource<int>();
                _globalSoftStopCts = new CancellationTokenSource();
                _globalHardStopCts = new CancellationTokenSource();
            }
            var registeredTasks = new HashSet<Task>();
            Action<Task> registerTask = task =>
            {
                registeredTasks.Locked(() => registeredTasks.Add(task));
                Action<Task> unregisterTask = t => registeredTasks.Locked(() => registeredTasks.Remove(t));
                task.ContinueWith(unregisterTask, CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, _taskHelper.TaskScheduler);
            };
            Flow flow = new Flow(_flowControlSettings.MaxOutstandingByteCount ?? long.MaxValue,
                _flowControlSettings.MaxOutstandingElementCount ?? long.MaxValue, registerTask, _taskHelper);
            // Start all subscribers
            var subscriberTasks = _clients.Select(client =>
            {
                var singleChannel = new SingleChannel(this, client, handlerAsync, flow, registerTask);
                return _taskHelper.Run(() => singleChannel.StartAsync());
            }).ToArray();
            // Set up finish task
            _taskHelper.Run(async () =>
            {
                // WhenAny() always returns a non-faulted task, so the await will never throw.
                var task = await _taskHelper.ConfigureAwait(_taskHelper.WhenAny(subscriberTasks));
                if (task.IsFaulted)
                {
                    _globalSoftStopCts.Cancel();
                    _globalHardStopCts.Cancel();
                }
                // Wait for all subscribers to stop
                var exception = await _taskHelper.ConfigureAwaitHideErrors(() => _taskHelper.WhenAll(subscriberTasks));
                // Wait for all registered Tasks to stop
                await _taskHelper.ConfigureAwaitHideErrors(
                    () => _taskHelper.WhenAll(registeredTasks.Locked(() => registeredTasks.ToArray())));
                // Call shutdown function
                if (_shutdown != null)
                {
                    await _taskHelper.ConfigureAwaitHideErrors(_shutdown);
                }
                // Return final result
                var exceptions = ((exception as AggregateException)?.Flatten().InnerExceptions) ??
                    Enumerable.Repeat(exception, exception == null ? 0 : 1);
                if (exceptions.Any())
                {
                    _mainTcs.SetException(exceptions);
                }
                else if (_globalHardStopCts.IsCancellationRequested)
                {
                    _mainTcs.SetCanceled();
                }
                else
                {
                    _mainTcs.SetResult(0);
                }
            });
            return _mainTcs.Task;
        }

        /// <inheritdoc />
        public override Task StopAsync(CancellationToken hardStopToken)
        {
            lock (_lock)
            {
                GaxPreconditions.CheckState(_mainTcs != null, "Can only stop a started instance.");
            }
            _globalSoftStopCts.Cancel();
            var registration = hardStopToken.Register(() => _globalHardStopCts.Cancel());
            // Do not register this Task to be awaited on at shutdown.
            // It completes *after* _mainTcs, and all registered tasks must complete before _mainTcs
            _taskHelper.Run(async () =>
                await _taskHelper.ConfigureAwaitWithFinally(() => _mainTcs.Task, () => registration.Dispose()));
            return _mainTcs.Task;
        }

        /// <summary>
        /// Implements flow control for received messages.
        /// Processes received messages so long as the current outstanding message-count and byte-count are below limits.
        /// </summary>
        private class Flow
        {
            public Flow(long maxByteCount, long maxElementCount, Action<Task> registerTaskFn, TaskHelper taskHelper)
            {
                _maxByteCount = maxByteCount;
                _maxElementCount = maxElementCount;
                _registerTaskFn = registerTaskFn;
                _taskHelper = taskHelper;
                _event = new AsyncAutoResetEvent(taskHelper);
            }

            private readonly object _lock = new object();
            private readonly long _maxByteCount;
            private readonly long _maxElementCount;
            private readonly Action<Task> _registerTaskFn;
            private readonly TaskHelper _taskHelper;
            private readonly AsyncAutoResetEvent _event;

            private long _byteCount;
            private long _elementCount;

            /// <summary>
            /// Is flow-control currently within limits. Pre-condition: must be locked.
            /// </summary>
            private bool IsFlowOk() => _byteCount < _maxByteCount && _elementCount < _maxElementCount;

            /// <summary>
            /// Call <paramref name="fn"/> when allowed to do so by the flow-control limits.
            /// This will alter the current byte-count (by <paramref name="byteCount"/>) and
            /// element-count (by 1), and only call <paramref name="fn"/> once flow-control is
            /// within the limits.
            /// The returned Task will complete once <paramref name="fn"/> has been scheduled
            /// for execution on a Task; note this does not wait until <paramref name="fn"/>
            /// has completed.
            /// </summary>
            /// <param name="byteCount">The number of bytes in the element associated with <paramref name="fn"/>.</param>
            /// <param name="fn">The function to execute.</param>
            /// <returns>A Task that completes once <paramref name="fn"/> has been scheduled for execution.</returns>
            public async Task Process(long byteCount, Func<Task> fn)
            {
                while (true)
                {
                    lock (_lock)
                    {
                        if (IsFlowOk())
                        {
                            // Flow is OK, so add for this element, and execute.
                            _byteCount += byteCount;
                            _elementCount += 1;
                            break;
                        }
                    }
                    // Flow not OK, wait until a previous fn completes.
                    // CancellationToken not required, as the fn() will always drain on cancellation.
                    await _taskHelper.ConfigureAwait(_event.WaitAsync(CancellationToken.None));
                }
                // Execute fn, and schedule the following code to execute once it has completed.
                // Register the function, so we can be sure it's completed during shutdown.
                //_registerTaskFn(_taskHelper.Run(async () => await _taskHelper.ConfigureAwaitWithFinally(fn, () =>
                Task task = null;
                task = _taskHelper.Run(async () => await _taskHelper.ConfigureAwaitWithFinally(fn, () =>
                {
                    bool setEvent;
                    lock (_lock)
                    {
                        bool preIsFlowOk = IsFlowOk();
                        _byteCount -= byteCount;
                        _elementCount -= 1;
                        // If moving from flow-bad to flow-OK, then trigger the next execution.
                        setEvent = !preIsFlowOk && IsFlowOk();
                    }
                    if (setEvent)
                    {
                        _event.Set();
                    }
                }));
                _registerTaskFn(task);
            }
        }

        // internal for testing.
        internal class ReQueue<T>
        {
            private readonly Queue<T> _q = new Queue<T>();
            private readonly LinkedList<Queue<T>> _qs = new LinkedList<Queue<T>>();
            private int _requeueCount = 0;

            public void Enqueue(T item) => _q.Enqueue(item);
            public void Enqueue(IEnumerable<T> items)
            {
                foreach (var item in items)
                {
                    _q.Enqueue(item);
                }
            }
            public void Requeue(IEnumerable<T> items)
            {
                var q = new Queue<T>(items);
                _qs.AddLast(q);
                _requeueCount += q.Count;
            }

            public int Count => _q.Count + _requeueCount;

            public List<T> Dequeue(int maxCount, Predicate<T> includeFn)
            {
                List<T> result = new List<T>();
                Queue<T> q = _qs.First?.Value;
                if (q != null)
                {
                    while (result.Count < maxCount)
                    {
                        if (q.Count > 0)
                        {
                            var item = q.Dequeue();
                            _requeueCount -= 1;
                            if (includeFn == null || includeFn(item))
                            {
                                result.Add(item);
                            }
                        }
                        else
                        {
                            _qs.RemoveFirst();
                            q = _qs.First?.Value;
                            if (q == null)
                            {
                                break;
                            }
                        }
                    }
                }
                while (result.Count < maxCount && _q.Count > 0)
                {
                    var item = _q.Dequeue();
                    if (includeFn == null || includeFn(item))
                    {
                        result.Add(item);
                    }
                }
                return result;
            }

            public bool TryPeek(out T value)
            {
                var qsNode = _qs.First;
                while (qsNode != null)
                {
                    if (qsNode.Value.Count > 0)
                    {
                        value = qsNode.Value.Peek();
                        return true;
                    }
                    qsNode = qsNode.Next;
                }
                if (_q.Count > 0)
                {
                    value = _q.Peek();
                    return true;
                }
                value = default(T);
                return false;
            }
        }

        internal class AsyncSingleRecvQueue<T>
        {
            public AsyncSingleRecvQueue(TaskHelper taskHelper) => _taskHelper = taskHelper;

            private readonly TaskHelper _taskHelper;
            private readonly object _lock = new object();
            private readonly Queue<T> _queue = new Queue<T>();
            private TaskCompletionSource<int> _tcs = null;

            // Thread-safe.
            public void Enqueue(T item)
            {
                TaskCompletionSource<int> tcs;
                lock (_lock)
                {
                    _queue.Enqueue(item);
                    tcs = _tcs;
                }
                if (tcs != null)
                {
                    // Don't run in lock, as it may execute continuations synchonously.
                    tcs.SetResult(0);
                }
            }

            // Thread-safe, but only one dequeue is allowed at a time.
            public async Task<T> DequeueAsync()
            {
                lock (_lock)
                {
                    if (_queue.Count > 0)
                    {
                        return _queue.Dequeue();
                    }
                    _tcs = new TaskCompletionSource<int>();
                }
                await _taskHelper.ConfigureAwait(_tcs.Task);
                lock (_lock)
                {
                    _tcs = null;
                    return _queue.Dequeue();
                }
            }
        }

        /// <summary>
        /// Controls a single <see cref="Channel"/>/<see cref="SubscriberClient"/> within this
        /// <see cref="SubscriberClientImpl"/>. This class controls the pulling of messages, and
        /// the pushing of message acks and lease-extensions back to the server.
        /// It also manages error conditions within the channel, restarting RPCs as required.
        /// </summary>
        private class SingleChannel
        {
            private struct NextAction
            {
                public NextAction(bool isPull, Action action)
                {
                    IsPull = isPull;
                    Action = action;
                }
                public bool IsPull { get; }
                public Action Action { get; }
            }

            private struct TaskNextAction
            {
                public TaskNextAction(Task task, NextAction nextAction)
                {
                    Task = task;
                    NextAction = nextAction;
                }
                public Task Task { get; }
                public NextAction NextAction { get; }
            }

            private struct TimedId // "Time" is abstract, a monotonic incrementing counter is used.
            {
                public TimedId(long time, string id)
                {
                    Time = time;
                    Id = id;
                }
                public long Time { get; }
                public string Id { get; }
            }

            public SingleChannel(SubscriberClientImpl subscriber,
                SubscriberServiceApiClient client, Func<PubsubMessage, CancellationToken, Task<Reply>> handlerAsync,
                Flow flow,
                Action<Task> registerTaskFn)
            {
                _registerTaskFn = registerTaskFn;
                _taskHelper = subscriber._taskHelper;
                _scheduler = subscriber._scheduler;
                _client = client;
                _handlerAsync = handlerAsync;
                _hardStopCts = subscriber._globalHardStopCts;
                _pushStopCts = CancellationTokenSource.CreateLinkedTokenSource(_hardStopCts.Token);
                _softStopCts = subscriber._globalSoftStopCts;
                _subscriptionName = subscriber.SubscriptionName;
                _modifyDeadlineSeconds = subscriber._modifyDeadlineSeconds;
                _maxAckExtendQueueSize = subscriber._maxAckExtendQueue;
                _autoExtendInterval = subscriber._autoExtendInterval;
                _extendQueueThrottleInterval = TimeSpan.FromTicks((long)((TimeSpan.FromSeconds(_modifyDeadlineSeconds) - _autoExtendInterval).Ticks * 0.5));
                _maxAckExtendSendCount = Math.Max(10, subscriber._maxAckExtendQueue / 4);
                _maxConcurrentPush = 3; // Fairly arbitrary.
                _flow = flow;
                _eventPush = new AsyncAutoResetEvent(subscriber._taskHelper);
                _continuationQueue = new AsyncSingleRecvQueue<TaskNextAction>(subscriber._taskHelper);
            }

            private readonly object _lock = new object(); // For: _ackQueue, _nackQueue, _userHandlerInFlight
            private readonly Action<Task> _registerTaskFn;
            private readonly TaskHelper _taskHelper;
            private readonly IScheduler _scheduler;
            private readonly SubscriberServiceApiClient _client;
            private readonly Func<PubsubMessage, CancellationToken, Task<Reply>> _handlerAsync;
            private readonly CancellationTokenSource _hardStopCts;
            private readonly CancellationTokenSource _pushStopCts;
            private readonly CancellationTokenSource _softStopCts;
            private readonly SubscriptionName _subscriptionName;
            private readonly int _modifyDeadlineSeconds; // Seconds to add to deadling on lease extension.
            private readonly TimeSpan _autoExtendInterval; // Delay between auto-extends.
            private readonly TimeSpan _extendQueueThrottleInterval; // Throttle pull if items in the extend queue are older than this.
            private readonly int _maxAckExtendQueueSize; // Soft limit on push queue sizes. Used to throttle pulls.
            private readonly int _maxAckExtendSendCount; // Maximum number of ids to include in an ack/nack/extend push RPC.
            private readonly int _maxConcurrentPush; // Mamimum number (slightly soft) of concurrent ack/nack/extend push RPCs.

            private readonly Flow _flow;
            private readonly AsyncAutoResetEvent _eventPush;
            private readonly AsyncSingleRecvQueue<TaskNextAction> _continuationQueue;
            private readonly ReQueue<TimedId> _extendQueue = new ReQueue<TimedId>();
            private readonly ReQueue<string> _ackQueue = new ReQueue<string>();
            private readonly ReQueue<string> _nackQueue = new ReQueue<string>();

            private int _pushInFlight = 0;
            private int _userHandlerInFlight = 0;
            private SubscriberServiceApiClient.StreamingPullStream _pull = null;
            private TimeSpan? _pullBackoff = null;
            private int _concurrentPushCount = 0;
            private bool _pullComplete = false;
            private long _extendThrottleHigh = 0; // Incremented on extension, and put on extend queue items.
            private long _extendThrottleLow = 0; // Incremented after _extendQueueThrottleInterval, checked when throttling.

            public async Task StartAsync()
            {
                // Start pull.
                StartStreamingPull();
                // Start push.
                HandlePush();
                // Start event loop.
                // This loop exits by an action throwing a error or cancellation exception.
                while (!IsComplete())
                {
                    // Wait for, then process next continuation.
                    TaskNextAction nextContinuation = await _taskHelper.ConfigureAwait(_continuationQueue.DequeueAsync());
                    // On hardstop just immediately stop this event loop.
                    // The registered-task code ensures that all currently-active tasks finish before
                    // return to user code.
                    if (_hardStopCts.IsCancellationRequested)
                    {
                        StopStreamingPull();
                        throw new OperationCanceledException();
                    }
                    var task = nextContinuation.Task;
                    var next = nextContinuation.NextAction;
                    if (next.IsPull && (task.IsCanceled || (task.IsFaulted && (task.Exception.IsCancellation() || task.Exception.IsRpcCancellation()))))
                    {
                        // Pull has been cancelled by user, shutdown pull stream and don't run continuation.
                        // RPC exceptions are dealt with in the relevant handlers.
                        StopStreamingPull();
                        // Pull process has been stopped, wait for push process to complete.
                        _pullComplete = true;
                    }
                    else
                    {
                        next.Action();
                    }
                }
                // Stop waiting for data to push.
                _pushStopCts.Cancel();
            }

            private bool IsComplete()
            {
                // extend-queue not included, as these have no effect after shutdown.
                // Lock required for ackQueue and nackQueue.
                lock (_lock)
                {
                    return _pullComplete && _ackQueue.Count == 0 && _nackQueue.Count == 0 && _pushInFlight == 0 && _userHandlerInFlight == 0;
                }
            }

            private NextAction Next(bool isPull, Action action) => new NextAction(isPull, action);

            private void Add(Task task, NextAction next)
            {
                _registerTaskFn(task);
                var taskNext = new TaskNextAction(task, next);
                task.ContinueWith(_ => _continuationQueue.Enqueue(taskNext),
                    CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, _taskHelper.TaskScheduler);
            }

            private void StopStreamingPull()
            {
                if (_pull != null)
                {
                    // Ignore all errors; the stream may be in any state.
                    try
                    {
                        _registerTaskFn(_pull.WriteCompleteAsync());
                    }
                    catch { }
                    _pull = null;
                }
            }

            // Open streaming-pull, and send initial request to start message stream.
            // If backoff is non-zero delay before opening streaming-pull.
            private void StartStreamingPull()
            {
                if (_pullBackoff is TimeSpan backoff)
                {
                    // Delay, then start the streaming-pull.
                    Task delayTask = _scheduler.Delay(backoff, _softStopCts.Token);
                    Add(delayTask, Next(true, HandleStartStreamingPullWithoutBackoff));
                }
                else
                {
                    HandleStartStreamingPullWithoutBackoff();
                }
            }

            // Open streaming-pull, and send initial request to start message stream.
            // Backoff delay (if present) has already been done; no need to delay here.
            private void HandleStartStreamingPullWithoutBackoff()
            {
                _pull = _client.StreamingPull(CallSettings.FromCancellationToken(_softStopCts.Token));
                // Cancellation not needed in this WriteAsync call. The StreamingPull() cancellation
                // (above) will cause this call to cancel if _softStopCts is cancelled.
                Task initTask = _pull.WriteAsync(new StreamingPullRequest
                {
                    SubscriptionAsSubscriptionName = _subscriptionName,
                    StreamAckDeadlineSeconds = _modifyDeadlineSeconds
                });
                Add(initTask, Next(true, () => HandlePullMoveNext(initTask)));
            }

            private bool HandleRpcFailure(Exception e)
            {
                if (e != null)
                {
                    if (e.As<RpcException>()?.IsRecoverable() ?? false)
                    {
                        // Recoverable RPC error, stop and restart pull.
                        StopStreamingPull();
                        // Increase backoff internal and start stream again.
                        // If stream-pull fails repeatly, increase the delay, up to a maximum of 30 seconds.
                        _pullBackoff = _pullBackoff is TimeSpan backoff ? TimeSpan.FromTicks(backoff.Ticks * 2) : TimeSpan.FromSeconds(0.5);
                        if (_pullBackoff.Value > TimeSpan.FromSeconds(30))
                        {
                            _pullBackoff = TimeSpan.FromSeconds(30);
                        }
                        StartStreamingPull();
                        return true;
                    }
                    else
                    {
                        // Unrecoverable error; throw it.
                        throw e.FlattenIfPossible();
                    }
                }
                return false;
            }

            // Pull-stream is ready; call MoveNext to wait for messages.
            private void HandlePullMoveNext(Task initTask)
            {
                // Check if the init write failed.
                if (initTask != null && HandleRpcFailure(initTask.Exception))
                {
                    return;
                }
                // Check if pulls need throttling due to push queues being too full, or too slow to push.
                bool throttle = _extendQueue.TryPeek(out var qItem) && _extendThrottleLow >= qItem.Time;
                if (!throttle)
                {
                    int totalQueueCount = _pushInFlight + _extendQueue.Count;
                    lock (_lock)
                    {
                        totalQueueCount += _ackQueue.Count + _nackQueue.Count;
                    }
                    throttle = totalQueueCount > _maxAckExtendQueueSize;
                }
                if (throttle)
                {
                    // Too many queued ack/nack/extend ids. Loop until the queue has drained a bit.
                    Add(_scheduler.Delay(TimeSpan.FromMilliseconds(100), _softStopCts.Token), Next(true, () => HandlePullMoveNext(null)));
                }
                else
                {
                    // Call MoveNext to receive more messages.
                    // Cancellation is handled by the cancellation-token passed when the stream is created.
                    var moveNextTask = _pull.ResponseStream.MoveNext(CancellationToken.None);
                    Add(moveNextTask, Next(true, () => HandlePullMessageData(moveNextTask)));
                }
            }

            // Message-stream has messages (or not, depending on moveNextResult)
            private void HandlePullMessageData(Task<bool> moveNextTask)
            {
                if (HandleRpcFailure(moveNextTask.Exception))
                {
                    return;
                }
                if (moveNextTask.Result)
                {
                    // Successful receive. Reset pull backoff to zero.
                    _pullBackoff = null;
                    // Copy msgs to list, and clear original proto repeatedfield; to remove refs to large messages as soon as possible.
                    // It is not possible to set RepeatedField elements to null, so messages need transfering to a List.
                    StreamingPullResponse current;
                    try
                    {
                        current = _pull.ResponseStream.Current;
                    }
                    catch (Exception e) when (e.As<RpcException>()?.IsRecoverable() ?? false)
                    {
                        HandleRpcFailure(e);
                        return;
                    }
                    var receivedMessages = current.ReceivedMessages;
                    var msgs = receivedMessages.ToList();
                    receivedMessages.Clear();
                    // Get all ack-ids, used to extend leases as required.
                    var msgIds = new HashSet<string>(msgs.Select(x => x.AckId));
                    // Send an initial "lease-extension"; which starts the server timer.
                    HandleExtendLease(msgIds);
                    // Asynchonously start message processing. Handles flow, and calls the user-supplied message handler.
                    // Uses Task.Run(), so not to clog up this "master" thread with per-message processing.
                    Task messagesTask = _taskHelper.Run(() => ProcessPullMessagesAsync(msgs, msgIds));
                    // Once all received messages have been queued for processing, read the stream for more messages.
                    Add(messagesTask, Next(true, () => HandlePullMoveNext(null)));
                }
                else
                {
                    StopStreamingPull();
                    // Always a short pause on server disconnect.
                    _pullBackoff = TimeSpan.FromSeconds(0.5);
                    StartStreamingPull();
                }
            }

            private async Task ProcessPullMessagesAsync(List<ReceivedMessage> msgs, HashSet<string> msgIds)
            {
                // Running async. Common data needs locking
                for (int msgIndex = 0; msgIndex < msgs.Count; msgIndex++)
                {
                    _softStopCts.Token.ThrowIfCancellationRequested();
                    var msg = msgs[msgIndex];
                    msgs[msgIndex] = null;
                    await _taskHelper.ConfigureAwait(_flow.Process(msg.CalculateSize(), async () =>
                    {
                            // Running async. Common data needs locking
                            lock (_lock)
                        {
                            _softStopCts.Token.ThrowIfCancellationRequested();
                            _userHandlerInFlight += 1;
                        }
                            // Call user message handler
                            var reply = await _taskHelper.ConfigureAwaitHideErrors(() => _handlerAsync(msg.Message, _hardStopCts.Token), Reply.Nack);
                            // Lock msgsIds, this is accessed concurrently here and in HandleExtendLease().
                            lock (msgIds)
                        {
                            msgIds.Remove(msg.AckId);
                        }
                            // Lock ack/nack-queues, this is accessed concurrently here and in "master" thread.
                            lock (_lock)
                        {
                            _userHandlerInFlight -= 1;
                            (reply == Reply.Ack ? _ackQueue : _nackQueue).Enqueue(msg.AckId);
                        }
                            // Ids have been added to ack/nack-queue, so trigger a push.
                            _eventPush.Set();
                    }));
                }
            }

            private void HandleExtendLease(HashSet<string> msgIds)
            {
                if (_softStopCts.IsCancellationRequested)
                {
                    // No further lease extensions once stop is requested.
                    return;
                }
                bool anyMsgIds;
                lock (msgIds)
                {
                    anyMsgIds = msgIds.Count > 0;
                    if (anyMsgIds)
                    {
                        lock (_lock)
                        {
                            // Only enqueue ack IDs that are not already being acked.
                            _extendQueue.Enqueue(msgIds.Select(x => new TimedId(_extendThrottleHigh + 1, x)));
                        }
                    }
                }
                if (anyMsgIds)
                {
                    // Ids have been added to _extendQueue, so trigger a push.
                    _eventPush.Set();
                    // Some ids still exist, schedule another extension.
                    Add(_scheduler.Delay(_autoExtendInterval, _softStopCts.Token), Next(false, () => HandleExtendLease(msgIds)));
                    // Increment _extendThrottles.
                    _extendThrottleHigh += 1;
                    Add(_scheduler.Delay(_extendQueueThrottleInterval, _softStopCts.Token), Next(false, () => _extendThrottleLow += 1));
                }
            }

            private void HandlePush()
            {
                // Always re-listen for push events.
                Add(_eventPush.WaitAsync(_pushStopCts.Token), Next(false, HandlePush));
                // Send data, if there is any to send.
                StartPush();
            }

            private void StartPush()
            {
                // Send data, if there is any to send.
                if (_concurrentPushCount >= _maxConcurrentPush)
                {
                    // Too many existing concurrent pushes; do nothing.
                    return;
                }
                List<string> acks;
                List<TimedId> extends;
                List<string> nacks;
                lock (_lock)
                {
                    // Priority of sending: Acks, Extends, Nacks.
                    // Allow 2 over _maxConcurrentPush, otherwise extend/nack queues could be unfairly penalized.
                    acks = _ackQueue.Dequeue(_maxAckExtendSendCount, null);
                    var ackSet = new HashSet<string>(acks);
                    extends = _extendQueue.Dequeue(_maxAckExtendSendCount, x => !ackSet.Contains(x.Id));
                    nacks = _nackQueue.Dequeue(_maxAckExtendSendCount, null);
                }
                if (acks.Count > 0)
                {
                    _pushInFlight += acks.Count;
                    _concurrentPushCount += 1;
                    Task ackTask = _client.AcknowledgeAsync(_subscriptionName, acks, _hardStopCts.Token);
                    Add(ackTask, Next(false, () => HandleAckResponse(ackTask, acks, null, null)));
                }
                if (extends.Count > 0)
                {
                    _pushInFlight += extends.Count;
                    _concurrentPushCount += 1;
                    Task extendTask = _client.ModifyAckDeadlineAsync(_subscriptionName, extends.Select(x => x.Id), _modifyDeadlineSeconds, _hardStopCts.Token);
                    Add(extendTask, Next(false, () => HandleAckResponse(extendTask, null, null, extends)));
                }
                if (nacks.Count > 0)
                {
                    _pushInFlight += nacks.Count;
                    _concurrentPushCount += 1;
                    Task nackTask = _client.ModifyAckDeadlineAsync(_subscriptionName, nacks, 0, _hardStopCts.Token);
                    Add(nackTask, Next(false, () => HandleAckResponse(nackTask, null, nacks, null)));
                }
            }

            private void HandleAckResponse(Task writeTask, List<string> ackIds, List<string> nackIds, List<TimedId> extendIds)
            {
                _concurrentPushCount -= 1;
                _pushInFlight -= ackIds?.Count ?? 0 + nackIds?.Count ?? 0 + extendIds?.Count ?? 0;
                if (writeTask.IsFaulted)
                {
                    if (writeTask.Exception.As<RpcException>()?.IsRecoverable() ?? false)
                    {
                        // Recoverable write error, requeue data and continue.
                        // ackIds and nackIds are never both set in the same call, so no need to share a lock.
                        if (ackIds != null && ackIds.Count > 0)
                        {
                            lock (_lock)
                            {
                                _ackQueue.Requeue(ackIds);
                            }
                        }
                        if (nackIds != null && nackIds.Count > 0)
                        {
                            lock (_lock)
                            {
                                _nackQueue.Requeue(nackIds);
                            }
                        }
                        if (extendIds != null && extendIds.Count > 0)
                        {
                            _extendQueue.Requeue(extendIds);
                        }
                        // TODO: Backoff
                    }
                    else
                    {
                        // Unrecoverable error; throw exception.
                        throw writeTask.Exception.FlattenIfPossible();
                    }
                }
                // Immediately send more data if there is any to send.
                StartPush();
            }
        }
    }
}
