#!/bin/bash

set -e

source toolversions.sh
declare -r CORE_PROTOS_ROOT=$PROTOBUF_TOOLS_ROOT/tools
declare -r BASH=/c/Windows/System32/bash.exe

# This script generates all APIs from the googleapis/googleapis github repository,
# using the code generator from googleapis/gapic-generator.
# It will fetch both repositories if necessary.

# Currently it will only work on Windows due to the way nuget packages installed;
# changing toolversions.sh could mitigate that, if it's ever necessary.
#
# Most of the script can be run directly in Windows, but the codegen itself has to be
# run via Windows Subsystem for Linux due to a bug in a subproject.
# Prerequisites
# - Bash as supplied with Windows git
# - Windows Subsystem for Linux with Ubuntu 16.04, including Java 8 (e.g. openjdk-8-jdk-headless)
# - git
# - wget
# - unzip

# Running on Linux
# Prerequisites:
# - git
# - wget
# - unzip
# - Java 8 (e.g. openjdk-8-jdk-headless)

OUTDIR=tmp

fetch_github_repos() {
  if [ -d "gapic-generator" ]
  then
    git -C gapic-generator pull
    git -C gapic-generator submodule update
  else
    git clone --recursive https://github.com/googleapis/gapic-generator \
      --config core.autocrlf=false \
      --config core.eol=lf
  fi
          
  if [ -d "googleapis" ]
  then
    git -C googleapis pull
  else
    # Auto-detect whether we're cloning the public or private googleapis repo.
    git remote -v | grep -q google-cloud-dotnet-private && repo=googleapis-private || repo=googleapis
    git clone --recursive https://github.com/googleapis/${repo} googleapis
  fi
}

generate_api() {
  API_TMP_DIR=$OUTDIR/$1
  API_OUT_DIR=apis
  API_SRC_DIR=googleapis/$2
  API_YAML=$API_SRC_DIR/../$3

  if [[ ! -f $API_YAML ]]
  then
    echo "$API_YAML doesn't exist. Please check inputs."
    exit 1
  fi

  echo Generating $1
  mkdir $API_TMP_DIR
  
  # There should be only one gapic yaml file...
  for i in $API_SRC_DIR/*_gapic.yaml
  do
    cp $i $API_TMP_DIR/gapic.yaml
  done
  cat >> $API_TMP_DIR/gapic.yaml << EOF
language: csharp
generator:
  factory: com.google.api.codegen.gapic.MainGapicProviderFactory
  id: csharp
EOF
  
  args=()
  args+=(--descriptor_set=$OUTDIR/protos.desc)
  args+=(--service_yaml=$API_YAML)
  args+=(--gapic_yaml=$API_TMP_DIR/gapic.yaml)
  args+=(--package_yaml=$OUTDIR/package.yaml)
  args+=(--output=$API_TMP_DIR)
  
  $BASH -c "java -cp gapic-generator/build/libs/gapic-generator-${GAPIC_GENERATOR_VERSION}-all.jar com.google.api.codegen.CodeGeneratorTool ${args[*]}"
  
  # We don't want to copy the snippet/prod/tests project files,
  # but the smoke test project file is okay, as we don't
  # customize that.
  rm -f `find $API_TMP_DIR -type f -name $1.Snippets.csproj`
  rm -f `find $API_TMP_DIR -type f -name $1.Tests.csproj`
  rm -f `find $API_TMP_DIR -type f -name $1.csproj`
  cp -r $API_TMP_DIR/$1 $API_OUT_DIR

  # Generate the C# protos/gRPC directly into the right directory
  # This assumes they all belong to the same API, and are in the same namespace...
  $PROTOC \
    --csharp_out=$API_OUT_DIR/$1/$1 \
    --grpc_out=$API_OUT_DIR/$1/$1 \
    -I googleapis \
    -I $CORE_PROTOS_ROOT \
    --plugin=protoc-gen-grpc=$GRPC_PLUGIN \
    $API_SRC_DIR/*.proto
}

# Entry point

install_protoc
install_grpc  
fetch_github_repos
GAPIC_GENERATOR_VERSION=$(cat gapic-generator/version.txt)

# Build GAPIC generator once with gradle so we can invoke it from Java directly
# once per API.
(cd gapic-generator; ./gradlew shadowJar)

OUTDIR=tmp
rm -rf $OUTDIR
mkdir $OUTDIR

# Fake package.yaml file that's just enough to make GAPIC generator happy.
# We don't use this project file for anything (we don't even move it into place)
# but GAPIC generator doesn't have an option to not generate it.

cat > $OUTDIR/package.yaml <<END_OF_FILE
package_type: grpc_client
short_name: fake
package_name: {default: fake}
gax_version: {csharp: {lower: 0.0.0}}
grpc_version: {csharp: {lower: 0.0.0}}
proto_version: {csharp: {lower: 0.0.0}}
gax_grpc_version: {csharp: {lower: 0.0.0}}
auth_version: {csharp: {lower: 0.0.0}}
generated_package_version: {csharp: {lower: 0.0.0}}
generated_ga_package_version: {csharp: {lower: 0.0.0}}
api_common_version: {csharp: {lower: 0.0.0}}
release_level: {csharp: alpha}
proto_deps: []
major_version: v0
proto_path: fake
author: fake
homepage: fake
license: fake
email: fake
gapic_config_name: fake
END_OF_FILE


# Generate a single descriptor file for all protos we may care about.
# We can then reuse that for all APIs.
$PROTOC \
  -I googleapis \
  -I $CORE_PROTOS_ROOT \
  --include_source_info \
  -o $OUTDIR/protos.desc \
  $CORE_PROTOS_ROOT/google/protobuf/*.proto \
  `find googleapis/google -name '*.proto'`

# Generate LongRunning, after changing the license text (because we use
# Apache for LRO where other languages use BSD)
sed -i s/license-header-bsd-3-clause.txt/license-header-apache-2.0.txt/g googleapis/google/longrunning/longrunning_gapic.yaml
generate_api Google.LongRunning google/longrunning longrunning/longrunning.yaml
git -C googleapis checkout google/longrunning/longrunning_gapic.yaml

# IAM (just proto and grpc)
$PROTOC \
  --csharp_out=apis/Google.Cloud.Iam.V1/Google.Cloud.Iam.V1 \
  --grpc_out=apis/Google.Cloud.Iam.V1/Google.Cloud.Iam.V1 \
  -I googleapis \
  -I $CORE_PROTOS_ROOT \
  --plugin=protoc-gen-grpc=$GRPC_PLUGIN \
  googleapis/google/iam/v1/*.proto

# Logging version-agnostic types
$PROTOC \
  --csharp_out=apis/Google.Cloud.Logging.Type/Google.Cloud.Logging.Type \
  -I googleapis \
  -I $CORE_PROTOS_ROOT \
  googleapis/google/logging/type/*.proto

# OS Login version-agnostic types
$PROTOC \
  --csharp_out=apis/Google.Cloud.OsLogin.Common/Google.Cloud.OsLogin.Common \
  -I googleapis \
  -I $CORE_PROTOS_ROOT \
  googleapis/google/cloud/oslogin/common/*.proto

# Now the per-API codegen
generate_api Google.Cloud.BigQuery.DataTransfer.V1 google/cloud/bigquery/datatransfer/v1 datatransfer.yaml
generate_api Google.Cloud.Bigtable.Admin.V2 google/bigtable/admin/v2 bigtableadmin.yaml
generate_api Google.Cloud.Bigtable.V2 google/bigtable/v2 bigtable.yaml
generate_api Google.Cloud.Container.V1 google/container/v1 container.yaml
generate_api Google.Cloud.Dataproc.V1 google/cloud/dataproc/v1 v1/dataproc.yaml
generate_api Google.Cloud.Datastore.V1 google/datastore/v1 datastore.yaml
generate_api Google.Cloud.Debugger.V2 google/devtools/clouddebugger/v2 clouddebugger.yaml
generate_api Google.Cloud.Dialogflow.V2 google/cloud/dialogflow/v2 dialogflow_v2.yaml
generate_api Google.Cloud.Dlp.V2 google/privacy/dlp/v2 dlp_v2.yaml
generate_api Google.Cloud.ErrorReporting.V1Beta1 google/devtools/clouderrorreporting/v1beta1 errorreporting.yaml
generate_api Google.Cloud.Firestore.V1Beta1 google/firestore/v1beta1 firestore.yaml
generate_api Google.Cloud.Language.V1 google/cloud/language/v1 language_v1.yaml
generate_api Google.Cloud.Logging.V2 google/logging/v2 logging.yaml
generate_api Google.Cloud.Monitoring.V3 google/monitoring/v3 monitoring.yaml
generate_api Google.Cloud.OsLogin.V1 google/cloud/oslogin/v1 oslogin_v1.yaml
generate_api Google.Cloud.OsLogin.V1Beta google/cloud/oslogin/v1beta oslogin_v1beta.yaml
generate_api Google.Cloud.PubSub.V1 google/pubsub/v1 pubsub.yaml
generate_api Google.Cloud.Redis.V1Beta1 google/cloud/redis/v1beta1 redis_v1beta1.yaml
generate_api Google.Cloud.Spanner.Admin.Database.V1 google/spanner/admin/database/v1 spanner_admin_database.yaml
generate_api Google.Cloud.Spanner.Admin.Instance.V1 google/spanner/admin/instance/v1 spanner_admin_instance.yaml
generate_api Google.Cloud.Spanner.V1 google/spanner/v1 spanner.yaml
generate_api Google.Cloud.Speech.V1 google/cloud/speech/v1 speech_v1.yaml
generate_api Google.Cloud.Tasks.V2Beta2 google/cloud/tasks/v2beta2 cloudtasks.yaml
generate_api Google.Cloud.TextToSpeech.V1 google/cloud/texttospeech/v1 tts_v1.yaml
generate_api Google.Cloud.Trace.V1 google/devtools/cloudtrace/v1 cloudtrace_v1.yaml
generate_api Google.Cloud.Trace.V2 google/devtools/cloudtrace/v2 cloudtrace_v2.yaml
generate_api Google.Cloud.VideoIntelligence.V1 google/cloud/videointelligence/v1 videointelligence_v1.yaml
generate_api Google.Cloud.Vision.V1 google/cloud/vision/v1 vision_v1.yaml
generate_api Google.Cloud.Vision.V1P1Beta1 google/cloud/vision/v1p1beta1 vision_v1p1beta1.yaml
generate_api Google.Cloud.Vision.V1P2Beta1 google/cloud/vision/v1p2beta1 vision_v1p2beta1.yaml

dotnet run -f net461 -p apis/Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2.GenerateClient \
 apis/Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2.csproj \
 BigtableServiceApiClient \
 BigtableClient

# Temporary fix-up for DLP; the gRPC protoc plugin doesn't use
# fully-qualified names everywhere in the version we're using.
# This hack can be removed when the next version of gRPC is released.
sed -i 's/ DateTime?/ global::System.DateTime?/g' apis/Google.Cloud.Dlp.V2/Google.Cloud.Dlp.V2/DlpGrpc.cs
