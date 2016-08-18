@echo off

REM Clean up
if exist _site rmdir /s /q _site
if exist obj rmdir /s /q obj
if exist external rmdir /s /q external

REM Fetch external sources we're including in the same docset
mkdir external
git clone https://github.com/googleapis/gax-dotnet.git external\gax-dotnet --depth=1
IF ERRORLEVEL 1 EXIT /B 1

REM Restore all the required packages
dotnet restore external\gax-dotnet
IF ERRORLEVEL 1 EXIT /B 1

REM Extract metadata from code (this project and the external ones)
call docfx metadata -f
IF ERRORLEVEL 1 EXIT /B 1

REM Extract snippets
dotnet run -p ..\tools\Google.GCloud.Tools.GenerateSnippetMarkdown
IF ERRORLEVEL 1 EXIT /B 1

REM Build the site itself
call docfx build
IF ERRORLEVEL 1 EXIT /B 1
