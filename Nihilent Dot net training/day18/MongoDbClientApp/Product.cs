public class Products
{
    [BsonElement("id")]
    public int Id { get; set; }
    
    [BsonElement("title")]
    public string Title { get; set; }

    [BsonElement("description")]
    public string Description { get; set; }

    [BsonElement("unitprice")]
    public decimal UnitPrice { get; set; }

    [BsonElement("quantity")]
    public int Quantity { get; set; }

    [BsonElement("imageurl")]
    public string ImageUrl { get; set; }
    
}