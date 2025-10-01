using Capstone_web_api.Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Capstone_web_api.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly IMongoCollection<Product> _products;
    public ProductRepository(MongoDbHelper dbHelper)
    {
        _products = dbHelper.GetCollection<Product>("Products");
    }

    public async Task<IEnumerable<Product>> GetProductsAll()
    {
        return await _products.Find(prod => true).ToListAsync();
    }

    public async Task AddProduct(Product product)
    {
        _products.InsertOneAsync(product);
    }
}