#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Src/03.EndPoint/Api/Api.csproj", "Src/03.EndPoint/Api/"]
COPY ["Src/01.Core/ApplicationServices/ApplicationServices.csproj", "Src/01.Core/ApplicationServices/"]
COPY ["Src/01.Core/DomainClass/DomainClass.csproj", "Src/01.Core/DomainClass/"]
COPY ["Src/02.Infrastructures/DataLayer.SqlServer/DataLayer.SqlServer.csproj", "Src/02.Infrastructures/DataLayer.SqlServer/"]
RUN dotnet restore "./Src/03.EndPoint/Api/./Api.csproj"
COPY . .
WORKDIR "/src/Src/03.EndPoint/Api"
RUN dotnet build "./Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.dll"]