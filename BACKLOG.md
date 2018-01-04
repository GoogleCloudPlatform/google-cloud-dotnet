# Requested enhancements backlog

This file is used to keep track of feature requests that we *may*
want to come back to at some point, but aren't on our immediate
radar. Using this single document is simpler than keeping all the
corresponding issues open, but we'll reopen the issue if we revisit
the request and want to put work into it.

## Static code analysis

- Issue: [#1709](https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/1709)
- Status: Further investigation required. We already have
  some analysis in the form of custom Roslyn analyzers.

## Metadata client failure

- Issue: [#1568](https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/1568)
- Status: Metadata client is low priority right now; needs
  some more investigation
  
## Storage client-side encryption

- Issue: [#1451](https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/1451)
- Status: More details required.
  
## Provide F# samples

- Issue: [#682](https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/682)
- Status: "Nice to have" but significant investment in terms of
  infrastructure/planning.

## Detect dev/non-dev environment in diagnostic libraries

- Issue: [#829](https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/829)
- Status: More consideration and customer feedback required.

## Dispose of ErrorReportingExceptionFilter

- Issue: [#803](https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/803)
- Status: Resources are alive as long as the application is anyway.

## Allow BigQuery Struct parameters to be specified

- Issue: [#500](https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/500)
- Status: No customer requests for this yet; can implement when
  reqiured.

## Improve handling of Markdown from protos

- Issue: [#110](https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/110)
- Status: Ideally, protoc should do this. Massive work item, no
  funding right now.
