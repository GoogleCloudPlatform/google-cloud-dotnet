﻿// Copyright 2017 Google Inc. All Rights Reserved.
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


namespace Google.Cloud.VideoIntelligence.V1
{
    public partial class VideoAnnotationResults
    {
        /// <summary>
        /// If the <see cref="Error"/> property is non-null, throws an <see cref="VideoAnnotationResultsException"/>.
        /// Otherwise, returns <c>this</c> (so that the method can be called in a fluent manner).
        /// </summary>
        /// <exception cref="VideoAnnotationResultsException">The <see cref="Error"/> property is non-null.</exception>
        /// <returns><c>this</c> if the message has no error.</returns>
        public VideoAnnotationResults ThrowOnError()
        {
            if (Error != null)
            {
                throw new VideoAnnotationResultsException(this);
            }
            return this;
        }
    }
}
