using Microsoft.AspNetCore.Mvc;
using SpaBackend.Models;
using SpaBackend.Services.Abstract;

namespace SpaBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
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
        return token is not null
            ? Ok(new { Token = token, IsEmployee = await _userService.IsEmployee(form.Login) })
            : BadRequest();
    }

    [HttpGet("employees")]
    public ActionResult GetEmployees()
    {
        return Ok(_userService.GetEmployees());
    }
}