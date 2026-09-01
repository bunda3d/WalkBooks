# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Works for .sln and .slnx
COPY *.sln* ./

# Copy only csproj files first (leverage layer caching)
COPY src/Api/*.csproj ./Api/
COPY src/Application/*.csproj ./Application/
COPY src/Domain/*.csproj ./Domain/
COPY src/Infrastructure/*.csproj ./Infrastructure/

RUN dotnet restore

COPY . .
WORKDIR /src/Api
RUN dotnet publish -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80

ENTRYPOINT ["dotnet", "Api.dll"]
