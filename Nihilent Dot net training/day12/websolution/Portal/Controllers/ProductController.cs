using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;

namespace Portal.Controllers;
public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;
    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var products = new List<Product> {
            new Product {Id = 1,  Name = "testing1",Price = 1213 , Description = "testing1"},
            new Product {Id = 2,  Name = "testing2",Price = 2323 , Description = "testing2"},
            new Product {Id = 3,  Name = "testing3",Price = 324324 , Description = "testing3"}
        };
        return View(products);
    }

    public IActionResult Details(int id)
    {
        var product = new Product {Id = id, Name = "Base" , Price = 12121, Description = ""};
        return View(product);
    }
}