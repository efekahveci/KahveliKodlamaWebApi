#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["KahveliKodlama/KahveliKodlama.API.csproj", "KahveliKodlama/"]
COPY ["KahveliKodlama.Infrastructure/KahveliKodlama.Infrastructure/KahveliKodlama.Infrastructure.csproj", "KahveliKodlama.Infrastructure/KahveliKodlama.Infrastructure/"]
COPY ["KahveliKodlama.Persistence/KahveliKodlama.Persistence/KahveliKodlama.Persistence.csproj", "KahveliKodlama.Persistence/KahveliKodlama.Persistence/"]
COPY ["KahveliKodlama.Application/KahveliKodlama.Application/KahveliKodlama.Application.csproj", "KahveliKodlama.Application/KahveliKodlama.Application/"]
COPY ["KahveliKodlama.Domain/KahveliKodlama.Domain/KahveliKodlama.Domain.csproj", "KahveliKodlama.Domain/KahveliKodlama.Domain/"]
COPY ["KahveliKodlama.Core/KahveliKodlama.Core/KahveliKodlama.Core.csproj", "KahveliKodlama.Core/KahveliKodlama.Core/"]
COPY ["KahveliKodlama.Service/KahveliKodlama.Service/KahveliKodlama.Service.csproj", "KahveliKodlama.Service/KahveliKodlama.Service/"]
RUN dotnet restore "KahveliKodlama/KahveliKodlama.API.csproj"
COPY . .
WORKDIR "/src/KahveliKodlama"
RUN dotnet build "KahveliKodlama.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "KahveliKodlama.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KahveliKodlama.API.dll"]