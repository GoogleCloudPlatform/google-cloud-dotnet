﻿// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Devtools.Cloudtrace.V1;
using Google.Protobuf.Collections;
using Moq;
using System.Collections.Generic;

namespace Google.Devtools.AspNet.Tests
{
    public static class Utils
    {
        /// <summary>
        /// Creates a rate limiter that will allow 1 QPS with the elapsed milliseconds.
        /// </summary>
        internal static RateLimiter GetRateLimiter(long elapsedMilliseconds)
        {
            Mock<ITimer> watch = new Mock<ITimer>();
            watch.Setup(w => w.GetElapsedMilliseconds()).Returns(elapsedMilliseconds);
            return new RateLimiter(1, watch.Object);
        }

        /// <summary>
        /// Creates a rate limiter with the given QPS that returns the given elapsed milliseconds
        /// in order.
        /// </summary>
        internal static RateLimiter GetRateLimiter(double qps, long[] elapsedMilliseconds)
        {
            Queue<long> returnQueue = new Queue<long>(elapsedMilliseconds);
            Mock<ITimer> watch = new Mock<ITimer>();
            watch.Setup(w => w.GetElapsedMilliseconds()).Returns(() => returnQueue.Dequeue());
            return new RateLimiter(qps, watch.Object);
        }

        // TODO(talarico): COMMENT ME
        public static bool IsValidAnnotation(TraceSpan span, Dictionary<string, string> annotation)
        {
            MapField<string, string> labels = span.Labels;
            if (labels.Count != annotation.Count)
            {
                return false;
            }

            foreach (KeyValuePair<string, string> label in labels)
            {
                if (annotation[label.Key] != label.Value)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
