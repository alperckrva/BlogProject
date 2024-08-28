FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

COPY BlogProject.Web.csproj ./
RUN dotnet restore BlogProject.Web.csproj
COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

COPY --from=build-env /app/out .
ENV ASPNETCORE_URLS=http://+:80
ENTRYPOINT ["dotnet", "BlogProject.Web.dll"]
