using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpaBackend.Services.Abstract;

namespace SpaBackend.Controllers;

[ApiController]
[Authorize]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IUserProvider _userProvider;
    private readonly IVisitService _visitService;

    public EmployeeController(IUserProvider userProvider, IVisitService visitService)
    {
        _userProvider = userProvider;
        _visitService = visitService;
    }

    [HttpGet("visits")]
    public ActionResult GetVisits()
    {
        var userId = _userProvider.GetUserId();
        return Ok(_visitService.GetEmployeeVisits(userId));
    }
}