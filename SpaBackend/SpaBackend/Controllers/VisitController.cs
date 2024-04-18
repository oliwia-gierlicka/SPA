using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpaBackend.Db;
using SpaBackend.Db.Entity;
using SpaBackend.Models;
using SpaBackend.Services.Abstract;

namespace SpaBackend.Controllers;

[ApiController]
[Authorize]
[Route("[controller]")]
public class VisitController:ControllerBase
{
    private readonly IVisitService _visitService;
    private readonly IUserProvider _userProvider;

    public VisitController(IVisitService visitService, IUserProvider userProvider)
    {
        _visitService = visitService;
        _userProvider = userProvider;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var userId = _userProvider.GetUserId();
        return Ok(_visitService.Get(userId));
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var userId = _userProvider.GetUserId();
        await _visitService.Delete(id, userId);
        return Ok();
    }
    
    [HttpPost]
    public async Task<ActionResult> Post(VisitForm form)
    {
        var userId = _userProvider.GetUserId();
        await _visitService.Create(form, userId);
        return Ok();
    }
}