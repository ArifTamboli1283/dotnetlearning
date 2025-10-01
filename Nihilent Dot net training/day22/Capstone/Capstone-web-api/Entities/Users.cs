
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Capstone_web_api.Entities;

public class User
{



    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string MongoId { get; set; }
    [BsonElement("Id")]
    public int Id { get; set; }
    [BsonElement("FirstName")]
    public string FirstName { get; set; }
    [BsonElement("LastName")]
    public string LastName { get; set; }
    [BsonElement("UserName")]
    public string UserName { get; set; }
    [BsonElement("Password")]
    [JsonIgnore]
    public string Password { get; set; }
}