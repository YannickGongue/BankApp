# -------- BUILD STAGE --------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

# Copy everything from Jenkins workspace into container
COPY . .

# Restore dependencies
#RUN dotnet restore BankApp/BankApp/BankApp.csproj

# Build & publish
#RUN dotnet publish BankApp/BankApp/BankApp.csproj \
    #-c Release \
    #-o /app/publish \
    #--no-restore

# -------- RUNTIME STAGE --------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 80

ENTRYPOINT ["dotnet", "BankApp.dll"]
