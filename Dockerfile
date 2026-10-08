FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["TrackTruck.Platform.API/TrackTruck.Platform.API.csproj", "TrackTruck.Platform.API/"]
RUN dotnet restore "TrackTruck.Platform.API/TrackTruck.Platform.API.csproj"

COPY . .

WORKDIR "/src/TrackTruck.Platform.API"
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:${PORT:-8080}
EXPOSE ${PORT:-8080}

ENTRYPOINT ["dotnet", "TrackTruck.Platform.API.dll"]