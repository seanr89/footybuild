# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
 
COPY . ./
RUN dotnet restore footy.app.sln

COPY . ./
RUN dotnet build -o /app
RUN dotnet publish -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
COPY --from=build  /publish /app
WORKDIR /app
EXPOSE 80
ENTRYPOINT ["dotnet", "footy.api.dll"]
# CMD ["./footy.api"]