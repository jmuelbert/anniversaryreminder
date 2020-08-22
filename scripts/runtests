#!/bin/sh
msbuild /p:RunCodeAnalysis=true
dotnet --info
dotnet test test/AnniversaryReminder.Tests/AnniversaryReminder.Tests.csproj -f netcoreapp3.1 -c release
