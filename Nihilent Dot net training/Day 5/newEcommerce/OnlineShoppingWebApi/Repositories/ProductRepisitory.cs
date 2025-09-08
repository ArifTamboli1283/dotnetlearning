namespace OnlineShoppingWebApi.Repositories;

using OnlineShoppingWebApi.Entities;
using System.Collections.Generic;

public class ProductRepository: IProductRepository
{
    private readonly List<Product> _products = new List<Product>();
    public ProductRepository()
    {
        _products.Add(new Product { Id = 1, Title = "testing", Description = "testing", Price = 0 });
        _products.Add(new Product { Id = 2, Title = "testing", Description = "testing", Price = 0 });
        _products.Add(new Product { Id = 3, Title = "testing", Description = "testing", Price = 0 });
        _products.Add(new Product { Id = 4, Title = "testing", Description = "testing", Price = 0 });
    }


    public IEnumerable<Product> GetAllProducts()
    {
        return _products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void UpdateProduct(Product product)
    {
        var existingProdut = GetProductById(product.Id);
        if (existingProdut != null)
        {
            existingProdut.Title = product.Title;
            existingProdut.Description = product.Description;
            existingProdut.Price = product.Price;
        }
    }

    public void DeleteProduct(Product product)
    {
        var productNew = GetProductById(product.Id);
        if (productNew != null)
        {
            _products.Remove(productNew);
        }
    }

    public Product GetProductById(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }
}