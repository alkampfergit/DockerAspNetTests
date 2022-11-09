FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS build
WORKDIR /app
COPY "./TestFs/bin/Release/net6.0/publish" "/app"
ENTRYPOINT ["dotnet", "TestFs.dll"]