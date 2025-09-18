using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TransflowerPortal.Models;
using CatologServices;
using CatologRepositories;
using CatologEntities;

namespace TransflowerPortal.Controllers;

public class ProductController : Controller
{
    private readonly ICatologService _productService;
    public ProductController(ICatologService productService)
    {
        _productService = productService;
    }
    public IActionResult Index()
    {
        var allProducts = _productService.GetAllProdut();
        ViewData["Product"] = allProducts;
        return View();
    }

    public IActionResult Details(int id)
    {
        var allProducts = _productService.GetProductById(id);
        ViewData["theProduct"] = allProducts;
        return View();
    }

    public IActionResult Create()
    {
        TempData["Message"] = "Create new product";
        return View();
    }
}

