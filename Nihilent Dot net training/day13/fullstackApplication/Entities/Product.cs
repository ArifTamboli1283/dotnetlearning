namespace Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }
    public decimal Price { get; set; }

    public string ImageUrl { get; set; }

    Product(int id, string name, decimal price, string Description, string ImageUrl)
    {
        Id = id;
        Name = name;
        Price = price;
        Description = Description;
        ImageUrl = ImageUrl;
    }

    Product()
    {
        Id = 0;
        Name = "";
        Description = "";
        Price = 0;
        ImageUrl = "";
    }

}
