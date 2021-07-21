#!/bin/bash

set -e

# There are subdirectories of v1, but their proto package (and C# options)
# put the subdirectory name *before* the v1. These are used in LROs, so we
# can't change the proto package, but we can make them easier to work with in C#
# by switching around the last two parts of the csharp_namespace option.
for proto in $(find $GOOGLEAPIS/google/cloud/gkehub/v1 -name '*.proto')
do
  sed -i 's/option csharp_namespace = "Google.Cloud.GkeHub.\([^.]*\).V1"/option csharp_namespace = "Google.Cloud.GkeHub.V1.\1"/g' $proto
done
