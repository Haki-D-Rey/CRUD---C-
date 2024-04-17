using Microsoft.AspNetCore.Mvc;

namespace MyRestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("¡Hola desde HomeController!");
        }
    }
}
