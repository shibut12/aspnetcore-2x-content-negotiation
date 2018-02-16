using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

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