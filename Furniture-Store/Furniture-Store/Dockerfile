#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Furniture-Store/FurnitureStore.csproj", "Furniture-Store/"]
COPY ["FurnitureStore.Model/FurnitureStore.Model.csproj", "FurnitureStore.Model/"]
COPY ["FurnitureStore.Services/FurnitureStore.Services.csproj", "FurnitureStore.Services/"]
RUN dotnet restore "Furniture-Store/FurnitureStore.csproj"
COPY . .
WORKDIR "/src/Furniture-Store"
RUN dotnet build "FurnitureStore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FurnitureStore.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FurnitureStore.dll"]
