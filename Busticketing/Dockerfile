# Base Image (ASP.NET Core Runtime)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base 

# Set working directory
WORKDIR /app

# Copy and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Build and publish
COPY . ./
RUN dotnet publish -c Release -o out

# Final Runtime Image
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS final

# Set working directory
WORKDIR /app

# Copy from the 'base' stage
COPY --from=base /app/out .

# Expose port 8000
EXPOSE 8000 

# Entrypoint to start the application
ENTRYPOINT ["dotnet", "BusTicketing.dll"] 
