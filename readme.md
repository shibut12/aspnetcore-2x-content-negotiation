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

* Update `ConsifureServices` method in Satrtup.cs
```csharp
public void ConfigureServices(IServiceCollection services)
{
services.AddMvc();
}
```
* Add `app.UseMvcWithDefaultRoute();` into `Configure` method in Startup.cs
* Add a new file `ValuesController.cs` and insert following code
```csharp
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_2x_content_negotiation
{
    [Route("api/[controller]")]
    public class ValuesController: Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var data = new List<string>()
            {
                "string 1", 
                "string 2", 
                "string 3"
            };
            return Ok(data);
        }
    }
}
```

* Run the project 
```csharp
dotnet run
```
* [http://localhost:5000/api/values](http://localhost:5000/api/values) to verify api response
