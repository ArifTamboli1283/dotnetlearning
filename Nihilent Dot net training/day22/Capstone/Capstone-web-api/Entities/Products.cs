using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;
namespace Capstone_web_api.Entities;

public class Product
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string MongoId { get; set; }

    [BsonElement("Id")]
    public int Id { get; set; }
    [BsonElement("ProductName")]
    public string ProductName { get; set; }
    [BsonElement("ProductDescription")]
    public string ProductDescription { get; set; }
}