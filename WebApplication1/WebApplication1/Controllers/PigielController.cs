using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class PigielController : ControllerBase
{
    [HttpGet]
    public ActionResult Cos()
    {
        return Ok();
    }
}