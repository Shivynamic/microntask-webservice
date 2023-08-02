using Microsoft.AspNetCore.Mvc;

namespace TaskPostApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SimpleController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] SimpleData data)
        {

            // Return a success response
            return Ok("Data received successfully!");
        }
    }

    public class SimpleData
    {
        public string Name { get; set; }
        public int Age { get; set; }
        // Add other properties as needed
    }
}
