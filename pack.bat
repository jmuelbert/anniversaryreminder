rem build
dotnet build AnniversaryReminder.sln -c Release
cd %cd%\nuget
rem clear old nuget packages
for %%i in (*.nupkg) do del /q/a/f/s %%i
rem create nuget packages
nuget pack AnniversaryReminder.nuspec
cd ..