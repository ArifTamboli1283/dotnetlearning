using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Capstone_web_api.Entities;

namespace Capstone_web_api.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetProductsAll();
    Task AddProduct(Product product);

}