FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /work
COPY . .
WORKDIR "/work/src/Meli.DNAAnalyzer.API"
RUN rm -rf ./bin
RUN rm -rf ./obj
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish --no-restore  -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Meli.DNAAnalyzer.API.dll"]