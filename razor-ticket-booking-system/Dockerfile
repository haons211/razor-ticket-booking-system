# Base image for runtime environment (lightweight and optimized)
FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
WORKDIR /app
EXPOSE 8080

# Development image to enable hot reload and efficient development
FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS dev
WORKDIR /src

# Optimize caching by copying only project files first
COPY razor-ticket-booking-system/razor-ticket-booking-system.csproj razor-ticket-booking-system/
RUN dotnet restore razor-ticket-booking-system/razor-ticket-booking-system.csproj

# Copy the remaining source code
COPY . .

# Set the working directory to the project
WORKDIR /src/razor-ticket-booking-system

# Enable dotnet watch for real-time code changes in development
CMD ["dotnet", "watch", "run", "--urls", "http://0.0.0.0:8080", "--verbosity", "minimal"]
