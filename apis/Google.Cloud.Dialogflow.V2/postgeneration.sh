#!/bin/bash

set -e

# Undo the changes made in pregeneration.sh
git -C $GOOGLEAPIS checkout google/cloud/dialogflow/v2
