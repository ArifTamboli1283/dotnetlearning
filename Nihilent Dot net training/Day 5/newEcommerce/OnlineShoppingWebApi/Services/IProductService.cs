namespace OnlineShoppingWebApi.Services;

using System.Collections.Generic;
using OnlineShoppingWebApi.Entities;

public interface IProductService
{
    
    public IEnumerable<Product> GetAllProducts();
    public Product GetProductById(int id);

    void AddProduct(Product product);

    void UpdateProduct(Product product);
    
    public void DeleteProduct(Product product);
}