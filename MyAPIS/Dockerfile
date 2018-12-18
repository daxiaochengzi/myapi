FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY MyAPIS/MyAPIS.csproj MyAPIS/
COPY Datas/Datas.csproj Datas/
RUN dotnet restore MyAPIS/MyAPIS.csproj
COPY . .
WORKDIR /src/MyAPIS
RUN dotnet build MyAPIS.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish MyAPIS.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MyAPIS.dll"]
