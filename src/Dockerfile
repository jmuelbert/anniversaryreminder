FROM microsoft/dotnet:2.1-sdk
COPY anniversaryreminder /app/anniversaryreminder
COPY entrypoint.sh /app/anniversaryreminder
WORKDIR /app/anniversaryreminder
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
EXPOSE 80/tcp
RUN chmod +x ./entrypoint.sh
