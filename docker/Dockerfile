FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src/jmbde

# copy csproj and restore as distinct layers
COPY *.csproj .
RUN dotnet restore

# copy and publish app and libraries
COPY . .
RUN dotnet publish -c release -o /app --no-restore


COPY RazorUIClassLib /app/RazorUIClassLib

# final stage/image
FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS RE
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["./dotnetapp"]
