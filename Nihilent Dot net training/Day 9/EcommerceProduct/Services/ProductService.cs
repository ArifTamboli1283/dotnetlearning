namespace Services;

using Repositories;
using Entities;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        this._repository = repository;
    }

    public IEnumerable<Product> GetAllProduct()
    {
        return _repository.GetAllProduct();
    }
    // public Product GetProduct(int id)
    // {
    //     return _repository.GetProduct(id);
    // }
    // public void AddProduct(Product product)
    // {
    //     _repository.AddProduct(product);
    // }

}
