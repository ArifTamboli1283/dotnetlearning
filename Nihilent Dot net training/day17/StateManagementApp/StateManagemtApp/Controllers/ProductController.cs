using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StateManagemtApp.Models;
using System.Text.Json;

namespace StateManagemtApp.Controllers;

public class ProductController : Controller
{
    [OutputCache(PolicyName = "CacheFor10Secounds")]
    public IActionResult Index()
    {
        List<string> products = new List<string>();
        products.Add("Rose");
        products.Add("Jasmine");
        products.Add("Mogra");
        return Json(products);
    }

    public IActionResult Details()
    {
        List<string> product = new List<string>();
         products.Add("Rose");
        products.Add("Jasmine");
        products.Add("Mogra");
        return Json(products);

    }
}