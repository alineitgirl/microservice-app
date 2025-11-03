using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlatformsController : ControllerBase
{
    public PlatformsController()
    {
        
    }

    [HttpPost]
    public ActionResult TestInboundConnection()
    {
        Console.WriteLine("Test POST #Platform Service");

        return Ok("Test query to Platforms Controller");
    }
}