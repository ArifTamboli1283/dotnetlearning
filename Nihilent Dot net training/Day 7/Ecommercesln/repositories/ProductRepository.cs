namespace Repositories;

using System.Collections.Generic;
using entities;

public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new List<Product>();

    IEnumerable GetAllProduct()
    {
        return _products;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public void UpdateProduct(Product product)
    {
        var selectedProduct = getProductById(product.Id);
        if (selectedProduct != null)
        {
            selectedProduct.Title = product.Title;
            selectedProduct.Description = product.Description;
            selectedProduct.Price = product.Price;
        }

    }
    public void DeleteProduct(Product product)
    {
        var selectedProduct = getProductById(product.Id);
        if (selectedProduct != null)
        {
        _products.Remove(product);
        }
    }

    public Product getProductById(int id) {
        return _products.FirstOrDefault(p => p.Id == id);
    } 
}