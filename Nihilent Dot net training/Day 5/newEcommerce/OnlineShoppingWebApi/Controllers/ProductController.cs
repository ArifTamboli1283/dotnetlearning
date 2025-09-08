using Microsoft.AspNetCore.Mvc;
using OnlineShoppingWebApi.Entities;
using OnlineShoppingWebApi.Services;
using OnlineShoppingWebApi.Repositories;

namespace OnlineShoppingWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ILogger<ProductsController> _logger;

    // Action listner 

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        IProductRepository productRepository = new ProductRepository();
        IProductService productService = new ProductService(productRepository);
        return productService.GetAllProducts();
    }
}
