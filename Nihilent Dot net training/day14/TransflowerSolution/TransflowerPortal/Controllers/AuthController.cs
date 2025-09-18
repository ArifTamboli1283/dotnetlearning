using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace TransflowerPortal.Controllers;

public class AuthController : Controller
{
      public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        if (email == "Ariftamboli786k@gmail.co" && password == "abcd") {
            this.Response.Redirect("/products/Index");
        } else {
            return View();
        }
    }
    public IActionResult Register()
    {
        return View();
    }
}