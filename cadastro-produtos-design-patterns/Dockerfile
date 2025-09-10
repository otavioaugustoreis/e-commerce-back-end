#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["cadastro-produtos-design-patterns/cadastro-produtos-design-patterns.csproj", "cadastro-produtos-design-patterns/"]
COPY ["Cadastro.Application/Cadastro.Application.csproj", "Cadastro.Application/"]
COPY ["Cadastro.Data/Cadastro.Data.csproj", "Cadastro.Data/"]
COPY ["Cadastro.Domain/Cadastro.Domain.csproj", "Cadastro.Domain/"]
RUN dotnet restore "./cadastro-produtos-design-patterns/cadastro-produtos-design-patterns.csproj"
COPY . .
WORKDIR "/src/cadastro-produtos-design-patterns"
RUN dotnet build "./cadastro-produtos-design-patterns.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./cadastro-produtos-design-patterns.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cadastro-produtos-design-patterns.dll"]