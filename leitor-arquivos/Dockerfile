FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["leitor-arquivos/leitor-arquivos.csproj", "leitor-arquivos/"]
RUN dotnet restore "leitor-arquivos/leitor-arquivos.csproj"
COPY . .
WORKDIR "/src/leitor-arquivos"
RUN dotnet build "leitor-arquivos.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "leitor-arquivos.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "leitor-arquivos.dll"]
