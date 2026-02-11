# -------- BUILD STAGE --------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

# Kopiere csproj zuerst (besseres Caching)
COPY BankApp/BankApp/BankApp/BankApp.csproj ./BankApp/BankApp/
COPY BankApp/BankApp/BankAppClassLibrary/BankAppClassLibrary.csproj ./BankApp/BankAppClassLibrary/
COPY BankApp/BankApp/BankAppControlLibrary/BankAppControlLibrary.csproj ./BankApp/BankAppControlLibrary/

# Restore
RUN dotnet restore BankApp/BankApp/BankApp.csproj

# Kopiere restlichen Code
COPY BankApp ./BAnkApp/

# Build
RUN dotnet publish BankApp/BankApp/BankApp.csproj \
    -c Release \
    -o /app/publish \
    --no-restore

# -------- RUNTIME STAGE --------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

WORKDIR /app

# Kopiere nur das gebaute Artifact aus Build-Stage
COPY --from=build /app/publish .

# Port (anpassen falls nötig)
EXPOSE 80

# Startbefehl
ENTRYPOINT ["dotnet", "BankApp.dll"]
