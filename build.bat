rem build
dotnet build AnniversaryReminder.sln -c Release
nuget push %%i -Source http://zlzforever.6655.la:40001/nuget