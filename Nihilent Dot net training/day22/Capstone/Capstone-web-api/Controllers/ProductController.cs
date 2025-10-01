using Microsoft.AspNetCore.Mvc;
using Capstone_web_api.Services;
using Capstone_web_api.Entities;
using Capstone_web_api.Models;
using Microsoft.AspNetCore.Authorization;

namespace Capstone_web_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;
    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetAllProduct()
    {
        var products = await _productService.GetProductsAll();
        return Ok(products);
    }
}