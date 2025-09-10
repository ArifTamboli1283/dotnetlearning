namespace Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Descriptio { get; set; }

    public decimal Price { get; set; }

    public Product()
    {
        Price = 0;
        Descriptio = "";
        Name = "";
        Id = 0;
    }
}
