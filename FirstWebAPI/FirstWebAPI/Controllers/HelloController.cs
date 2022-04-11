using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            return Ok("Hello World");
        }

        [HttpPost]

        public IActionResult Post(JObject payload)
        {
            return Ok(payload);
        }
    }
}
