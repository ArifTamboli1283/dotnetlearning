namespace Repositories;

using System.Collections.Generic;
using Entities;

public interface IProductRepository
{
    public IEnumerable<Product> GetAllProduct();
    // void DleteProduct(Product product);

    // Product getProductById(int id);

    // void AddProduct(Product product);

    // void UpdateProduct(Product product);

}
