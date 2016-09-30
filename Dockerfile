FROM microsoft/dotnet:latest

COPY bin/Debug/netcoreapp1.0/publish /app

WORKDIR /app


EXPOSE 5000/tcp

CMD ["dotnet", "/app/TodoApi.dll", "--server.urls", "http://*:5000"]
