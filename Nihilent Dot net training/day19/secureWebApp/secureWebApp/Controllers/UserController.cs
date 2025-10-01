using Microsoft.AspNetCore.Mvc;

namespace secureWebApp.Controllers;

[ApiController]
[Route("[controller]")]

public class UserController : ControllerBase
{
    private IUserService userService;
    public UserController(IUserService userService)
    {
        this.userService = userService;
    }


    [HttpPost("authenticate")]
    public IActionResult Authenticate(AuthenticateRequest model)
    {

    }

    [Authorize]
    [HttpGet]
    public IActionResult GetAll()
    {
        var users = userService.GetAll();
        return ok(users);
    }
    
    [HttpPost]
    public IActionResult SendMessage()
    {

    }
}