# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Works for .sln and .slnx
COPY *.sln* ./

# copy csproj files into the same relative paths the solution expects
COPY src/Api/*.csproj ./src/Api/
COPY src/Application/*.csproj ./src/Application/
COPY src/Domain/*.csproj ./src/Domain/
COPY src/Infrastructure/*.csproj ./src/Infrastructure/

# restore using the solution at /src
RUN dotnet restore "WalkBooks.slnx"

# copy the rest of the repo
COPY . .

# publish from the Api project path the solution uses
WORKDIR /src/src/Api
RUN dotnet publish "Api.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80

ENTRYPOINT ["dotnet", "Api.dll"]
