using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;

namespace Portal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // Action menthod \
    // Http get
    [HttpGet]
    public IActionResult Index()
    {
        string message = "Ecommerce flower selleing app";
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Contact()
    {
        string Message = "Contact us for more info";
        string Email = "ariftamboli786k@gmail.com";
        string Phone = "+919762494936";
        return View();
    }

    public IActionResult Privacy()
    {
        return View(); // generating view result
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
