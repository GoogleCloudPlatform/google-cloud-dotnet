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

namespace Google.Cloud.Translate.V3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTranslationServiceClientTest
    {
        [xunit::FactAttribute]
        public void TranslateTextRequestObject()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TranslateTextRequest request = new TranslateTextRequest
            {
                Contents =
                {
                    "contents8c7dbf98",
                },
                MimeType = "mime_type606a0ffc",
                SourceLanguageCode = "source_language_code14998292",
                TargetLanguageCode = "target_language_code6ec12c87",
                Model = "model635ef320",
                GlossaryConfig = new TranslateTextGlossaryConfig(),
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            TranslateTextResponse expectedResponse = new TranslateTextResponse
            {
                Translations = { new Translation(), },
                GlossaryTranslations = { new Translation(), },
            };
            mockGrpcClient.Setup(x => x.TranslateText(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            TranslateTextResponse response = client.TranslateText(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TranslateTextRequestObjectAsync()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TranslateTextRequest request = new TranslateTextRequest
            {
                Contents =
                {
                    "contents8c7dbf98",
                },
                MimeType = "mime_type606a0ffc",
                SourceLanguageCode = "source_language_code14998292",
                TargetLanguageCode = "target_language_code6ec12c87",
                Model = "model635ef320",
                GlossaryConfig = new TranslateTextGlossaryConfig(),
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            TranslateTextResponse expectedResponse = new TranslateTextResponse
            {
                Translations = { new Translation(), },
                GlossaryTranslations = { new Translation(), },
            };
            mockGrpcClient.Setup(x => x.TranslateTextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TranslateTextResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            TranslateTextResponse responseCallSettings = await client.TranslateTextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TranslateTextResponse responseCancellationToken = await client.TranslateTextAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TranslateText1()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TranslateTextRequest request = new TranslateTextRequest
            {
                Contents =
                {
                    "contents8c7dbf98",
                },
                TargetLanguageCode = "target_language_code6ec12c87",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            TranslateTextResponse expectedResponse = new TranslateTextResponse
            {
                Translations = { new Translation(), },
                GlossaryTranslations = { new Translation(), },
            };
            mockGrpcClient.Setup(x => x.TranslateText(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            TranslateTextResponse response = client.TranslateText(request.Parent, request.TargetLanguageCode, request.Contents);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TranslateText1Async()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TranslateTextRequest request = new TranslateTextRequest
            {
                Contents =
                {
                    "contents8c7dbf98",
                },
                TargetLanguageCode = "target_language_code6ec12c87",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            TranslateTextResponse expectedResponse = new TranslateTextResponse
            {
                Translations = { new Translation(), },
                GlossaryTranslations = { new Translation(), },
            };
            mockGrpcClient.Setup(x => x.TranslateTextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TranslateTextResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            TranslateTextResponse responseCallSettings = await client.TranslateTextAsync(request.Parent, request.TargetLanguageCode, request.Contents, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TranslateTextResponse responseCancellationToken = await client.TranslateTextAsync(request.Parent, request.TargetLanguageCode, request.Contents, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TranslateText1_ResourceNames()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TranslateTextRequest request = new TranslateTextRequest
            {
                Contents =
                {
                    "contents8c7dbf98",
                },
                TargetLanguageCode = "target_language_code6ec12c87",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            TranslateTextResponse expectedResponse = new TranslateTextResponse
            {
                Translations = { new Translation(), },
                GlossaryTranslations = { new Translation(), },
            };
            mockGrpcClient.Setup(x => x.TranslateText(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            TranslateTextResponse response = client.TranslateText(request.ParentAsLocationName, request.TargetLanguageCode, request.Contents);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TranslateText1Async_ResourceNames()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TranslateTextRequest request = new TranslateTextRequest
            {
                Contents =
                {
                    "contents8c7dbf98",
                },
                TargetLanguageCode = "target_language_code6ec12c87",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            TranslateTextResponse expectedResponse = new TranslateTextResponse
            {
                Translations = { new Translation(), },
                GlossaryTranslations = { new Translation(), },
            };
            mockGrpcClient.Setup(x => x.TranslateTextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TranslateTextResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            TranslateTextResponse responseCallSettings = await client.TranslateTextAsync(request.ParentAsLocationName, request.TargetLanguageCode, request.Contents, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TranslateTextResponse responseCancellationToken = await client.TranslateTextAsync(request.ParentAsLocationName, request.TargetLanguageCode, request.Contents, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TranslateText2()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TranslateTextRequest request = new TranslateTextRequest
            {
                Contents =
                {
                    "contents8c7dbf98",
                },
                MimeType = "mime_type606a0ffc",
                SourceLanguageCode = "source_language_code14998292",
                TargetLanguageCode = "target_language_code6ec12c87",
                Model = "model635ef320",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            TranslateTextResponse expectedResponse = new TranslateTextResponse
            {
                Translations = { new Translation(), },
                GlossaryTranslations = { new Translation(), },
            };
            mockGrpcClient.Setup(x => x.TranslateText(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            TranslateTextResponse response = client.TranslateText(request.Parent, request.Model, request.MimeType, request.SourceLanguageCode, request.TargetLanguageCode, request.Contents);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TranslateText2Async()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TranslateTextRequest request = new TranslateTextRequest
            {
                Contents =
                {
                    "contents8c7dbf98",
                },
                MimeType = "mime_type606a0ffc",
                SourceLanguageCode = "source_language_code14998292",
                TargetLanguageCode = "target_language_code6ec12c87",
                Model = "model635ef320",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            TranslateTextResponse expectedResponse = new TranslateTextResponse
            {
                Translations = { new Translation(), },
                GlossaryTranslations = { new Translation(), },
            };
            mockGrpcClient.Setup(x => x.TranslateTextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TranslateTextResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            TranslateTextResponse responseCallSettings = await client.TranslateTextAsync(request.Parent, request.Model, request.MimeType, request.SourceLanguageCode, request.TargetLanguageCode, request.Contents, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TranslateTextResponse responseCancellationToken = await client.TranslateTextAsync(request.Parent, request.Model, request.MimeType, request.SourceLanguageCode, request.TargetLanguageCode, request.Contents, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TranslateText2_ResourceNames()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TranslateTextRequest request = new TranslateTextRequest
            {
                Contents =
                {
                    "contents8c7dbf98",
                },
                MimeType = "mime_type606a0ffc",
                SourceLanguageCode = "source_language_code14998292",
                TargetLanguageCode = "target_language_code6ec12c87",
                Model = "model635ef320",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            TranslateTextResponse expectedResponse = new TranslateTextResponse
            {
                Translations = { new Translation(), },
                GlossaryTranslations = { new Translation(), },
            };
            mockGrpcClient.Setup(x => x.TranslateText(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            TranslateTextResponse response = client.TranslateText(request.ParentAsLocationName, request.Model, request.MimeType, request.SourceLanguageCode, request.TargetLanguageCode, request.Contents);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TranslateText2Async_ResourceNames()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TranslateTextRequest request = new TranslateTextRequest
            {
                Contents =
                {
                    "contents8c7dbf98",
                },
                MimeType = "mime_type606a0ffc",
                SourceLanguageCode = "source_language_code14998292",
                TargetLanguageCode = "target_language_code6ec12c87",
                Model = "model635ef320",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            TranslateTextResponse expectedResponse = new TranslateTextResponse
            {
                Translations = { new Translation(), },
                GlossaryTranslations = { new Translation(), },
            };
            mockGrpcClient.Setup(x => x.TranslateTextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TranslateTextResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            TranslateTextResponse responseCallSettings = await client.TranslateTextAsync(request.ParentAsLocationName, request.Model, request.MimeType, request.SourceLanguageCode, request.TargetLanguageCode, request.Contents, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TranslateTextResponse responseCancellationToken = await client.TranslateTextAsync(request.ParentAsLocationName, request.Model, request.MimeType, request.SourceLanguageCode, request.TargetLanguageCode, request.Contents, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DetectLanguageRequestObject()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DetectLanguageRequest request = new DetectLanguageRequest
            {
                Content = "contentb964039a",
                MimeType = "mime_type606a0ffc",
                Model = "model635ef320",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            DetectLanguageResponse expectedResponse = new DetectLanguageResponse
            {
                Languages =
                {
                    new DetectedLanguage(),
                },
            };
            mockGrpcClient.Setup(x => x.DetectLanguage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            DetectLanguageResponse response = client.DetectLanguage(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DetectLanguageRequestObjectAsync()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DetectLanguageRequest request = new DetectLanguageRequest
            {
                Content = "contentb964039a",
                MimeType = "mime_type606a0ffc",
                Model = "model635ef320",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            DetectLanguageResponse expectedResponse = new DetectLanguageResponse
            {
                Languages =
                {
                    new DetectedLanguage(),
                },
            };
            mockGrpcClient.Setup(x => x.DetectLanguageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DetectLanguageResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            DetectLanguageResponse responseCallSettings = await client.DetectLanguageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DetectLanguageResponse responseCancellationToken = await client.DetectLanguageAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DetectLanguage()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DetectLanguageRequest request = new DetectLanguageRequest
            {
                Content = "contentb964039a",
                MimeType = "mime_type606a0ffc",
                Model = "model635ef320",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            DetectLanguageResponse expectedResponse = new DetectLanguageResponse
            {
                Languages =
                {
                    new DetectedLanguage(),
                },
            };
            mockGrpcClient.Setup(x => x.DetectLanguage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            DetectLanguageResponse response = client.DetectLanguage(request.Parent, request.Model, request.MimeType, request.Content);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DetectLanguageAsync()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DetectLanguageRequest request = new DetectLanguageRequest
            {
                Content = "contentb964039a",
                MimeType = "mime_type606a0ffc",
                Model = "model635ef320",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            DetectLanguageResponse expectedResponse = new DetectLanguageResponse
            {
                Languages =
                {
                    new DetectedLanguage(),
                },
            };
            mockGrpcClient.Setup(x => x.DetectLanguageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DetectLanguageResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            DetectLanguageResponse responseCallSettings = await client.DetectLanguageAsync(request.Parent, request.Model, request.MimeType, request.Content, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DetectLanguageResponse responseCancellationToken = await client.DetectLanguageAsync(request.Parent, request.Model, request.MimeType, request.Content, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DetectLanguage_ResourceNames()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DetectLanguageRequest request = new DetectLanguageRequest
            {
                Content = "contentb964039a",
                MimeType = "mime_type606a0ffc",
                Model = "model635ef320",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            DetectLanguageResponse expectedResponse = new DetectLanguageResponse
            {
                Languages =
                {
                    new DetectedLanguage(),
                },
            };
            mockGrpcClient.Setup(x => x.DetectLanguage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            DetectLanguageResponse response = client.DetectLanguage(request.ParentAsLocationName, request.Model, request.MimeType, request.Content);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DetectLanguageAsync_ResourceNames()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DetectLanguageRequest request = new DetectLanguageRequest
            {
                Content = "contentb964039a",
                MimeType = "mime_type606a0ffc",
                Model = "model635ef320",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            DetectLanguageResponse expectedResponse = new DetectLanguageResponse
            {
                Languages =
                {
                    new DetectedLanguage(),
                },
            };
            mockGrpcClient.Setup(x => x.DetectLanguageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DetectLanguageResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            DetectLanguageResponse responseCallSettings = await client.DetectLanguageAsync(request.ParentAsLocationName, request.Model, request.MimeType, request.Content, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DetectLanguageResponse responseCancellationToken = await client.DetectLanguageAsync(request.ParentAsLocationName, request.Model, request.MimeType, request.Content, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSupportedLanguagesRequestObject()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSupportedLanguagesRequest request = new GetSupportedLanguagesRequest
            {
                DisplayLanguageCode = "display_language_code67946a7b",
                Model = "model635ef320",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            SupportedLanguages expectedResponse = new SupportedLanguages
            {
                Languages =
                {
                    new SupportedLanguage(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSupportedLanguages(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            SupportedLanguages response = client.GetSupportedLanguages(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSupportedLanguagesRequestObjectAsync()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSupportedLanguagesRequest request = new GetSupportedLanguagesRequest
            {
                DisplayLanguageCode = "display_language_code67946a7b",
                Model = "model635ef320",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            SupportedLanguages expectedResponse = new SupportedLanguages
            {
                Languages =
                {
                    new SupportedLanguage(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSupportedLanguagesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SupportedLanguages>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            SupportedLanguages responseCallSettings = await client.GetSupportedLanguagesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SupportedLanguages responseCancellationToken = await client.GetSupportedLanguagesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSupportedLanguages()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSupportedLanguagesRequest request = new GetSupportedLanguagesRequest
            {
                DisplayLanguageCode = "display_language_code67946a7b",
                Model = "model635ef320",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            SupportedLanguages expectedResponse = new SupportedLanguages
            {
                Languages =
                {
                    new SupportedLanguage(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSupportedLanguages(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            SupportedLanguages response = client.GetSupportedLanguages(request.Parent, request.Model, request.DisplayLanguageCode);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSupportedLanguagesAsync()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSupportedLanguagesRequest request = new GetSupportedLanguagesRequest
            {
                DisplayLanguageCode = "display_language_code67946a7b",
                Model = "model635ef320",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            SupportedLanguages expectedResponse = new SupportedLanguages
            {
                Languages =
                {
                    new SupportedLanguage(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSupportedLanguagesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SupportedLanguages>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            SupportedLanguages responseCallSettings = await client.GetSupportedLanguagesAsync(request.Parent, request.Model, request.DisplayLanguageCode, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SupportedLanguages responseCancellationToken = await client.GetSupportedLanguagesAsync(request.Parent, request.Model, request.DisplayLanguageCode, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSupportedLanguages_ResourceNames()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSupportedLanguagesRequest request = new GetSupportedLanguagesRequest
            {
                DisplayLanguageCode = "display_language_code67946a7b",
                Model = "model635ef320",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            SupportedLanguages expectedResponse = new SupportedLanguages
            {
                Languages =
                {
                    new SupportedLanguage(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSupportedLanguages(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            SupportedLanguages response = client.GetSupportedLanguages(request.ParentAsLocationName, request.Model, request.DisplayLanguageCode);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSupportedLanguagesAsync_ResourceNames()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSupportedLanguagesRequest request = new GetSupportedLanguagesRequest
            {
                DisplayLanguageCode = "display_language_code67946a7b",
                Model = "model635ef320",
                ParentAsLocationName = new gagr::LocationName("[PROJECT]", "[LOCATION]"),
            };
            SupportedLanguages expectedResponse = new SupportedLanguages
            {
                Languages =
                {
                    new SupportedLanguage(),
                },
            };
            mockGrpcClient.Setup(x => x.GetSupportedLanguagesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SupportedLanguages>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            SupportedLanguages responseCallSettings = await client.GetSupportedLanguagesAsync(request.ParentAsLocationName, request.Model, request.DisplayLanguageCode, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SupportedLanguages responseCancellationToken = await client.GetSupportedLanguagesAsync(request.ParentAsLocationName, request.Model, request.DisplayLanguageCode, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGlossaryRequestObject()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlossaryRequest request = new GetGlossaryRequest
            {
                GlossaryName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
            };
            Glossary expectedResponse = new Glossary
            {
                GlossaryName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                LanguagePair = new Glossary.Types.LanguageCodePair(),
                LanguageCodesSet = new Glossary.Types.LanguageCodesSet(),
                InputConfig = new GlossaryInputConfig(),
                EntryCount = -1925390589,
                SubmitTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetGlossary(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            Glossary response = client.GetGlossary(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGlossaryRequestObjectAsync()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlossaryRequest request = new GetGlossaryRequest
            {
                GlossaryName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
            };
            Glossary expectedResponse = new Glossary
            {
                GlossaryName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                LanguagePair = new Glossary.Types.LanguageCodePair(),
                LanguageCodesSet = new Glossary.Types.LanguageCodesSet(),
                InputConfig = new GlossaryInputConfig(),
                EntryCount = -1925390589,
                SubmitTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetGlossaryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Glossary>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            Glossary responseCallSettings = await client.GetGlossaryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Glossary responseCancellationToken = await client.GetGlossaryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGlossary()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlossaryRequest request = new GetGlossaryRequest
            {
                GlossaryName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
            };
            Glossary expectedResponse = new Glossary
            {
                GlossaryName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                LanguagePair = new Glossary.Types.LanguageCodePair(),
                LanguageCodesSet = new Glossary.Types.LanguageCodesSet(),
                InputConfig = new GlossaryInputConfig(),
                EntryCount = -1925390589,
                SubmitTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetGlossary(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            Glossary response = client.GetGlossary(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGlossaryAsync()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlossaryRequest request = new GetGlossaryRequest
            {
                GlossaryName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
            };
            Glossary expectedResponse = new Glossary
            {
                GlossaryName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                LanguagePair = new Glossary.Types.LanguageCodePair(),
                LanguageCodesSet = new Glossary.Types.LanguageCodesSet(),
                InputConfig = new GlossaryInputConfig(),
                EntryCount = -1925390589,
                SubmitTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetGlossaryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Glossary>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            Glossary responseCallSettings = await client.GetGlossaryAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Glossary responseCancellationToken = await client.GetGlossaryAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGlossary_ResourceNames()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlossaryRequest request = new GetGlossaryRequest
            {
                GlossaryName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
            };
            Glossary expectedResponse = new Glossary
            {
                GlossaryName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                LanguagePair = new Glossary.Types.LanguageCodePair(),
                LanguageCodesSet = new Glossary.Types.LanguageCodesSet(),
                InputConfig = new GlossaryInputConfig(),
                EntryCount = -1925390589,
                SubmitTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetGlossary(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            Glossary response = client.GetGlossary(request.GlossaryName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGlossaryAsync_ResourceNames()
        {
            moq::Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new moq::Mock<TranslationService.TranslationServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlossaryRequest request = new GetGlossaryRequest
            {
                GlossaryName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
            };
            Glossary expectedResponse = new Glossary
            {
                GlossaryName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]"),
                LanguagePair = new Glossary.Types.LanguageCodePair(),
                LanguageCodesSet = new Glossary.Types.LanguageCodesSet(),
                InputConfig = new GlossaryInputConfig(),
                EntryCount = -1925390589,
                SubmitTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetGlossaryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Glossary>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            Glossary responseCallSettings = await client.GetGlossaryAsync(request.GlossaryName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Glossary responseCancellationToken = await client.GetGlossaryAsync(request.GlossaryName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
