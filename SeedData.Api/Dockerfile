FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["SeedData.Api/SeedData.Api.csproj", "SeedData.Api/"]
RUN dotnet restore "SeedData.Api/SeedData.Api.csproj"
COPY . .
WORKDIR "/src/SeedData.Api"
RUN dotnet build "SeedData.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SeedData.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SeedData.Api.dll"]