namespace Repositories;

using System.Collections.Generic;
using entities;

public interface IRepository
{
    IEnumerable<Product> GetAllProduct();
    void DleteProduct(Product product);

    Product getProductById(int id);

    void AddProduct(Product product);

    void UpdateProduct(Product product);
}