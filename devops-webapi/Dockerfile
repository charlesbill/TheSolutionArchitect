#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:latest AS base
WORKDIR /app
EXPOSE 5000
ENV ASPNETCORE_URLS=http://*:5000

FROM mcr.microsoft.com/dotnet/core/sdk:latest AS build
WORKDIR /src
COPY ["devops-webapi.csproj", "./"]
RUN dotnet restore "devops-webapi.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "devops-webapi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "devops-webapi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "devops-webapi.dll"]
