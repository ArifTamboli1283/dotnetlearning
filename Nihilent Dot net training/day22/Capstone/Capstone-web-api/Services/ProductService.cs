using Capstone_web_api.Entities;
using Capstone_web_api.Repositories;

namespace Capstone_web_api.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public async Task<IEnumerable<Product>> GetProductsAll()
    {
        return await _productRepository.GetProductsAll();
    }

    public async Task AddProduct(Product product)
    {
        await _productRepository.AddProduct(product);
    }
}