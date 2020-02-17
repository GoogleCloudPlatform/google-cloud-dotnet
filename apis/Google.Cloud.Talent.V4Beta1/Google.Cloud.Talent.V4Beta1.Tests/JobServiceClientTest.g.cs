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

using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Talent.V4Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedJobServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request.Parent, request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request.Parent, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request.Parent, request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobResourceNames1()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request.ParentAsProjectName, request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobResourceNames1Async()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request.ParentAsProjectName, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request.ParentAsProjectName, request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobResourceNames2()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request.ParentAsTenantName, request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobResourceNames2Async()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request.ParentAsTenantName, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request.ParentAsTenantName, request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobResourceNames3()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request.ParentAsTenantOrProjectName, request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobResourceNames3Async()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request.ParentAsTenantOrProjectName, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request.ParentAsTenantOrProjectName, request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request.JobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request.JobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request.JobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job(),
                UpdateMask = new wkt::FieldMask(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.UpdateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.UpdateJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job(),
                UpdateMask = new wkt::FieldMask(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.UpdateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.UpdateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.UpdateJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateJobRequest request = new UpdateJobRequest { Job = new Job(), };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.UpdateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job response = client.UpdateJob(request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateJobRequest request = new UpdateJobRequest { Job = new Job(), };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
                CompanyAsCompanyName = CompanyName.FromProjectCompany("[PROJECT]", "[COMPANY]"),
                RequisitionId = "requisition_id21c2f0af",
                Title = "title17dbd3d5",
                Description = "description2cf9da67",
                Addresses =
                {
                    "addresses2f3a3e96",
                },
                ApplicationInfo = new Job.Types.ApplicationInfo(),
                JobBenefits = { JobBenefit.Dental, },
                CompensationInfo = new CompensationInfo(),
                CustomAttributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                DegreeTypes =
                {
                    DegreeType.PrimaryEducation,
                },
                Department = "departmentca9f9d45",
                EmploymentTypes =
                {
                    EmploymentType.OtherEmploymentType,
                },
                Incentives = "incentives80814488",
                LanguageCode = "language_code2f6c7160",
                JobLevel = JobLevel.Director,
                PromotionValue = 899484920,
                Qualifications = "qualifications920abb76",
                Responsibilities = "responsibilities978e5c9b",
                PostingRegion = PostingRegion.AdministrativeArea,
                JobStartTime = new wkt::Timestamp(),
                JobEndTime = new wkt::Timestamp(),
                PostingPublishTime = new wkt::Timestamp(),
                PostingExpireTime = new wkt::Timestamp(),
                PostingCreateTime = new wkt::Timestamp(),
                PostingUpdateTime = new wkt::Timestamp(),
                CompanyDisplayName = "company_display_name07e5990f",
                DerivedInfo = new Job.Types.DerivedInfo(),
                ProcessingOptions = new Job.Types.ProcessingOptions(),
            };
            mockGrpcClient.Setup(x => x.UpdateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.UpdateJobAsync(request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.UpdateJobAsync(request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJob()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobResourceNames()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request.JobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobResourceNamesAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectJob("[PROJECT]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request.JobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobAsync(request.JobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchDeleteJobsRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.BatchDeleteJobs(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchDeleteJobsRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.BatchDeleteJobsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchDeleteJobsAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchDeleteJobs()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.BatchDeleteJobs(request.Parent, request.Filter);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchDeleteJobsAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.BatchDeleteJobsAsync(request.Parent, request.Filter, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchDeleteJobsAsync(request.Parent, request.Filter, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchDeleteJobsResourceNames1()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.BatchDeleteJobs(request.ParentAsProjectName, request.Filter);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchDeleteJobsResourceNames1Async()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.BatchDeleteJobsAsync(request.ParentAsProjectName, request.Filter, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchDeleteJobsAsync(request.ParentAsProjectName, request.Filter, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchDeleteJobsResourceNames2()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.BatchDeleteJobs(request.ParentAsTenantName, request.Filter);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchDeleteJobsResourceNames2Async()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.BatchDeleteJobsAsync(request.ParentAsTenantName, request.Filter, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchDeleteJobsAsync(request.ParentAsTenantName, request.Filter, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchDeleteJobsResourceNames3()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            client.BatchDeleteJobs(request.ParentAsTenantOrProjectName, request.Filter);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchDeleteJobsResourceNames3Async()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Filter = "filtere47ac9b2",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteJobsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            await client.BatchDeleteJobsAsync(request.ParentAsTenantOrProjectName, request.Filter, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchDeleteJobsAsync(request.ParentAsTenantOrProjectName, request.Filter, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SearchJobsRequestObject()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SearchJobsRequest request = new SearchJobsRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SearchMode = SearchJobsRequest.Types.SearchMode.FeaturedJobSearch,
                RequestMetadata = new RequestMetadata(),
                JobQuery = new JobQuery(),
                EnableBroadening = false,
                RequirePreciseResultSize = false,
                HistogramQueries =
                {
                    new HistogramQuery(),
                },
                JobView = JobView.Small,
                Offset = 1472300666,
                PageSize = -226905851,
                PageToken = "page_tokenf09e5538",
                OrderBy = "order_byb4d33ada",
                DiversificationLevel = SearchJobsRequest.Types.DiversificationLevel.Disabled,
                CustomRankingInfo = new SearchJobsRequest.Types.CustomRankingInfo(),
                DisableKeywordMatch = true,
            };
            SearchJobsResponse expectedResponse = new SearchJobsResponse
            {
                MatchingJobs =
                {
                    new SearchJobsResponse.Types.MatchingJob(),
                },
                HistogramQueryResults =
                {
                    new HistogramQueryResult(),
                },
                NextPageToken = "next_page_tokendbee0940",
                LocationFilters = { new Location(), },
                EstimatedTotalSize = 1828561437,
                TotalSize = 1202968108,
                Metadata = new ResponseMetadata(),
                BroadenedQueryJobsCount = 2131480093,
                SpellCorrection = new SpellingCorrection(),
            };
            mockGrpcClient.Setup(x => x.SearchJobs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            SearchJobsResponse response = client.SearchJobs(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SearchJobsRequestObjectAsync()
        {
            moq::Mock<JobService.JobServiceClient> mockGrpcClient = new moq::Mock<JobService.JobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SearchJobsRequest request = new SearchJobsRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SearchMode = SearchJobsRequest.Types.SearchMode.FeaturedJobSearch,
                RequestMetadata = new RequestMetadata(),
                JobQuery = new JobQuery(),
                EnableBroadening = false,
                RequirePreciseResultSize = false,
                HistogramQueries =
                {
                    new HistogramQuery(),
                },
                JobView = JobView.Small,
                Offset = 1472300666,
                PageSize = -226905851,
                PageToken = "page_tokenf09e5538",
                OrderBy = "order_byb4d33ada",
                DiversificationLevel = SearchJobsRequest.Types.DiversificationLevel.Disabled,
                CustomRankingInfo = new SearchJobsRequest.Types.CustomRankingInfo(),
                DisableKeywordMatch = true,
            };
            SearchJobsResponse expectedResponse = new SearchJobsResponse
            {
                MatchingJobs =
                {
                    new SearchJobsResponse.Types.MatchingJob(),
                },
                HistogramQueryResults =
                {
                    new HistogramQueryResult(),
                },
                NextPageToken = "next_page_tokendbee0940",
                LocationFilters = { new Location(), },
                EstimatedTotalSize = 1828561437,
                TotalSize = 1202968108,
                Metadata = new ResponseMetadata(),
                BroadenedQueryJobsCount = 2131480093,
                SpellCorrection = new SpellingCorrection(),
            };
            mockGrpcClient.Setup(x => x.SearchJobsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SearchJobsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobServiceClient client = new JobServiceClientImpl(mockGrpcClient.Object, null);
            SearchJobsResponse responseCallSettings = await client.SearchJobsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SearchJobsResponse responseCancellationToken = await client.SearchJobsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
