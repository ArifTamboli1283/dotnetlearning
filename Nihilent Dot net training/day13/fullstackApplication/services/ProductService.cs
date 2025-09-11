namespace services;

using Entities;
using Repositories;

public class ProsuctService : IProductService
{
    private readonly IProductRepository _repository;
    public ProsuctService(IProductRepository productRepository)
    {
        this._repository = productRepository;
    }

    public IEnumerable<Product> GetAllProduct()
    {
        return _repository.GetAllProduct();
    }

    public Product GetProductById(int id)
    {
        return _repository.GetProductById(id);
    }

    public void DeleteProduct(Product product)
    {
        _repository.DeleteProduct(product);
    }

    public void AddProduct(Product product)
    {
        _repository.AddProduct(product);
    }

    public void UpdateProduct(Product product)
    {
        _repository.UpdateProduct(product);
    }
}


