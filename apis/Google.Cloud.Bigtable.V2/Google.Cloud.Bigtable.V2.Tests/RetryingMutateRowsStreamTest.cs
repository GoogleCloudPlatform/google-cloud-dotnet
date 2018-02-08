﻿// Copyright 2018 Google Inc. All rights reserved.
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Google.Rpc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class RetryingMutateRowsStreamTest
    {
        private readonly static Mutation NonIdempotentMutation =
            new Mutation
            {
                SetCell = new Mutation.Types.SetCell
                {
                    FamilyName = "xyz",
                    ColumnQualifier = ByteString.Empty,
                    Value = ByteString.Empty,
                    TimestampMicros = -1
                }
            };

        [Fact]
        public async Task SimpleRetry()
        {
            var stream = MutateRowsStreamUtilities.CreateRetryableMutateRowsStream(
                request: new MutateRowsRequest
                {
                    Entries =
                    {
                        Mutations.CreateEntry("a", Mutations.DeleteFromRow()),
                        Mutations.CreateEntry("b", Mutations.DeleteFromRow()),
                        Mutations.CreateEntry("c", Mutations.DeleteFromRow())
                    }
                },
                entriesForInitialResponse: new[]
                {
                    MutateRowsStreamUtilities.CreateEntry(0, Code.Ok),
                    MutateRowsStreamUtilities.CreateEntry(1, Code.DeadlineExceeded),
                    MutateRowsStreamUtilities.CreateEntry(2, Code.Ok)
                },
                entriesForRetryResponses: new[]
                {
                    // 1st retry response entries
                    new[] { MutateRowsStreamUtilities.CreateEntry(0, Code.Ok) }
                });

            var entries = (await stream.GetResponseEntries()).ToList();
            Assert.Equal(3, entries.Count);

            var entry = entries[0];
            Assert.Equal(0, entry.Index);
            Assert.Equal((int)Code.Ok, entry.Status.Code);

            entry = entries[1];
            Assert.Equal(1, entry.Index);
            Assert.Equal((int)Code.Ok, entry.Status.Code);

            entry = entries[2];
            Assert.Equal(2, entry.Index);
            Assert.Equal((int)Code.Ok, entry.Status.Code);
        }

        [Fact]
        public async Task MultipleRetries()
        {
            var stream = MutateRowsStreamUtilities.CreateRetryableMutateRowsStream(
                request: new MutateRowsRequest
                {
                    Entries =
                    {
                        Mutations.CreateEntry("a", Mutations.DeleteFromRow()),
                        Mutations.CreateEntry("b", Mutations.DeleteFromRow()),
                        Mutations.CreateEntry("c", Mutations.DeleteFromRow()),
                        Mutations.CreateEntry("d", Mutations.DeleteFromRow()),
                        Mutations.CreateEntry("e", Mutations.DeleteFromRow())
                    }
                },
                entriesForInitialResponse: new[]
                {
                    MutateRowsStreamUtilities.CreateEntry(0, Code.Ok),
                    MutateRowsStreamUtilities.CreateEntry(1, Code.DeadlineExceeded),
                    MutateRowsStreamUtilities.CreateEntry(2, Code.Ok),
                    MutateRowsStreamUtilities.CreateEntry(3, Code.DeadlineExceeded),
                    MutateRowsStreamUtilities.CreateEntry(4, Code.DeadlineExceeded)
                },
                entriesForRetryResponses: new[]
                {
                    // 1st retry response entries
                    new[]
                    {
                        // Original entry 1
                        MutateRowsStreamUtilities.CreateEntry(0, Code.Ok),
                        // Original entry 3
                        MutateRowsStreamUtilities.CreateEntry(1, Code.DeadlineExceeded),
                        // Original entry 4
                        MutateRowsStreamUtilities.CreateEntry(2, Code.Ok)
                    },
                    // 2end retry response entries
                    new[]
                    {
                        // Original entry 3
                        MutateRowsStreamUtilities.CreateEntry(0, Code.FailedPrecondition)
                    }
                });

            var entries = (await stream.GetResponseEntries()).ToList();
            Assert.Equal(5, entries.Count);

            var entry = entries[0];
            Assert.Equal(0, entry.Index);
            Assert.Equal((int)Code.Ok, entry.Status.Code);

            entry = entries[1];
            Assert.Equal(1, entry.Index);
            Assert.Equal((int)Code.Ok, entry.Status.Code);

            entry = entries[2];
            Assert.Equal(2, entry.Index);
            Assert.Equal((int)Code.Ok, entry.Status.Code);

            entry = entries[3];
            Assert.Equal(3, entry.Index);
            Assert.Equal((int)Code.FailedPrecondition, entry.Status.Code);

            entry = entries[4];
            Assert.Equal(4, entry.Index);
            Assert.Equal((int)Code.Ok, entry.Status.Code);
        }

        [Fact]
        public async Task NonRetryableErrorCodePreventsRetry()
        {
            var stream = MutateRowsStreamUtilities.CreateRetryableMutateRowsStream(
                request: new MutateRowsRequest
                {
                    Entries =
                    {
                        Mutations.CreateEntry("a", Mutations.DeleteFromRow()),
                        Mutations.CreateEntry("b", Mutations.DeleteFromRow()),
                        Mutations.CreateEntry("c", Mutations.DeleteFromRow())
                    }
                },
                entriesForInitialResponse: new[]
                {
                    MutateRowsStreamUtilities.CreateEntry(0, Code.Ok),
                    MutateRowsStreamUtilities.CreateEntry(1, Code.FailedPrecondition),
                    MutateRowsStreamUtilities.CreateEntry(2, Code.DeadlineExceeded)
                },
                entriesForRetryResponses: null // No retries should be made
                );

            var entries = (await stream.GetResponseEntries()).ToList();
            Assert.Equal(3, entries.Count);

            var entry = entries[0];
            Assert.Equal(0, entry.Index);
            Assert.Equal((int)Code.Ok, entry.Status.Code);

            entry = entries[1];
            Assert.Equal(1, entry.Index);
            Assert.Equal((int)Code.FailedPrecondition, entry.Status.Code);

            entry = entries[2];
            Assert.Equal(2, entry.Index);
            Assert.Equal((int)Code.DeadlineExceeded, entry.Status.Code);
        }

        [Fact]
        public async Task NonIdempotentInitialSuccessRetries()
        {
            var stream = MutateRowsStreamUtilities.CreateRetryableMutateRowsStream(
                request: new MutateRowsRequest
                {
                    Entries =
                    {
                        Mutations.CreateEntry("a", NonIdempotentMutation),
                        Mutations.CreateEntry("b", Mutations.DeleteFromRow()),
                        Mutations.CreateEntry("c", Mutations.DeleteFromRow())
                    }
                },
                entriesForInitialResponse: new[]
                {
                    MutateRowsStreamUtilities.CreateEntry(0, Code.Ok),
                    MutateRowsStreamUtilities.CreateEntry(1, Code.DeadlineExceeded),
                    MutateRowsStreamUtilities.CreateEntry(2, Code.Ok)
                },
                entriesForRetryResponses: new[]
                {
                    // 1st retry response entries
                    new[] { MutateRowsStreamUtilities.CreateEntry(0, Code.Ok) }
                });

            var entries = (await stream.GetResponseEntries()).ToList();
            Assert.Equal(3, entries.Count);

            var entry = entries[0];
            Assert.Equal(0, entry.Index);
            Assert.Equal((int)Code.Ok, entry.Status.Code);

            entry = entries[1];
            Assert.Equal(1, entry.Index);
            Assert.Equal((int)Code.Ok, entry.Status.Code);

            entry = entries[2];
            Assert.Equal(2, entry.Index);
            Assert.Equal((int)Code.Ok, entry.Status.Code);
        }

        [Fact]
        public async Task NonIdempotentInitialFailureDoesNotRetry()
        {
            var stream = MutateRowsStreamUtilities.CreateRetryableMutateRowsStream(
                request: new MutateRowsRequest
                {
                    Entries =
                    {
                        Mutations.CreateEntry("a", Mutations.DeleteFromRow()),
                        Mutations.CreateEntry("b", NonIdempotentMutation),
                        Mutations.CreateEntry("c", Mutations.DeleteFromRow())
                    }
                },
                entriesForInitialResponse: new[]
                {
                    MutateRowsStreamUtilities.CreateEntry(0, Code.Ok),
                    MutateRowsStreamUtilities.CreateEntry(1, Code.DeadlineExceeded),
                    MutateRowsStreamUtilities.CreateEntry(2, Code.DeadlineExceeded)
                },
                entriesForRetryResponses: new[]
                {
                    // 1st retry response entries
                    new[] { MutateRowsStreamUtilities.CreateEntry(0, Code.Ok) }
                });

            var entries = (await stream.GetResponseEntries()).ToList();
            Assert.Equal(3, entries.Count);

            var entry = entries[0];
            Assert.Equal(0, entry.Index);
            Assert.Equal((int)Code.Ok, entry.Status.Code);

            entry = entries[1];
            Assert.Equal(1, entry.Index);
            Assert.Equal((int)Code.DeadlineExceeded, entry.Status.Code);

            // Verify that the non-idempotent entry only prevents retry of that one entry.
            // The 3rd entry should have retried and succeeded.
            entry = entries[2];
            Assert.Equal(2, entry.Index);
            Assert.Equal((int)Code.Ok, entry.Status.Code);
        }

        // TODO: Test with a mock IClock to make sure we don't go over the total timeout when retrying
    }
}
