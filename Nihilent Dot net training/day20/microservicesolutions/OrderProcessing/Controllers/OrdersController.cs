using Microsoft.AspNetCore.Mvc;

namespace OrderProcessing.Controllers;

[ApiController]
[Route("api/[controller]")]

public class OrderController : ControllerBase
{
    private static readonly List<string> orders = new();
    [HttpPost]
    public IActionResult PlaceOrder([FromBody] string product)
    {
        orders.Add(product);
        return Ok($"Order place for {product}");
    }
    [HttpGet]
    public IActionResult GetOrder()
    {
        return Ok(orders);
    }
}