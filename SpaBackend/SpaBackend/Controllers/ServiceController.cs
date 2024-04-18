using Microsoft.AspNetCore.Mvc;
using SpaBackend.Services.Abstract;

namespace SpaBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class ServiceController:ControllerBase
{
    private readonly ISpaService _spaService;

    public ServiceController(ISpaService spaService)
    {
        _spaService = spaService;
    }

    [HttpGet("category/{name}")]
    public ActionResult GetByCategory(string name)
    {
        return Ok(_spaService.GetServicesByCategory(name));
    }
}