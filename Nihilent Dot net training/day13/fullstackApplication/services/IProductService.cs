namespace services;
using Entities;
using System.Collections.Generic;
public interface IProductService
{

    IEnumerable<Product> GetAllProduct();

    Product GetProductById(int id);
    public void DeleteProduct(Product product);

    public void AddProduct(Product product);

    public void UpdateProduct(Product product);
}
