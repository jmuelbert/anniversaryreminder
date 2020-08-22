rem clear old packages
for %%i in (src\AnniversaryReminder\bin\Release\*.nupkg) do del /q/a/f/s %%i
rem build
dotnet build AnniversaryReminder.sln -c Release
rem upload new packages
for %%i in (src\AnniversaryReminder\bin\Release\*.nupkg) do nuget push %%i -Source https://www.nuget.org/api/v2/package
