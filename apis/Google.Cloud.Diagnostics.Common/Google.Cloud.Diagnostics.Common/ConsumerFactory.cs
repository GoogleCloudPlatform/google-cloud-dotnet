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

using Google.Api.Gax;
using System;

namespace Google.Cloud.Diagnostics.Common
{
    internal static class ConsumerFactory<T>
    {
        /// <summary>
        /// Gets a <see cref="IConsumer{T}"/> that wraps the passed in consumer based on the buffer options.
        /// </summary>
        /// <param name="consumer">The consumer to buffer into.</param>
        /// <param name="sizer">A function to obtain the size of an item in bytes.</param>
        /// <param name="options">Buffer options for the buffered consumer</param>
        internal static IConsumer<T> GetConsumer(IConsumer<T> consumer, Func<T, int> sizer, BufferOptions options)
        {
            GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            GaxPreconditions.CheckNotNull(options, nameof(options));

            switch (options.BufferType)
            {
                case BufferType.Sized:
                    GaxPreconditions.CheckNotNull(sizer, nameof(sizer));
                    return SizedBufferingConsumer<T>.Create(consumer, sizer, options.BufferSizeBytes);
                case BufferType.Timed:
                    return TimedBufferingConsumer<T>.Create(consumer, options.BufferWaitTime);
                case BufferType.None:
                    return consumer;
                default:
                    throw new ArgumentException($"Invalid BufferType: {options.BufferType}");
            }
        }
    }
}
