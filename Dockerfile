#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LB210/LB210.csproj", "LB210/"]
RUN dotnet restore "LB210/LB210.csproj"
COPY . .
WORKDIR "/src/LB210"
RUN dotnet build "LB210.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LB210.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LB210.dll"]