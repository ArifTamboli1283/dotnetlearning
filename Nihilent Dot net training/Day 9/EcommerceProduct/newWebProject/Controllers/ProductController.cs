using Microsoft.AspNetCore.Mvc;

namespace newWebProject.Controllers;

using Services;
using Repositories;
using Entities;
[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Product> Get()
    {
        IProductRepository productRepository = new ProductRepository();
        IProductService productService = new ProductService(productRepository);
        return productService.GetAllProduct();
    }
}
