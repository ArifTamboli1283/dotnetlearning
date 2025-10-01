
using MongoDB.Driver;
using System.Collections.Generic;
public class ProductRepository
{
    public readonly IMongoCollection<Product> _products;
    public ProductRepository(string connectionString, string databseName, string collectionName)
    {
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(databseName);
        _products = database.GetCollection<Product>(collectionName);

    }

    public List<Product> getAll()
    {
        // LIngq language intigrated Query 
        // Query agins .net collection object
        // Extension methods
        return _products.find(p => true).toList();
    }

    public Product GetProductById(int id)
    {
        return _products.FirstOrDefault(p => p.id == id);
    }

    public void UpdateProduct(Product product)
    {
        _products.replaceOne(p => p.id == product.id, product);
    }
}