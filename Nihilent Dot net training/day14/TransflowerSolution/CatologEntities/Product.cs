namespace CatologEntities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public decimal Price { get; set; }
    public string Desctiption { get; set; }

    Product()
    {
        Id = 0;
        Name = "";
        ImageUrl = "";
        Price = 0;
        Desctiption = "";
    }

}
