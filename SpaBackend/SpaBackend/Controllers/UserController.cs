using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpaBackend.Db;
using SpaBackend.Db.Entity;
using SpaBackend.Models;
using SpaBackend.Services.Abstract;
using SpaBackend.Services.Implementation;

namespace SpaBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController:ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("new")]
    public async Task<ActionResult> CreateUser(UserForm form)
    {
        await _userService.CreateUser(form);
        return Ok();
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login(LoginForm form)
    {
        var token = await _userService.Login(form);
        return token is not null ? Ok(token) : BadRequest();
    }

}