# -------- BUILD STAGE --------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

# Copy everything into the container
COPY . .

# Restore and build the main project
WORKDIR /app/BankApp/BankApp
RUN dotnet restore BankApp.csproj
RUN dotnet publish BankApp.csproj -c Release -o /app/publish --no-restore

# -------- RUNTIME STAGE --------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

WORKDIR /app

# Copy published output from build stage
COPY --from=build /app/publish .

EXPOSE 80

ENTRYPOINT ["dotnet", "BankApp.dll"]
