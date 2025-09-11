namespace Repositories;
using System.Collections.Generic;
using Entities;
public interface IProductRepository
{
    IEnumerable<Product> GetAllProduct();

    Product GetProductById(int id);
    public void DeleteProduct(Product product);

    public void AddProduct(Product product);

    public void UpdateProduct(Product product);

}