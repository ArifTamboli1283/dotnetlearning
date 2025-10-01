using Microsoft.AspNetCore.Mvc;
using Capstone_web_api.Services;
using Capstone_web_api.Entities;
using Capstone_web_api.Models;
using Microsoft.AspNetCore.Authorization;

namespace Capstone_web_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserLoginController : ControllerBase
{
    private readonly IUserService _userService;
    public UserLoginController(IUserService userService)
    {
        _userService = userService;
    }

    // [Authorize]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> getAllUser()
    {
        var users = await _userService.getAllUser();
        return Ok(users);
    }
    [HttpPost("authenticate")]
    public async Task<ActionResult<AuthenticateResponse>> Authenticate([FromBody] AuthenticateRequest model)
    {
        var user = await _userService.Authenticate(model);
        if (user == null)
        {
            return BadRequest(new { message = "Username password incorrect" });
        }
        return Ok(user);
    }

    [HttpPost]
    public async Task<ActionResult> AddUser([FromBody] User user)
    {
        await _userService.AddUserAsync(user);
        return Ok("Data added successfully");
    }


}