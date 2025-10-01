using Microsoft.AspNetCore.Mvc;
namespace Catolog.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private static readonly List<string> Products = new() { "laptop", "mobile", "tablet" };
    [HttpGet]
    public ActionResult getProducts() => Ok(Products);
}