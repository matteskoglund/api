FROM microsoft/aspnetcore:1.0.1

COPY app/* /app/

WORKDIR /app


EXPOSE 5000/tcp

CMD ["dotnet", "/app/TodoApi.dll", "--server.urls", "http://*:5000"]
