using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StateManagemtApp.Models;

namespace StateManagemtApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult AboutUs()
    {
        Student student = new Student
        {
            StudentId = 12,
            Branch = "CS",
            Gender = "M",
            Name = "Raj",
            Section = "Web"
        };
        string json = JsonSerializer.Serialize(student);
        TempData["City"];
        return RedirectToAction("Services");

    }

    public ActionResult Services()
    {
        if (TempData["City"] is string json)
        {
            Student theStudent = JsonSerializer.Deserialize<Student>(json);
            ViewData["City"] = theStudent;
        }
        return View();
    }

    public IActionResult Catolog()
    {
        List<Product> Products = new List<Product>
        {
            { Id = 23, Title = "Gerbera", Quantity = 7000 },
            { Id = 24, Title = "Rose", Quantity = 6700 },
            { Id = 25, Title = "Carnation", Quantity =9000 },
            { Id = 26, Title = "Gerbera", Quantity = 8900 }
        };
        return Json(Products);
    }

    public IActionResult List()
    {
        return View();
    }

    public IActionResult Data()
    {
        string DataRecieved = TempData["userdetails"].toString();
        ViewBag.theData = DataRecieved;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
