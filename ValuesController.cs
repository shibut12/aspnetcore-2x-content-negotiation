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