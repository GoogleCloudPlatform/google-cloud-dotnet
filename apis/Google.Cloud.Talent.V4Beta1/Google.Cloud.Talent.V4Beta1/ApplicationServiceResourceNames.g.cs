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

using gctv = Google.Cloud.Talent.V4Beta1;

namespace Google.Cloud.Talent.V4Beta1
{
    public partial class CreateApplicationRequest
    {
        /// <summary>
        /// <see cref="ProfileName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProfileName ParentAsProfileName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProfileName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetApplicationRequest
    {
        /// <summary>
        /// <see cref="gctv::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteApplicationRequest
    {
        /// <summary>
        /// <see cref="gctv::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListApplicationsRequest
    {
        /// <summary>
        /// <see cref="ProfileName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProfileName ParentAsProfileName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProfileName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
