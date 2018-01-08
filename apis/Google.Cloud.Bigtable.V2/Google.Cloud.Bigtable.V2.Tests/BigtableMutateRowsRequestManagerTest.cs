﻿// Copyright 2017 Google Inc. All rights reserved.
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

using System.Collections.Generic;
using System.Linq;
using Grpc.Core;
using System;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    /// <summary>
    /// Test for <see cref="BigtableMutateRowsRequestManager"/>.
    /// </summary>
    public class BigtableMutateRowsRequestManagerTest
    {
        /// <summary>
        /// <see cref="Rpc.Status"/> that indicates that requested mutation succeded.
        /// </summary>
        private static Rpc.Status Ok =>
            new Rpc.Status { Code = (int)StatusCode.OK };

        /// <summary>
        /// <see cref="Rpc.Status"/> that indicates that requested mutation failed, the mutation should be retried.
        /// </summary>
        private static Rpc.Status DeadlineExceeded =>
            new Rpc.Status { Code = (int)StatusCode.DeadlineExceeded };

        /// <summary>
        /// <see cref="Rpc.Status"/> that indicates that requested mutation failed, the mutation should not be retried.
        /// </summary>
        private static Rpc.Status NotFound =>
            new Rpc.Status { Code = (int)StatusCode.NotFound };

        private static List<T> Fill<T>(T value, int size) => Enumerable.Repeat(value, size).ToList();

        /// <summary>
        /// Creates <see cref="MutateRowsRequest"/> for test purposes to use with MutateRows.
        /// </summary>
        /// <param name="entryCount">
        /// Integer represents count of entries to be created in <see cref="MutateRowsRequest"/>.</param>
        /// <returns>MutateRowsRequest.</returns>
        private static MutateRowsRequest CreateRequest(int entryCount) => new MutateRowsRequest
        {
            Entries =
            {
                Enumerable.Range(0, entryCount).Select(i =>
                    Mutations.CreateEntry("Row" + i, Mutations.SetCell("Family" + i, default, default)))
            }
        };

        /// <summary>
        /// Creates new <see cref="MutateRowsRequest"/> with entries that came with failed-retryable <see cref="Rpc.Status"/> to use with MutateRows.
        /// </summary>
        /// <param name="original">
        /// The original <see cref="MutateRowsRequest"/> that was initially sent to Bigtable via MutateRows.</param>
        /// <param name="indices">
        /// Array of mutations indices from the original <see cref="MutateRowsRequest"/> that need to be retried.</param>
        /// <returns>New MutateRowsRequest.</returns>
        private static MutateRowsRequest CreateRetryRequest(MutateRowsRequest original, params int[] indices) =>
            new MutateRowsRequest
            {
                Entries = { indices.Select(i => original.Entries[i]) }
            };

        /// <summary>
        /// Builds a <see cref="MutateRowsResponse"/> message to be returned to user.
        /// </summary>
        /// <param name="statuses"> 
        /// Array that holds results of all <see cref="MutateRowsRequest"/> Entries.
        /// </param>
        /// <returns></returns>
        private static MutateRowsResponse CreateResponse(params Rpc.Status[] statuses) => new MutateRowsResponse
        {
            Entries = { statuses.Select((status, i) => ToEntry(i, status)) }
        };

        /// <summary>
        /// Builds a <see cref="MutateRowsResponse.Types.Entry"/>. 
        /// </summary>
        /// <param name="i">
        /// Integer that represents an index of an <see cref="MutateRowsResponse.Types.Entry"/>.</param>
        /// <param name="status">
        /// <see cref="Rpc.Status"/> that indicates whether requested mutation succeeded or not.</param>
        /// <returns>Entry for MutateRowsResponse message.</returns>
        private static MutateRowsResponse.Types.Entry ToEntry(int i, Rpc.Status status) =>
            new MutateRowsResponse.Types.Entry { Index = i, Status = status };

        /// <summary>
        /// Sends <see cref="MutateRowsResponse"/> message to <see cref="BigtableMutateRowsRequestManager"/> 
        /// and requests back <see cref="BigtableMutateRowsRequestManager.ProcessingStatus"/> based on the message sent.
        /// </summary>
        /// <param name="underTest">
        /// An object of <see cref="BigtableMutateRowsRequestManager"/> class that is being tested</param>
        /// <param name="response">,
        /// A <see cref="MutateRowsResponse"/> message</param>
        /// <returns>ProcessingStatus - Retryable, NotRetryable, Invalid.</returns>
        private static BigtableMutateRowsRequestManager.ProcessingStatus Send(
            BigtableMutateRowsRequestManager underTest, MutateRowsResponse response)
        {
            underTest.SetStatus(response);
            return underTest.OnOk();
        }

        /// <summary>
        /// Array that holds statuses to retry on.
        /// </summary>
        private readonly StatusCode[] _retryStatuses = { StatusCode.DeadlineExceeded };

        /// <summary>
        /// An empty request should return an empty response.
        /// </summary>
        [Fact]
        public void TestEmptySuccess()
        {
            BigtableMutateRowsRequestManager underTest =
                new BigtableMutateRowsRequestManager(_retryStatuses, CreateRequest(0));

            Send(underTest, CreateResponse());
            Assert.Equal(CreateResponse(), underTest.BuildResponse());
        }

        /// <summary>
        /// A single successful entry should work.
        /// </summary>
        [Fact]
        public void TestSingleSuccess()
        {
            BigtableMutateRowsRequestManager underTest =
                new BigtableMutateRowsRequestManager(_retryStatuses, CreateRequest(1));

            Send(underTest, CreateResponse(Ok));
            Assert.Equal(CreateResponse(Ok), underTest.BuildResponse());
        }

        /// <summary>
        /// Two individual calls with one retry should work.
        /// </summary>
        [Fact]
        public void TestTwoTrySuccessOneFailure()
        {
            MutateRowsRequest originalRequest = CreateRequest(3);
            BigtableMutateRowsRequestManager underTest =
                new BigtableMutateRowsRequestManager(_retryStatuses, originalRequest);

            Send(underTest, CreateResponse(Ok, DeadlineExceeded, Ok));
            Assert.Equal(CreateRetryRequest(originalRequest, 1), underTest.RetryRequest);
            Assert.Equal(CreateResponse(Ok, DeadlineExceeded, Ok), underTest.BuildResponse());

            Send(underTest, CreateResponse(Ok));
            Assert.Null(underTest.RetryRequest);
            Assert.Equal(CreateResponse(Ok, Ok, Ok), underTest.BuildResponse());
        }

        /// <summary>
        /// Two individual calls in a more complicated case with one retry should work.
        /// </summary>
        [Fact]
        public void TestMultiSuccess()
        {
            MutateRowsRequest originalRequest = CreateRequest(10);
            BigtableMutateRowsRequestManager underTest =
                new BigtableMutateRowsRequestManager(_retryStatuses, originalRequest);

            // 5 mutations succeed, 5 mutations are retryable.
            MutateRowsResponse firstResponse = CreateResponse(Ok, DeadlineExceeded, Ok, DeadlineExceeded,
                Ok, DeadlineExceeded, Ok, DeadlineExceeded, Ok, DeadlineExceeded);
            Send(underTest, firstResponse);
            Assert.Equal(CreateRetryRequest(originalRequest, 1, 3, 5, 7, 9), underTest.RetryRequest);
            Assert.Equal(firstResponse, underTest.BuildResponse());

            // 3 mutations succeed, 2 mutations are retryable.
            Send(underTest, CreateResponse(Ok, DeadlineExceeded, Ok, Ok, DeadlineExceeded));
            Assert.Equal(CreateRetryRequest(originalRequest, 3, 9), underTest.RetryRequest);
            MutateRowsResponse secondResponse = CreateResponse(Ok, Ok, Ok, DeadlineExceeded,
                Ok, Ok, Ok, Ok, Ok, DeadlineExceeded);
            Assert.Equal(secondResponse, underTest.BuildResponse());

            // The final 2 mutations are OK
            Send(underTest, CreateResponse(Ok, Ok));
            Assert.Null(underTest.RetryRequest);
            Assert.Equal(CreateResponse(Ok, Ok, Ok, Ok, Ok, Ok, Ok, Ok, Ok, Ok),
                underTest.BuildResponse());
        }

        /// <summary>
        /// Multiple attempts at retries should work as expected. 10 mutations are added, and 1 gets an OK
        /// status for 9 rounds until 1 mutation is left.Each success shows up in a random location.
        /// </summary>
        [Fact]
        public void TestMultiAttempt()
        {
            const int RequestCount = 10;
            int seed = Environment.TickCount;
            Random rand = new Random(seed);
            MutateRowsRequest originalRequest = CreateRequest(RequestCount);
            BigtableMutateRowsRequestManager underTest =
                new BigtableMutateRowsRequestManager(_retryStatuses, originalRequest);

            // At the beginning, all mutations are outstanding.
            List<int> remaining = Enumerable.Range(0, RequestCount).ToList();

            // Create a List<Status> filled with DeadlineExceeded.
            List<Rpc.Status> statuses = Fill(DeadlineExceeded, originalRequest.Entries.Count);

            for (int i = 0; i < RequestCount - 1; i++)
            {
                int remainingMutationCount = remaining.Count;

                // Randomly choose a successfull mutation.
                int successIndex = rand.Next(remainingMutationCount);

                // Set the index of ramdom mutation to success.
                statuses[successIndex] = Ok;

                // The successful status can now be removed.
                remaining.RemoveAt(successIndex);

                // Make sure that the request is retryable, and that the retry request looks reasonable.
                Assert.True(BigtableMutateRowsRequestManager.ProcessingStatus.Retryable.Equals
                    (Send(underTest, CreateResponse(statuses.ToArray()))), $"Seed value is {seed} ");
                Assert.True(CreateRetryRequest(originalRequest, remaining.ToArray()).Equals(underTest.RetryRequest), $"Seed value is {seed} ");

                // Remove Successful status from statuses.
                statuses.RemoveAt(successIndex);
            }

            // Only one Mutation should be outstanding at this point. Create a response that has all Oks,
            // with the exception of the remaining statuses.
            statuses = Fill(Ok, originalRequest.Entries.Count);
            statuses[remaining[0]] = DeadlineExceeded;

            Assert.Equal(CreateResponse(statuses.ToArray()), underTest.BuildResponse());
        }

        /// <summary>
        /// Processing status should return NotRetryable if even a single response is not retryable.
        /// </summary>
        [Fact]
        public void TestNotRetryable()
        {
            BigtableMutateRowsRequestManager underTest =
                new BigtableMutateRowsRequestManager(_retryStatuses, CreateRequest(3));

            Assert.Equal(BigtableMutateRowsRequestManager.ProcessingStatus.NotRetryable,
                Send(underTest, CreateResponse(Ok, Ok, NotFound)));
            Assert.Equal(CreateResponse(Ok, Ok, NotFound), underTest.BuildResponse());
            Assert.Null(underTest.RetryRequest);
        }

        /// <summary>
        /// Two calls, retry call has one of the resonses with non-retryable status.
        /// In this case we should not retry, RetryRequest should be null. 
        /// </summary>
        [Fact]
        public void TestTwoTryPartialFailNotRetryable()
        {
            MutateRowsRequest originalRequest = CreateRequest(4);
            BigtableMutateRowsRequestManager underTest =
                new BigtableMutateRowsRequestManager(_retryStatuses, originalRequest);

            Send(underTest, CreateResponse(Ok, Ok, DeadlineExceeded, DeadlineExceeded));
            Assert.Equal(CreateRetryRequest(originalRequest, 2, 3), underTest.RetryRequest);
            Assert.Equal(CreateResponse(Ok, Ok, DeadlineExceeded, DeadlineExceeded), underTest.BuildResponse());

            Send(underTest, CreateResponse(DeadlineExceeded, NotFound));
            // Don't retry if even a single response is not retryable.
            // RetryRequest should be null.
            Assert.Null(underTest.RetryRequest);
            Assert.Equal(CreateResponse(Ok, Ok, DeadlineExceeded, NotFound), underTest.BuildResponse());
        }

        /// <summary>
        /// Processing status should return Invalid if even a single response is missing/did not receive status.
        /// Or response has an extra entry.
        /// </summary>
        [Fact]
        public void TestInvalid()
        {
            // Create 3 muntations, but only 2 OKs. That should be invalid.
            BigtableMutateRowsRequestManager underTest =
                new BigtableMutateRowsRequestManager(_retryStatuses, CreateRequest(3));
            Assert.Equal(BigtableMutateRowsRequestManager.ProcessingStatus.Invalid,
                Send(underTest, CreateResponse(Ok, Ok)));

            // Same 3 original mutations, but 4 entries in the response. That should be invalid.
            underTest = new BigtableMutateRowsRequestManager(_retryStatuses, CreateRequest(3));
            Assert.Equal(BigtableMutateRowsRequestManager.ProcessingStatus.Invalid,
                Send(underTest, CreateResponse(Ok, Ok, Ok, Ok)));
        }
    }
}
