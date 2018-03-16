// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Container.V1.Tests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedClusterManagerClientTest
    {
        [Fact]
        public void ListClusters()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            ListClustersRequest expectedRequest = new ListClustersRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
            };
            ListClustersResponse expectedResponse = new ListClustersResponse();
            mockGrpcClient.Setup(x => x.ListClusters(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            ListClustersResponse response = client.ListClusters(projectId, zone);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListClustersAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            ListClustersRequest expectedRequest = new ListClustersRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
            };
            ListClustersResponse expectedResponse = new ListClustersResponse();
            mockGrpcClient.Setup(x => x.ListClustersAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListClustersResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            ListClustersResponse response = await client.ListClustersAsync(projectId, zone);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListClusters2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            ListClustersRequest request = new ListClustersRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
            };
            ListClustersResponse expectedResponse = new ListClustersResponse();
            mockGrpcClient.Setup(x => x.ListClusters(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListClustersResponse response = client.ListClusters(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListClustersAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            ListClustersRequest request = new ListClustersRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
            };
            ListClustersResponse expectedResponse = new ListClustersResponse();
            mockGrpcClient.Setup(x => x.ListClustersAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListClustersResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListClustersResponse response = await client.ListClustersAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetCluster()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            GetClusterRequest expectedRequest = new GetClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            Cluster expectedResponse = new Cluster
            {
                Name = "name3373707",
                Description = "description-1724546052",
                InitialNodeCount = 1682564205,
                LoggingService = "loggingService-1700501035",
                MonitoringService = "monitoringService1469270462",
                Network = "network1843485230",
                ClusterIpv4Cidr = "clusterIpv4Cidr-141875831",
                Subnetwork = "subnetwork-1302785042",
                EnableKubernetesAlpha = false,
                LabelFingerprint = "labelFingerprint714995737",
                SelfLink = "selfLink-1691268851",
                Zone = "zone2-696322977",
                Endpoint = "endpoint1741102485",
                InitialClusterVersion = "initialClusterVersion-276373352",
                CurrentMasterVersion = "currentMasterVersion-920953983",
                CurrentNodeVersion = "currentNodeVersion-407476063",
                CreateTime = "createTime-493574096",
                StatusMessage = "statusMessage-239442758",
                NodeIpv4CidrSize = 1181176815,
                ServicesIpv4Cidr = "servicesIpv4Cidr1966438125",
                CurrentNodeCount = 178977560,
                ExpireTime = "expireTime-96179731",
            };
            mockGrpcClient.Setup(x => x.GetCluster(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            Cluster response = client.GetCluster(projectId, zone, clusterId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetClusterAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            GetClusterRequest expectedRequest = new GetClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            Cluster expectedResponse = new Cluster
            {
                Name = "name3373707",
                Description = "description-1724546052",
                InitialNodeCount = 1682564205,
                LoggingService = "loggingService-1700501035",
                MonitoringService = "monitoringService1469270462",
                Network = "network1843485230",
                ClusterIpv4Cidr = "clusterIpv4Cidr-141875831",
                Subnetwork = "subnetwork-1302785042",
                EnableKubernetesAlpha = false,
                LabelFingerprint = "labelFingerprint714995737",
                SelfLink = "selfLink-1691268851",
                Zone = "zone2-696322977",
                Endpoint = "endpoint1741102485",
                InitialClusterVersion = "initialClusterVersion-276373352",
                CurrentMasterVersion = "currentMasterVersion-920953983",
                CurrentNodeVersion = "currentNodeVersion-407476063",
                CreateTime = "createTime-493574096",
                StatusMessage = "statusMessage-239442758",
                NodeIpv4CidrSize = 1181176815,
                ServicesIpv4Cidr = "servicesIpv4Cidr1966438125",
                CurrentNodeCount = 178977560,
                ExpireTime = "expireTime-96179731",
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Cluster>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            Cluster response = await client.GetClusterAsync(projectId, zone, clusterId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetCluster2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            Cluster expectedResponse = new Cluster
            {
                Name = "name3373707",
                Description = "description-1724546052",
                InitialNodeCount = 1682564205,
                LoggingService = "loggingService-1700501035",
                MonitoringService = "monitoringService1469270462",
                Network = "network1843485230",
                ClusterIpv4Cidr = "clusterIpv4Cidr-141875831",
                Subnetwork = "subnetwork-1302785042",
                EnableKubernetesAlpha = false,
                LabelFingerprint = "labelFingerprint714995737",
                SelfLink = "selfLink-1691268851",
                Zone = "zone2-696322977",
                Endpoint = "endpoint1741102485",
                InitialClusterVersion = "initialClusterVersion-276373352",
                CurrentMasterVersion = "currentMasterVersion-920953983",
                CurrentNodeVersion = "currentNodeVersion-407476063",
                CreateTime = "createTime-493574096",
                StatusMessage = "statusMessage-239442758",
                NodeIpv4CidrSize = 1181176815,
                ServicesIpv4Cidr = "servicesIpv4Cidr1966438125",
                CurrentNodeCount = 178977560,
                ExpireTime = "expireTime-96179731",
            };
            mockGrpcClient.Setup(x => x.GetCluster(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Cluster response = client.GetCluster(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetClusterAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            Cluster expectedResponse = new Cluster
            {
                Name = "name3373707",
                Description = "description-1724546052",
                InitialNodeCount = 1682564205,
                LoggingService = "loggingService-1700501035",
                MonitoringService = "monitoringService1469270462",
                Network = "network1843485230",
                ClusterIpv4Cidr = "clusterIpv4Cidr-141875831",
                Subnetwork = "subnetwork-1302785042",
                EnableKubernetesAlpha = false,
                LabelFingerprint = "labelFingerprint714995737",
                SelfLink = "selfLink-1691268851",
                Zone = "zone2-696322977",
                Endpoint = "endpoint1741102485",
                InitialClusterVersion = "initialClusterVersion-276373352",
                CurrentMasterVersion = "currentMasterVersion-920953983",
                CurrentNodeVersion = "currentNodeVersion-407476063",
                CreateTime = "createTime-493574096",
                StatusMessage = "statusMessage-239442758",
                NodeIpv4CidrSize = 1181176815,
                ServicesIpv4Cidr = "servicesIpv4Cidr1966438125",
                CurrentNodeCount = 178977560,
                ExpireTime = "expireTime-96179731",
            };
            mockGrpcClient.Setup(x => x.GetClusterAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Cluster>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Cluster response = await client.GetClusterAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateCluster()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            CreateClusterRequest expectedRequest = new CreateClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                Cluster = new Cluster(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.CreateCluster(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            Cluster cluster = new Cluster();
            Operation response = client.CreateCluster(projectId, zone, cluster);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateClusterAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            CreateClusterRequest expectedRequest = new CreateClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                Cluster = new Cluster(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.CreateClusterAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            Cluster cluster = new Cluster();
            Operation response = await client.CreateClusterAsync(projectId, zone, cluster);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateCluster2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            CreateClusterRequest request = new CreateClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                Cluster = new Cluster(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.CreateCluster(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.CreateCluster(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateClusterAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            CreateClusterRequest request = new CreateClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                Cluster = new Cluster(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.CreateClusterAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.CreateClusterAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateCluster()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            UpdateClusterRequest expectedRequest = new UpdateClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                Update = new ClusterUpdate(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.UpdateCluster(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            ClusterUpdate update = new ClusterUpdate();
            Operation response = client.UpdateCluster(projectId, zone, clusterId, update);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateClusterAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            UpdateClusterRequest expectedRequest = new UpdateClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                Update = new ClusterUpdate(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.UpdateClusterAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            ClusterUpdate update = new ClusterUpdate();
            Operation response = await client.UpdateClusterAsync(projectId, zone, clusterId, update);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateCluster2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                Update = new ClusterUpdate(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.UpdateCluster(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdateCluster(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateClusterAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                Update = new ClusterUpdate(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.UpdateClusterAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.UpdateClusterAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetLoggingService()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetLoggingServiceRequest expectedRequest = new SetLoggingServiceRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                LoggingService = "loggingService-1700501035",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetLoggingService(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string loggingService = "loggingService-1700501035";
            Operation response = client.SetLoggingService(projectId, zone, clusterId, loggingService);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetLoggingServiceAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetLoggingServiceRequest expectedRequest = new SetLoggingServiceRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                LoggingService = "loggingService-1700501035",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetLoggingServiceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string loggingService = "loggingService-1700501035";
            Operation response = await client.SetLoggingServiceAsync(projectId, zone, clusterId, loggingService);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetLoggingService2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetLoggingServiceRequest request = new SetLoggingServiceRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                LoggingService = "loggingService-1700501035",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetLoggingService(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLoggingService(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetLoggingServiceAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetLoggingServiceRequest request = new SetLoggingServiceRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                LoggingService = "loggingService-1700501035",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetLoggingServiceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.SetLoggingServiceAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetMonitoringService()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetMonitoringServiceRequest expectedRequest = new SetMonitoringServiceRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                MonitoringService = "monitoringService1469270462",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetMonitoringService(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string monitoringService = "monitoringService1469270462";
            Operation response = client.SetMonitoringService(projectId, zone, clusterId, monitoringService);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetMonitoringServiceAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetMonitoringServiceRequest expectedRequest = new SetMonitoringServiceRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                MonitoringService = "monitoringService1469270462",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetMonitoringServiceAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string monitoringService = "monitoringService1469270462";
            Operation response = await client.SetMonitoringServiceAsync(projectId, zone, clusterId, monitoringService);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetMonitoringService2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetMonitoringServiceRequest request = new SetMonitoringServiceRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                MonitoringService = "monitoringService1469270462",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetMonitoringService(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetMonitoringService(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetMonitoringServiceAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetMonitoringServiceRequest request = new SetMonitoringServiceRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                MonitoringService = "monitoringService1469270462",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetMonitoringServiceAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.SetMonitoringServiceAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetAddonsConfig()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetAddonsConfigRequest expectedRequest = new SetAddonsConfigRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                AddonsConfig = new AddonsConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetAddonsConfig(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            AddonsConfig addonsConfig = new AddonsConfig();
            Operation response = client.SetAddonsConfig(projectId, zone, clusterId, addonsConfig);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetAddonsConfigAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetAddonsConfigRequest expectedRequest = new SetAddonsConfigRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                AddonsConfig = new AddonsConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetAddonsConfigAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            AddonsConfig addonsConfig = new AddonsConfig();
            Operation response = await client.SetAddonsConfigAsync(projectId, zone, clusterId, addonsConfig);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetAddonsConfig2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetAddonsConfigRequest request = new SetAddonsConfigRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                AddonsConfig = new AddonsConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetAddonsConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetAddonsConfig(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetAddonsConfigAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetAddonsConfigRequest request = new SetAddonsConfigRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                AddonsConfig = new AddonsConfig(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetAddonsConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.SetAddonsConfigAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetLocations()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetLocationsRequest expectedRequest = new SetLocationsRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                Locations = { },
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetLocations(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            IEnumerable<string> locations = new List<string>();
            Operation response = client.SetLocations(projectId, zone, clusterId, locations);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetLocationsAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetLocationsRequest expectedRequest = new SetLocationsRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                Locations = { },
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetLocationsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            IEnumerable<string> locations = new List<string>();
            Operation response = await client.SetLocationsAsync(projectId, zone, clusterId, locations);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetLocations2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetLocationsRequest request = new SetLocationsRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                Locations = { },
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetLocations(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLocations(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetLocationsAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetLocationsRequest request = new SetLocationsRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                Locations = { },
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetLocationsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.SetLocationsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateMaster()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            UpdateMasterRequest expectedRequest = new UpdateMasterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                MasterVersion = "masterVersion-2139460613",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.UpdateMaster(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string masterVersion = "masterVersion-2139460613";
            Operation response = client.UpdateMaster(projectId, zone, clusterId, masterVersion);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateMasterAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            UpdateMasterRequest expectedRequest = new UpdateMasterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                MasterVersion = "masterVersion-2139460613",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.UpdateMasterAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string masterVersion = "masterVersion-2139460613";
            Operation response = await client.UpdateMasterAsync(projectId, zone, clusterId, masterVersion);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateMaster2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            UpdateMasterRequest request = new UpdateMasterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                MasterVersion = "masterVersion-2139460613",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.UpdateMaster(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdateMaster(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateMasterAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            UpdateMasterRequest request = new UpdateMasterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                MasterVersion = "masterVersion-2139460613",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.UpdateMasterAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.UpdateMasterAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteCluster()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            DeleteClusterRequest expectedRequest = new DeleteClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.DeleteCluster(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            Operation response = client.DeleteCluster(projectId, zone, clusterId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteClusterAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            DeleteClusterRequest expectedRequest = new DeleteClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.DeleteClusterAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            Operation response = await client.DeleteClusterAsync(projectId, zone, clusterId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteCluster2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.DeleteCluster(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeleteCluster(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteClusterAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.DeleteClusterAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.DeleteClusterAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListOperations()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            ListOperationsRequest expectedRequest = new ListOperationsRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
            };
            ListOperationsResponse expectedResponse = new ListOperationsResponse();
            mockGrpcClient.Setup(x => x.ListOperations(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            ListOperationsResponse response = client.ListOperations(projectId, zone);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListOperationsAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            ListOperationsRequest expectedRequest = new ListOperationsRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
            };
            ListOperationsResponse expectedResponse = new ListOperationsResponse();
            mockGrpcClient.Setup(x => x.ListOperationsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListOperationsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            ListOperationsResponse response = await client.ListOperationsAsync(projectId, zone);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListOperations2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            ListOperationsRequest request = new ListOperationsRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
            };
            ListOperationsResponse expectedResponse = new ListOperationsResponse();
            mockGrpcClient.Setup(x => x.ListOperations(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListOperationsResponse response = client.ListOperations(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListOperationsAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            ListOperationsRequest request = new ListOperationsRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
            };
            ListOperationsResponse expectedResponse = new ListOperationsResponse();
            mockGrpcClient.Setup(x => x.ListOperationsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListOperationsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListOperationsResponse response = await client.ListOperationsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetOperation()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            GetOperationRequest expectedRequest = new GetOperationRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                OperationId = "operationId-274116877",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.GetOperation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string operationId = "operationId-274116877";
            Operation response = client.GetOperation(projectId, zone, operationId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetOperationAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            GetOperationRequest expectedRequest = new GetOperationRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                OperationId = "operationId-274116877",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.GetOperationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string operationId = "operationId-274116877";
            Operation response = await client.GetOperationAsync(projectId, zone, operationId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetOperation2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            GetOperationRequest request = new GetOperationRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                OperationId = "operationId-274116877",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.GetOperation(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.GetOperation(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetOperationAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            GetOperationRequest request = new GetOperationRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                OperationId = "operationId-274116877",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.GetOperationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.GetOperationAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CancelOperation()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            CancelOperationRequest expectedRequest = new CancelOperationRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                OperationId = "operationId-274116877",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.CancelOperation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string operationId = "operationId-274116877";
            client.CancelOperation(projectId, zone, operationId);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CancelOperationAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            CancelOperationRequest expectedRequest = new CancelOperationRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                OperationId = "operationId-274116877",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.CancelOperationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string operationId = "operationId-274116877";
            await client.CancelOperationAsync(projectId, zone, operationId);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CancelOperation2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            CancelOperationRequest request = new CancelOperationRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                OperationId = "operationId-274116877",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.CancelOperation(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            client.CancelOperation(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CancelOperationAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            CancelOperationRequest request = new CancelOperationRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                OperationId = "operationId-274116877",
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.CancelOperationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            await client.CancelOperationAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetServerConfig()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            GetServerConfigRequest expectedRequest = new GetServerConfigRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
            };
            ServerConfig expectedResponse = new ServerConfig
            {
                DefaultClusterVersion = "defaultClusterVersion111003029",
                DefaultImageType = "defaultImageType-918225828",
            };
            mockGrpcClient.Setup(x => x.GetServerConfig(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            ServerConfig response = client.GetServerConfig(projectId, zone);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetServerConfigAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            GetServerConfigRequest expectedRequest = new GetServerConfigRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
            };
            ServerConfig expectedResponse = new ServerConfig
            {
                DefaultClusterVersion = "defaultClusterVersion111003029",
                DefaultImageType = "defaultImageType-918225828",
            };
            mockGrpcClient.Setup(x => x.GetServerConfigAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ServerConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            ServerConfig response = await client.GetServerConfigAsync(projectId, zone);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetServerConfig2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            GetServerConfigRequest request = new GetServerConfigRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
            };
            ServerConfig expectedResponse = new ServerConfig
            {
                DefaultClusterVersion = "defaultClusterVersion111003029",
                DefaultImageType = "defaultImageType-918225828",
            };
            mockGrpcClient.Setup(x => x.GetServerConfig(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ServerConfig response = client.GetServerConfig(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetServerConfigAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            GetServerConfigRequest request = new GetServerConfigRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
            };
            ServerConfig expectedResponse = new ServerConfig
            {
                DefaultClusterVersion = "defaultClusterVersion111003029",
                DefaultImageType = "defaultImageType-918225828",
            };
            mockGrpcClient.Setup(x => x.GetServerConfigAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ServerConfig>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ServerConfig response = await client.GetServerConfigAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListNodePools()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            ListNodePoolsRequest expectedRequest = new ListNodePoolsRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            ListNodePoolsResponse expectedResponse = new ListNodePoolsResponse();
            mockGrpcClient.Setup(x => x.ListNodePools(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            ListNodePoolsResponse response = client.ListNodePools(projectId, zone, clusterId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListNodePoolsAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            ListNodePoolsRequest expectedRequest = new ListNodePoolsRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            ListNodePoolsResponse expectedResponse = new ListNodePoolsResponse();
            mockGrpcClient.Setup(x => x.ListNodePoolsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListNodePoolsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            ListNodePoolsResponse response = await client.ListNodePoolsAsync(projectId, zone, clusterId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListNodePools2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            ListNodePoolsRequest request = new ListNodePoolsRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            ListNodePoolsResponse expectedResponse = new ListNodePoolsResponse();
            mockGrpcClient.Setup(x => x.ListNodePools(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListNodePoolsResponse response = client.ListNodePools(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListNodePoolsAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            ListNodePoolsRequest request = new ListNodePoolsRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            ListNodePoolsResponse expectedResponse = new ListNodePoolsResponse();
            mockGrpcClient.Setup(x => x.ListNodePoolsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListNodePoolsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            ListNodePoolsResponse response = await client.ListNodePoolsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetNodePool()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            GetNodePoolRequest expectedRequest = new GetNodePoolRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NodePoolId = "nodePoolId1043384033",
            };
            NodePool expectedResponse = new NodePool
            {
                Name = "name3373707",
                InitialNodeCount = 1682564205,
                SelfLink = "selfLink-1691268851",
                Version = "version351608024",
                StatusMessage = "statusMessage-239442758",
            };
            mockGrpcClient.Setup(x => x.GetNodePool(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string nodePoolId = "nodePoolId1043384033";
            NodePool response = client.GetNodePool(projectId, zone, clusterId, nodePoolId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetNodePoolAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            GetNodePoolRequest expectedRequest = new GetNodePoolRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NodePoolId = "nodePoolId1043384033",
            };
            NodePool expectedResponse = new NodePool
            {
                Name = "name3373707",
                InitialNodeCount = 1682564205,
                SelfLink = "selfLink-1691268851",
                Version = "version351608024",
                StatusMessage = "statusMessage-239442758",
            };
            mockGrpcClient.Setup(x => x.GetNodePoolAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<NodePool>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string nodePoolId = "nodePoolId1043384033";
            NodePool response = await client.GetNodePoolAsync(projectId, zone, clusterId, nodePoolId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetNodePool2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            GetNodePoolRequest request = new GetNodePoolRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NodePoolId = "nodePoolId1043384033",
            };
            NodePool expectedResponse = new NodePool
            {
                Name = "name3373707",
                InitialNodeCount = 1682564205,
                SelfLink = "selfLink-1691268851",
                Version = "version351608024",
                StatusMessage = "statusMessage-239442758",
            };
            mockGrpcClient.Setup(x => x.GetNodePool(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            NodePool response = client.GetNodePool(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetNodePoolAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            GetNodePoolRequest request = new GetNodePoolRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NodePoolId = "nodePoolId1043384033",
            };
            NodePool expectedResponse = new NodePool
            {
                Name = "name3373707",
                InitialNodeCount = 1682564205,
                SelfLink = "selfLink-1691268851",
                Version = "version351608024",
                StatusMessage = "statusMessage-239442758",
            };
            mockGrpcClient.Setup(x => x.GetNodePoolAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<NodePool>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            NodePool response = await client.GetNodePoolAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateNodePool()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            CreateNodePoolRequest expectedRequest = new CreateNodePoolRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NodePool = new NodePool(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.CreateNodePool(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            NodePool nodePool = new NodePool();
            Operation response = client.CreateNodePool(projectId, zone, clusterId, nodePool);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateNodePoolAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            CreateNodePoolRequest expectedRequest = new CreateNodePoolRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NodePool = new NodePool(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.CreateNodePoolAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            NodePool nodePool = new NodePool();
            Operation response = await client.CreateNodePoolAsync(projectId, zone, clusterId, nodePool);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateNodePool2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            CreateNodePoolRequest request = new CreateNodePoolRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NodePool = new NodePool(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.CreateNodePool(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.CreateNodePool(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateNodePoolAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            CreateNodePoolRequest request = new CreateNodePoolRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NodePool = new NodePool(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.CreateNodePoolAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.CreateNodePoolAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteNodePool()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            DeleteNodePoolRequest expectedRequest = new DeleteNodePoolRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NodePoolId = "nodePoolId1043384033",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.DeleteNodePool(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string nodePoolId = "nodePoolId1043384033";
            Operation response = client.DeleteNodePool(projectId, zone, clusterId, nodePoolId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteNodePoolAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            DeleteNodePoolRequest expectedRequest = new DeleteNodePoolRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NodePoolId = "nodePoolId1043384033",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.DeleteNodePoolAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string nodePoolId = "nodePoolId1043384033";
            Operation response = await client.DeleteNodePoolAsync(projectId, zone, clusterId, nodePoolId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteNodePool2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            DeleteNodePoolRequest request = new DeleteNodePoolRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NodePoolId = "nodePoolId1043384033",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.DeleteNodePool(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.DeleteNodePool(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteNodePoolAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            DeleteNodePoolRequest request = new DeleteNodePoolRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NodePoolId = "nodePoolId1043384033",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.DeleteNodePoolAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.DeleteNodePoolAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RollbackNodePoolUpgrade()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            RollbackNodePoolUpgradeRequest expectedRequest = new RollbackNodePoolUpgradeRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NodePoolId = "nodePoolId1043384033",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.RollbackNodePoolUpgrade(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string nodePoolId = "nodePoolId1043384033";
            Operation response = client.RollbackNodePoolUpgrade(projectId, zone, clusterId, nodePoolId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RollbackNodePoolUpgradeAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            RollbackNodePoolUpgradeRequest expectedRequest = new RollbackNodePoolUpgradeRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NodePoolId = "nodePoolId1043384033",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.RollbackNodePoolUpgradeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            string nodePoolId = "nodePoolId1043384033";
            Operation response = await client.RollbackNodePoolUpgradeAsync(projectId, zone, clusterId, nodePoolId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RollbackNodePoolUpgrade2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            RollbackNodePoolUpgradeRequest request = new RollbackNodePoolUpgradeRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NodePoolId = "nodePoolId1043384033",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.RollbackNodePoolUpgrade(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RollbackNodePoolUpgrade(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RollbackNodePoolUpgradeAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            RollbackNodePoolUpgradeRequest request = new RollbackNodePoolUpgradeRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NodePoolId = "nodePoolId1043384033",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.RollbackNodePoolUpgradeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.RollbackNodePoolUpgradeAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetLegacyAbac()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetLegacyAbacRequest expectedRequest = new SetLegacyAbacRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                Enabled = false,
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetLegacyAbac(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            bool enabled = false;
            Operation response = client.SetLegacyAbac(projectId, zone, clusterId, enabled);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetLegacyAbacAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetLegacyAbacRequest expectedRequest = new SetLegacyAbacRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                Enabled = false,
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetLegacyAbacAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            bool enabled = false;
            Operation response = await client.SetLegacyAbacAsync(projectId, zone, clusterId, enabled);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetLegacyAbac2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetLegacyAbacRequest request = new SetLegacyAbacRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                Enabled = false,
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetLegacyAbac(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLegacyAbac(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetLegacyAbacAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetLegacyAbacRequest request = new SetLegacyAbacRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                Enabled = false,
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetLegacyAbacAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.SetLegacyAbacAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void StartIPRotation()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            StartIPRotationRequest expectedRequest = new StartIPRotationRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.StartIPRotation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            Operation response = client.StartIPRotation(projectId, zone, clusterId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task StartIPRotationAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            StartIPRotationRequest expectedRequest = new StartIPRotationRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.StartIPRotationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            Operation response = await client.StartIPRotationAsync(projectId, zone, clusterId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void StartIPRotation2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            StartIPRotationRequest request = new StartIPRotationRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.StartIPRotation(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.StartIPRotation(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task StartIPRotationAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            StartIPRotationRequest request = new StartIPRotationRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.StartIPRotationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.StartIPRotationAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CompleteIPRotation()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            CompleteIPRotationRequest expectedRequest = new CompleteIPRotationRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.CompleteIPRotation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            Operation response = client.CompleteIPRotation(projectId, zone, clusterId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CompleteIPRotationAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            CompleteIPRotationRequest expectedRequest = new CompleteIPRotationRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.CompleteIPRotationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            Operation response = await client.CompleteIPRotationAsync(projectId, zone, clusterId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CompleteIPRotation2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            CompleteIPRotationRequest request = new CompleteIPRotationRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.CompleteIPRotation(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.CompleteIPRotation(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CompleteIPRotationAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            CompleteIPRotationRequest request = new CompleteIPRotationRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.CompleteIPRotationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.CompleteIPRotationAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetNetworkPolicy()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetNetworkPolicyRequest expectedRequest = new SetNetworkPolicyRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NetworkPolicy = new NetworkPolicy(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetNetworkPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            NetworkPolicy networkPolicy = new NetworkPolicy();
            Operation response = client.SetNetworkPolicy(projectId, zone, clusterId, networkPolicy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetNetworkPolicyAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetNetworkPolicyRequest expectedRequest = new SetNetworkPolicyRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NetworkPolicy = new NetworkPolicy(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetNetworkPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            NetworkPolicy networkPolicy = new NetworkPolicy();
            Operation response = await client.SetNetworkPolicyAsync(projectId, zone, clusterId, networkPolicy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetNetworkPolicy2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetNetworkPolicyRequest request = new SetNetworkPolicyRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NetworkPolicy = new NetworkPolicy(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetNetworkPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetNetworkPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetNetworkPolicyAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetNetworkPolicyRequest request = new SetNetworkPolicyRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                NetworkPolicy = new NetworkPolicy(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetNetworkPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.SetNetworkPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetMaintenancePolicy()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetMaintenancePolicyRequest expectedRequest = new SetMaintenancePolicyRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                MaintenancePolicy = new MaintenancePolicy(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetMaintenancePolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            MaintenancePolicy maintenancePolicy = new MaintenancePolicy();
            Operation response = client.SetMaintenancePolicy(projectId, zone, clusterId, maintenancePolicy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetMaintenancePolicyAsync()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetMaintenancePolicyRequest expectedRequest = new SetMaintenancePolicyRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                MaintenancePolicy = new MaintenancePolicy(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetMaintenancePolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            string zone = "zone3744684";
            string clusterId = "clusterId240280960";
            MaintenancePolicy maintenancePolicy = new MaintenancePolicy();
            Operation response = await client.SetMaintenancePolicyAsync(projectId, zone, clusterId, maintenancePolicy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetMaintenancePolicy2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetMaintenancePolicyRequest request = new SetMaintenancePolicyRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                MaintenancePolicy = new MaintenancePolicy(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetMaintenancePolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetMaintenancePolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetMaintenancePolicyAsync2()
        {
            Mock<ClusterManager.ClusterManagerClient> mockGrpcClient = new Mock<ClusterManager.ClusterManagerClient>(MockBehavior.Strict);
            SetMaintenancePolicyRequest request = new SetMaintenancePolicyRequest
            {
                ProjectId = "projectId-1969970175",
                Zone = "zone3744684",
                ClusterId = "clusterId240280960",
                MaintenancePolicy = new MaintenancePolicy(),
            };
            Operation expectedResponse = new Operation
            {
                Name = "name3373707",
                Zone = "zone2-696322977",
                Detail = "detail-1335224239",
                StatusMessage = "statusMessage-239442758",
                SelfLink = "selfLink-1691268851",
                TargetLink = "targetLink-2084812312",
                StartTime = "startTime-1573145462",
                EndTime = "endTime1725551537",
            };
            mockGrpcClient.Setup(x => x.SetMaintenancePolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Operation>(Task.FromResult(expectedResponse), null, null, null, null));
            ClusterManagerClient client = new ClusterManagerClientImpl(mockGrpcClient.Object, null);
            Operation response = await client.SetMaintenancePolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
