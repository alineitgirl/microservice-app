FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["PlatformService/PlatformService.csproj", "PlatformService/"]
RUN dotnet restore "PlatformService/PlatformService.csproj"

COPY . .
WORKDIR "/src/PlatformService"

RUN dotnet build "PlatformService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PlatformService.csproj" -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .


EXPOSE 8080
ENTRYPOINT ["dotnet", "PlatformService.dll"]
