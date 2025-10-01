using System.Text.Json.Serialization;

namespace Capstone_web_api.Entities;

public class Orders
{
    public int orderId { get; set; }
    public string orderName { get; set; }
    public ShoppingCart orderedProducts { get; set; }
}