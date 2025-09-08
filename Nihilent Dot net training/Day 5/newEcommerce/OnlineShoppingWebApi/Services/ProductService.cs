namespace OnlineShoppingWebApi.Services;

using System.Collections.Generic;
using OnlineShoppingWebApi.Entities;
using OnlineShoppingWebApi.Repositories;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;
    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }
    public IEnumerable<Product> GetAllProducts()
    {
        return _repository.GetAllProducts();
    }

    public Product GetProductById(int id)
    {
        return _repository.GetProductById(id);
    }

    public void AddProduct(Product product)
    {
        _repository.AddProduct(product);
    }

    public void UpdateProduct(Product product)
    {
        _repository.UpdateProduct(product);
    }

    public void DeleteProduct(Product product)
    {
        _repository.DeleteProduct(product);
    }
}