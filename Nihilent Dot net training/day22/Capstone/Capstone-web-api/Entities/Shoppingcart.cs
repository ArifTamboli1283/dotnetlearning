namespace Capstone_web_api.Entities;

public class ShoppingCart {
    public int shoppingCardId   { get; set; }
    public User customer { get; set; }
    public List<string> items { get; set; }
}