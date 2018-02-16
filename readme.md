# Conent negotiation in aspnet core 2.1

```shell
dotnet new web -lang c#
dotnet run
```

Console output
```shell
Hosting environment: Production
Content root path: C:\Users\shibu\Source\Repos\aspnetcore-2x-content-negotiation
Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down.
info: Microsoft.AspNetCore.Hosting.Internal.WebHost[1]
      Request starting HTTP/1.1 GET http://localhost:5000/
info: Microsoft.AspNetCore.Hosting.Internal.WebHost[2]
      Request finished in 13.3193ms 200
info: Microsoft.AspNetCore.Hosting.Internal.WebHost[1]
      Request starting HTTP/1.1 GET http://localhost:5000/favicon.ico
info: Microsoft.AspNetCore.Hosting.Internal.WebHost[2]
      Request finished in 0.1873ms 200
```

visit [http://localhost:5000](http://localhost:5000) to verify project