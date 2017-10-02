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

using Google.Protobuf;
using System;

namespace Google.Cloud.Bigtable.V2
{
    public partial class ValueRange
    {
        /// <summary>
        /// Creates a <see cref="ValueRange"/> instance with inclusive bounds.
        /// </summary>
        /// <param name="startKeyClosed">
        /// The inclusive lower bound for the range. If null, it is interpreted as the empty string.
        /// </param>
        /// <param name="endKeyClosed">
        /// The inclusive upper bound for the range. If null, it is interpreted as the infinite row key.
        /// </param>
        /// <returns>The created range.</returns>
        public static ValueRange Closed(string startKeyClosed, string endKeyClosed)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a <see cref="ValueRange"/> instance with an inclusive lower bound and an exclusive upper bound.
        /// </summary>
        /// <param name="startKeyClosed">
        /// The inclusive lower bound for the range. If null, it is interpreted as the empty string.
        /// </param>
        /// <param name="endKeyOpen">
        /// The exclusive upper bound for the range. If null, it is interpreted as the infinite row key.
        /// </param>
        /// <returns>The created range.</returns>
        public static ValueRange ClosedOpen(string startKeyClosed, string endKeyOpen)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a <see cref="ValueRange"/> instance with exclusive bounds.
        /// </summary>
        /// <param name="startKeyOpen">
        /// The exclusive lower bound for the range. If null, it is interpreted as the empty string.
        /// </param>
        /// <param name="endKeyOpen">
        /// The exclusive upper bound for the range. If null, it is interpreted as the infinite row key.
        /// </param>
        /// <returns>The created range.</returns>
        public static ValueRange Open(string startKeyOpen, string endKeyOpen)
        {
            // TODO: The missing start key is the empty string, inclusive, so we must explicitly set the start key open to the empty string here when it is null.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a <see cref="ValueRange"/> instance with an exclusive lower bound and an inclusive upper bound.
        /// </summary>
        /// <param name="startKeyOpen">
        /// The exclusive lower bound for the range. If null, it is interpreted as the empty string.
        /// </param>
        /// <param name="endKeyClosed">
        /// The inclusive upper bound for the range. If null, it is interpreted as the infinite row key.
        /// </param>
        /// <returns>The created range.</returns>
        public static ValueRange OpenClosed(string startKeyOpen, string endKeyClosed)
        {
            // TODO: The missing start key is the empty string, inclusive, so we must explicitly set the start key open to the empty string here when it is null.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a <see cref="ValueRange"/> instance with inclusive bounds.
        /// </summary>
        /// <param name="startKeyClosed">
        /// The inclusive lower bound for the range. If null, it is interpreted as the empty string.
        /// </param>
        /// <param name="endKeyClosed">
        /// The inclusive upper bound for the range. If null, it is interpreted as the infinite row key.
        /// </param>
        /// <returns>The created range.</returns>
        public static ValueRange Closed(ByteString startKeyClosed, ByteString endKeyClosed)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a <see cref="ValueRange"/> instance with an inclusive lower bound and an exclusive upper bound.
        /// </summary>
        /// <param name="startKeyClosed">
        /// The inclusive lower bound for the range. If null, it is interpreted as the empty string.
        /// </param>
        /// <param name="endKeyOpen">
        /// The exclusive upper bound for the range. If null, it is interpreted as the infinite row key.
        /// </param>
        /// <returns>The created range.</returns>
        public static ValueRange ClosedOpen(ByteString startKeyClosed, ByteString endKeyOpen)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a <see cref="ValueRange"/> instance with exclusive bounds.
        /// </summary>
        /// <param name="startKeyOpen">
        /// The exclusive lower bound for the range. If null, it is interpreted as the empty string.
        /// </param>
        /// <param name="endKeyOpen">
        /// The exclusive upper bound for the range. If null, it is interpreted as the infinite row key.
        /// </param>
        /// <returns>The created range.</returns>
        public static ValueRange Open(ByteString startKeyOpen, ByteString endKeyOpen)
        {
            // TODO: The missing start key is the empty string, inclusive, so we must explicitly set the start key open to the empty string here when it is null.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a <see cref="ValueRange"/> instance with an exclusive lower bound and an inclusive upper bound.
        /// </summary>
        /// <param name="startKeyOpen">
        /// The exclusive lower bound for the range. If null, it is interpreted as the empty string.
        /// </param>
        /// <param name="endKeyClosed">
        /// The inclusive upper bound for the range. If null, it is interpreted as the infinite row key.
        /// </param>
        /// <returns>The created range.</returns>
        public static ValueRange OpenClosed(ByteString startKeyOpen, ByteString endKeyClosed)
        {
            // TODO: The missing start key is the empty string, inclusive, so we must explicitly set the start key open to the empty string here when it is null.
            throw new NotImplementedException();
        }
    }
}
