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
using Google.Cloud.Spanner.Common.V1;
using Grpc.Core;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Spanner.V1.TransactionOptions;

namespace Google.Cloud.Spanner.V1.PoolRewrite
{
    public partial class SessionPool
    {
        // Note: Internal for test purposes.
        internal sealed class TargetedSessionPool : SessionPoolBase
        {
            private static readonly TransactionOptions s_readWriteOptions = new TransactionOptions { ReadWrite = new TransactionOptions.Types.ReadWrite() };

            // Read-only state
            private readonly object _lock = new object();
            private readonly DatabaseName _databaseName;
            private readonly CreateSessionRequest _createSessionRequest;

            // Mutable state, which should be accessed within the lock

            // TODO: Use linked lists instead?
            private readonly ConcurrentQueue<PooledSession> _readOnlySessions = new ConcurrentQueue<PooledSession>();
            private readonly ConcurrentQueue<PooledSession> _readWriteSessions = new ConcurrentQueue<PooledSession>();
            private readonly ConcurrentQueue<TaskCompletionSource<PooledSession>> _pendingAcquisitions =
                new ConcurrentQueue<TaskCompletionSource<PooledSession>>();

            // Tasks waiting for the pool to reach its minimum size or become unhealthy.
            private readonly LinkedList<TaskCompletionSource<int>> _minimumSizeWaiters = new LinkedList<TaskCompletionSource<int>>();

            // Assume the pool is healthy to start with.
            private int _healthy = 1;
            private bool Healthy => Interlocked.CompareExchange(ref _healthy, 0, 0) == 1;

            // The task (completion source) associated with shutting down the session pool, if any.
            // Note that this task has no cancellation token associated with it, even if the original call did.
            private TaskCompletionSource<int> _shutdownTask = null;
            private bool Shutdown => Interlocked.CompareExchange(ref _shutdownTask, null, null) != null;

            /// <summary>
            /// The difference between "acquire" and "release" calls, including pending "acquire" calls. Not guarded by the lock,
            /// but should be modified using Interlocked and accessed via the property.
            /// </summary>
            private int _activeSessionCount;

            /// <summary>
            /// The number of sessions we're currently trying to create. Not guarded by the lock, but should be accessed using Interlocked.
            /// </summary>
            private int _inFlightSessionCreationCount;

            /// <summary>
            /// Thread-safe read-only access to active session count.
            /// </summary>
            internal int ActiveSessionCount => Interlocked.CompareExchange(ref _activeSessionCount, 0, 0);

            /// <summary>
            /// Thread-safe read-only access to in-flight session creation count.
            /// </summary>
            internal int InFlightSessionCreationCount => Interlocked.CompareExchange(ref _inFlightSessionCreationCount, 0, 0);

            // Statistics maintained purely for diagnostic purposes. This lets us evaluate
            // how effective transaction pre-warming is.
            private long _rwTransactionRequests;
            private long _rwTransactionRequestsPrewarmed;

            internal TargetedSessionPool(SessionPool parent, DatabaseName databaseName, bool acquireSessionsImmediately) : base(parent)
            {
                _databaseName = GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
                _createSessionRequest = new CreateSessionRequest { DatabaseAsDatabaseName = databaseName };
                if (acquireSessionsImmediately)
                {
                    StartAcquisitionTasksIfNecessary(0);
                }
            }

            public async Task<PooledSession> AcquireSessionAsync(TransactionOptions transactionOptions, CancellationToken cancellationToken)
            {
                bool success = false;
                try
                {
                    int sessionCount = Interlocked.Increment(ref _activeSessionCount);
                    if (sessionCount > Options.MaximumActiveSessions && Options.WaitOnResourcesExhausted == ResourcesExhaustedBehavior.Fail)
                    {
                        // Not really an RpcException, but the cleanest way of representing it.
                        // (The ADO.NET provider will convert it to a SpannerException with the same code.)
                        throw new RpcException(new Status(StatusCode.ResourceExhausted, "Local maximum number of active sessions exceeded."));
                    }

                    // We pass in the "session count before we incremented" so that we can still start a new session creation task if necessary.
                    // (For example, if the maximum number of sessions is 100, and sessionCount==100, that means it *was* 99, so we're still okay
                    // to create a new session.)
                    PooledSession session = await AcquireSessionImplAsync(sessionCount - 1, transactionOptions, cancellationToken).ConfigureAwait(false);
                    success = true;
                    return session;
                }
                finally
                {
                    if (!success)
                    {
                        Interlocked.Decrement(ref _activeSessionCount);
                    }
                }
            }

            private async Task<PooledSession> AcquireSessionImplAsync(int logicalActiveSessionCount, TransactionOptions transactionOptions, CancellationToken cancellationToken)
            {
                var transactionMode = transactionOptions?.ModeCase ?? ModeOneofCase.None;
                var sessionAcquisitionTask = GetSessionAcquisitionTask(transactionMode, cancellationToken);

                // We've either fetched a task from the pool, or registered that a caller is waiting for one.
                // We may want to start creation tasks, either to replenish the pool or (if there were no pool entries)
                // to make sure that there's something creating a session for us. If the logical active session count is greater
                // than or equal to the maximum, this won't start anything.
                StartAcquisitionTasksIfNecessary(logicalActiveSessionCount);

                var session = await sessionAcquisitionTask.ConfigureAwait(false);

                // Note: deliberately no test for refresh or eviction.
                // We do this when a session is released, and in the maintenance task.
                // These happen frequently enough that we shouldn't need to worry about them here.

                // Update statistics for prewarming - only after we've already acquired the session.
                if (transactionMode == ModeOneofCase.ReadWrite)
                {
                    Interlocked.Increment(ref _rwTransactionRequests);
                    if (session.TransactionMode == transactionMode)
                    {
                        Interlocked.Increment(ref _rwTransactionRequestsPrewarmed);
                    }
                }

                // If we've already got the right transaction mode, we're done.
                if (session.TransactionMode == transactionMode)
                {
                    return session;
                }
                // Otherwise, we may need to forget an existing transaction, or request a new one.
                else
                {
                    // If we asked for a session with no transaction but we got one *with* a tranasction,
                    // we don't need to perform any RPCs - but we do need to return a PooledSession with
                    // no transaction ID.
                    if (transactionMode == ModeOneofCase.None)
                    {
                        return session.WithTransaction(null, ModeOneofCase.None);
                    }
                    else
                    {
                        bool success = false;
                        try
                        {
                            session = await BeginTransactionAsync(session, transactionOptions, cancellationToken).ConfigureAwait(false);
                            success = true;
                            return session;
                        }
                        finally
                        {
                            // If we succeeded in getting a session but not a transaction, we can reuse the session later, but still fail this call.
                            // It counts as "inactive" because the failure will decrement the active session count already.
                            // Note that the only way success is false is if we're throwing an exception, so we'll never release it
                            // *and* then return it.
                            if (!success)
                            {
                                ReleaseInactiveSession(session, maybeCreateReadWriteTransaction: false);
                            }
                        }
                    }
                }
            }

            private Task<PooledSession> GetSessionAcquisitionTask(ModeOneofCase transactionMode, CancellationToken cancellationToken)
            {
                // Three scenarios for initial session picking:
                // - No transaction options: take a read-only session as-is
                // - Read/write transaction options: take a read/write session as-is
                // - Other options (a non-single-use read-only bound, or PDML): take a read-only session, but fetch a transaction with it before returning it.
                // If there's no session of the appropriate type, take the other kind instead - at the cost of either wasting an existing read/write
                // transaction, or having to acquire a read/write transaction.
                ConcurrentQueue<PooledSession> preferredQueue = _readOnlySessions;
                ConcurrentQueue<PooledSession> alternateQueue = _readWriteSessions;
                if (transactionMode == ModeOneofCase.ReadWrite)
                {
                    preferredQueue = _readWriteSessions;
                    alternateQueue = _readOnlySessions;
                }
                lock (_lock)
                {
                    // FIXME: Is this the right place to check for shutdown? We need a test of:
                    // - Create pool and populate it
                    // - Shut pool down (and wait for that to finish)
                    // - Try to acquire a session (should fail)

                    // First try the pool.
                    if (preferredQueue.TryDequeue(out var session) || alternateQueue.TryDequeue(out session))
                    {
                        // Slight inefficiency wrapping this in a task, but it makes the implementation simpler.
                        return Task.FromResult(session);
                    }

                    // No pool entries.
                    // If the pool is currently healthy, register a TCS in the queue that will be checked by incoming sessions.
                    if (Healthy)
                    {
                        TaskCompletionSource<PooledSession> receivingTcs = new TaskCompletionSource<PooledSession>();
                        _pendingAcquisitions.Enqueue(receivingTcs);
                        return TcsWithCancellationToken(receivingTcs, cancellationToken);
                    }
                    else
                    {
                        // Otherwise, drop out of the lock to create a session from scratch "inline" (still asynchronously, but not via an in-flight request).
                    }
                }
                // Effectively the "else" block above, but outside the lock
                return CreatePooledSessionAsync(cancellationToken);
            }

            /// <summary>
            /// Release a session back to the pool (or refresh) but don't change the number of active sessions.
            /// </summary>
            /// <param name="session">The session to queue. Should be "active" (i.e. not disposed)</param>
            /// <param name="maybeCreateReadWriteTransaction">Whether to allow the session to go through a cycle of acquiring a read/write transaction.
            /// This is true unless we've just come from attempting to create a read/write transaction, in which case either we succeeded (no need
            /// to create a new one) or failed (in which case we should just keep it read-only).
            /// </param>
            private void ReleaseInactiveSession(PooledSession session, bool maybeCreateReadWriteTransaction)
            {
                if (Shutdown)
                {
                    Parent.DeleteSessionFireAndForget(session);
                    return;
                }

                if (session.RequiresRefresh)
                {
                    // RefreshAsync will then release the refreshed session itself - which
                    // may trigger a transaction request as well. But eventually, it'll get
                    // back to the pool (or a waiting consumer).
                    Parent.ConsumeBackgroundTask(RefreshAsync(session), "session refresh");
                    return;
                }

                // There are a couple of cases where we need to take an action outside the lock after breaking
                // out of the loop. It's simplest to remember that in a delegate.
                Action outsideLockAction = null;

                // We need to atomically (within the lock) decide between:
                // - Adding the session to a pool queue (adding performed within the lock)
                // - Providing the session to a waiting caller (setting the result peformed outside the lock)
                // - If it's currently not got a transaction but we need more read/write transactions, starting a transaction
                // In the last case, we will come back to this code to make another decision later.
                while (true)
                {
                    TaskCompletionSource<PooledSession> pendingAquisition;
                    lock (_lock)
                    {
                        // Only add a session to a queue if there are no pending acquisitions.
                        if (!_pendingAcquisitions.TryDequeue(out pendingAquisition))
                        {
                            // Options:
                            // - Decide to create a new read/write transaction (will get back here later)
                            // - Enqueue the current session as read-only or read/write depending on its mode
                            ConcurrentQueue<PooledSession> queue;

                            // If the session already has a read/write transaction, add it to the read/write pool immediately.
                            // Otherwise, work out whether we *want* it to be read/write.
                            if (session.TransactionMode == ModeOneofCase.ReadWrite)
                            {
                                queue = _readWriteSessions;
                            }
                            else
                            {
                                var readCount = _readOnlySessions.Count;
                                var writeCount = _readWriteSessions.Count;
                                // Avoid division by zero by including the new session in the denominator.
                                var writeProportion = writeCount / (writeCount + readCount + 1.0);
                                bool createReadWriteTransaction = maybeCreateReadWriteTransaction && writeProportion < Options.WriteSessionsFraction;
                                if (createReadWriteTransaction)
                                {
                                    // Exit the loop, and acquire a read/write transaction
                                    outsideLockAction = () => Parent.ConsumeBackgroundTask(TryCreateReadWriteTransactionAndReturnToPool(session), "transaction creation");
                                    break;
                                }
                                else
                                {
                                    // At this point we didn't already have a r/w transaction, and we don't want to
                                    // create one, so add it to the pool of read-only sessions.
                                    queue = _readOnlySessions;
                                }
                            }
                            // We definitely have a queue now, so add the session to it, and
                            // potentially release tasks waiting for the pool to reach minimum size.
                            queue.Enqueue(session);

                            int poolSize = _readOnlySessions.Count + _readWriteSessions.Count;
                            if (poolSize >= Options.MinimumPooledSessions && _minimumSizeWaiters.Count > 0)
                            {
                                var minimumSizeWaiters = _minimumSizeWaiters.ToList();
                                outsideLockAction = () => minimumSizeWaiters.ForEach(tcs => tcs.TrySetResult(0));
                            }
                            break;
                        }
                    }

                    // We perform TrySetResult outside the lock, to avoid executing any synchronous continuations inside the lock.
                    if (pendingAquisition.TrySetResult(session))
                    {
                        return;
                    }
                    // The task had been cancelled by the caller. Go round the loop again. (There may or may not be more pending acquisitions.)
                }

                // If we've got anything to execute outside the lock, do so now.
                outsideLockAction?.Invoke();
            }

            /// <summary>
            /// Refreshes a session by setting executing a trivial SELECT SQL statement.
            /// This is performed via the client session itself so it can update its next refresh time.
            /// </summary>
            private async Task RefreshAsync(PooledSession session)
            {
                // While we're refreshing a session, it's as if we're creating a new one - it's a period of time
                // where there's already an RPC in flight, and when it completes a session will be available.
                Interlocked.Increment(ref _inFlightSessionCreationCount);
                try
                {
                    await session.ExecuteSqlAsync(new ExecuteSqlRequest { Sql = "SELECT 1" }, Options.Timeout, CancellationToken.None).ConfigureAwait(false);
                }
                catch (RpcException e)
                {
                    Parent._logger.Warn("Failed to refresh session. Session will be deleted.", e);
                    Parent.DeleteSessionFireAndForget(session);
                    return;
                }
                finally
                {
                    Interlocked.Decrement(ref _inFlightSessionCreationCount);
                }
                // We now definitely don't have a transaction.
                ReleaseInactiveSession(session.WithTransaction(null, ModeOneofCase.None), maybeCreateReadWriteTransaction: true);
            }

            private async Task TryCreateReadWriteTransactionAndReturnToPool(PooledSession session)
            {
                try
                {
                    session = await BeginTransactionAsync(session, s_readWriteOptions, CancellationToken.None).ConfigureAwait(false);
                }
                catch (RpcException e)
                {
                    // Failed to create a read/write transaction; release this back to the pool, but making
                    // sure we don't come back here.
                    Parent._logger.Warn("Failed to create read/write transaction for pooled session", e);
                }
                ReleaseInactiveSession(session, maybeCreateReadWriteTransaction: false);
            }

            private async Task<PooledSession> BeginTransactionAsync(PooledSession session, TransactionOptions options, CancellationToken cancellationToken)
            {
                // While we're creating a transaction, it's as if we're preparing a new session - it's a period of time
                // where there's already an RPC in flight, and when it completes a session will be available.
                Interlocked.Increment(ref _inFlightSessionCreationCount);
                var request = new BeginTransactionRequest { Options = options };
                try
                {
                    var transaction = await session.BeginTransactionAsync(request, Options.Timeout, cancellationToken).ConfigureAwait(false);
                    return session.WithTransaction(transaction.Id, options.ModeCase);
                }
                finally
                {
                    Interlocked.Decrement(ref _inFlightSessionCreationCount);
                }
            }

            /// <summary>
            /// Release a session back to the pool (or refresh or evict it) and decrement the number of active sessions.
            /// </summary>
            public override void Release(PooledSession session, bool deleteSession)
            {
                Interlocked.Decrement(ref _activeSessionCount);
                if (deleteSession)
                {
                    Parent.DeleteSessionFireAndForget(session);
                }
                else
                {
                    ReleaseInactiveSession(session, maybeCreateReadWriteTransaction: true);
                }
            }

            internal void MaintainPool()
            {
                if (Shutdown)
                {
                    return;
                }
                EvictAndRefreshSessions();
                StartAcquisitionTasksIfNecessary(ActiveSessionCount);
                Parent._logger.Debug(() => $"After maintenance: {GetStatisticsSnapshot()}");
            }

            private void EvictAndRefreshSessions()
            {
                LinkedList<PooledSession> sessionsToEvict = new LinkedList<PooledSession>();
                LinkedList<PooledSession> staleSessions = new LinkedList<PooledSession>();
                lock (_lock)
                {
                    RemoveStaleOrExpiredItemsFromQueue(_readOnlySessions);
                    RemoveStaleOrExpiredItemsFromQueue(_readWriteSessions);
                }

                foreach (var session in sessionsToEvict)
                {
                    Parent.DeleteSessionFireAndForget(session);
                }
                foreach (var session in staleSessions)
                {
                    Parent.ConsumeBackgroundTask(RefreshAsync(session), "session refresh");
                }

                void RemoveStaleOrExpiredItemsFromQueue(ConcurrentQueue<PooledSession> queue)
                {
                    int count = queue.Count;
                    for (int i = 0; i < count; i++)
                    {
                        // This shouldn't happen, as nothing else should touch the queue while we're in a
                        // lock, but we don't want to throw an exception
                        if (!queue.TryDequeue(out var session))
                        {
                            break;
                        }
                        if (session.ShouldBeEvicted)
                        {
                            sessionsToEvict.AddLast(session);
                        }
                        else if (session.RequiresRefresh)
                        {
                            staleSessions.AddLast(session);
                        }
                        else
                        {
                            // The session is fine - put it back on the queue.
                            queue.Enqueue(session);
                        }
                    }
                }
            }

            /// <summary>
            /// Starts tasks to create new sessions if that's necessary to get the pool to a minimum size or to
            /// service queued callers. It's possible that we'll end up with more sessions than we want or need
            /// if an active request calls this at exactly the same time as the maintenance task, but that's not too
            /// bad.
            /// </summary>
            /// <remarks>
            /// This method accepts a "logical active session count" which allows a call to AcquireSessionAsync
            /// to pass in the number of sessions that were active when the call started, as part of incrementing it.
            /// This allows the final call to still be able to acquire a session, without allowing flooding due to lots of
            /// simultaneous calls. We can still end up with too many sessions if a background task calls this method and
            /// works out that it's okay to create a new session, at "roughly the same time" as an acquisition call is made
            /// which guarantees its place. We can be more precise than this using a semaphore, but this is probably simpler.
            /// </remarks>
            private void StartAcquisitionTasksIfNecessary(int logicalActiveSessionCount)
            {
                if (!Healthy || Shutdown)
                {
                    return;
                }

                // Take snapshots of all values to be consistent.
                int minPoolSize;
                int maxActiveSessions;
                int poolSize;
                int pendingAcquisitionCount;
                int inFlightRequests;
                lock (_lock)
                {
                    poolSize = _readWriteSessions.Count + _readOnlySessions.Count;
                    inFlightRequests = InFlightSessionCreationCount;
                    pendingAcquisitionCount = _pendingAcquisitions.Count;
                    minPoolSize = Options.MinimumPooledSessions;
                    maxActiveSessions = Options.MaximumActiveSessions;
                }

                // Determine how many more requests to start.
                // We want to make sure that if all existing and new requests succeed:
                // - All queuing callers will have a session
                // - The pool will have at least as many entries the options specify
                // However, we don't want to end up with more than the maximum number of active sessions
                // in the options.

                // In reality, the current pool size should be 0 if pendingAcquisitionCount is non-zero, and
                // vice versa. However, we don't strictly enforce this, and the maths works out more simply if
                // we don't worry about it.

                // How many more requests do we need to make in order to get the pool to the minimum size, after satisfying
                // pending callers, assuming that all the in-flight requests succeed, and there are no more requests?
                int newRequestsToSatisfyPool = (pendingAcquisitionCount + minPoolSize) - (poolSize + inFlightRequests);
                // How many more requests *can* we make without going over the maximum number of active sessions?
                int maxAvailableRequests = maxActiveSessions - (logicalActiveSessionCount + poolSize + inFlightRequests);

                int actualNewRequests = Math.Min(newRequestsToSatisfyPool, maxAvailableRequests);
                for (int i = 0; i < actualNewRequests; i++)
                {
                    Parent.ConsumeBackgroundTask(PrepareNewSessionAsync(), "session creation");
                }

                async Task PrepareNewSessionAsync()
                {
                    try
                    {
                        var session = await CreatePooledSessionAsync(CancellationToken.None).ConfigureAwait(false);
                        ReleaseInactiveSession(session, maybeCreateReadWriteTransaction: true);
                    }
                    // Note: we expect this to always actually be an RpcException, but we don't want to end up unhealthy
                    // with a lot of 
                    catch (Exception e)
                    {
                        Parent._logger.Warn(() => $"Failed to create session for {_databaseName}", e);

                        // CreatePooledSessionAsync will have caused the session pool to become unhealthy already, so we shouldn't get
                        // any new waiting callers at this point. 
                        // Propagate this exception to all waiting callers.
                        List<TaskCompletionSource<PooledSession>> pendingAcquisitionsList = new List<TaskCompletionSource<PooledSession>>();
                        List<TaskCompletionSource<int>> minimumSizeWaiters;
                        lock (_lock)
                        {
                            // Don't set the exception in the lock.
                            while (_pendingAcquisitions.TryDequeue(out var acquisition))
                            {
                                pendingAcquisitionsList.Add(acquisition);
                            }
                            minimumSizeWaiters = _minimumSizeWaiters.ToList();
                        }
                        // TODO: Is this too drastic, just for a single failure?
                        pendingAcquisitionsList.ForEach(tcs => tcs.TrySetException(e));
                        minimumSizeWaiters.ForEach(tcs => tcs.TrySetException(e));
                    }
                }
            }

            private async Task<PooledSession> CreatePooledSessionAsync(CancellationToken cancellationToken)
            {
                bool success = false;
                bool canceled = false;
                Interlocked.Increment(ref _inFlightSessionCreationCount);
                try
                {
                    var callSettings = Client.Settings.CreateSessionSettings
                        .WithExpiration(Client.Settings.ConvertTimeoutToExpiration(Options.Timeout))
                        .WithCancellationToken(cancellationToken);
                    Session sessionProto;

                    bool acquiredSemaphore = false;
                    try
                    {
                        await Parent._sessionAcquisitionSemaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
                        acquiredSemaphore = true;
                        sessionProto = await Client.CreateSessionAsync(_createSessionRequest, callSettings).ConfigureAwait(false);
                        success = true;
                        return PooledSession.FromSessionName(this, sessionProto.SessionName);
                    }
                    catch (OperationCanceledException)
                    {
                        canceled = true;
                        throw;
                    }
                    finally
                    {
                        if (acquiredSemaphore)
                        {
                            Parent._sessionAcquisitionSemaphore.Release();
                        }
                    }
                }
                finally
                {
                    // Atomically set _healthy and determine whether we were previously healthy, but only if either we've succeeded,
                    // or we failed for a reason other than cancellation. We don't want to go unhealthy just because a caller cancelled
                    // a cancellation token before we had chance to create the session.
                    if (success || !canceled)
                    {
                        bool wasHealthy = Interlocked.Exchange(ref _healthy, success ? 1 : 0) == 1;
                        if (wasHealthy != success)
                        {
                            Parent._logger.Info(() => $"Session pool for {_databaseName} is now {(success ? "healthy" : "unhealthy")}.");
                        }
                    }
                    Interlocked.Decrement(ref _inFlightSessionCreationCount);
                }
            }

            internal DatabaseStatistics GetStatisticsSnapshot()
            {
                lock (_lock)
                {
                    return new DatabaseStatistics(
                        _databaseName,
                        ActiveSessionCount,
                        _readOnlySessions.Count,
                        _readWriteSessions.Count,
                        InFlightSessionCreationCount,
                        _pendingAcquisitions.Count,
                        Interlocked.CompareExchange(ref _rwTransactionRequests, 0L, 0L),
                        Interlocked.CompareExchange(ref _rwTransactionRequestsPrewarmed, 0L, 0L),
                        Healthy,
                        Shutdown);
                }
            }            
        }
    }
}
