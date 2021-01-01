// Copyright 2021 Google LLC
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

namespace Google.Cloud.RecommendationEngine.V1Beta1
{
    public partial class PurgeUserEventsRequest
    {
        /// <summary>
        /// <see cref="EventStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EventStoreName ParentAsEventStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EventStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class WriteUserEventRequest
    {
        /// <summary>
        /// <see cref="EventStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EventStoreName ParentAsEventStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EventStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CollectUserEventRequest
    {
        /// <summary>
        /// <see cref="EventStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EventStoreName ParentAsEventStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EventStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListUserEventsRequest
    {
        /// <summary>
        /// <see cref="EventStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EventStoreName ParentAsEventStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EventStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
