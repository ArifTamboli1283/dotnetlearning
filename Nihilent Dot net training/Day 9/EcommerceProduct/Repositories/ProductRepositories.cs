namespace Repositories;

using System.Collections.Generic;
using Entities;

using System.Text.Json;
using System.IO;

public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new List<Product>();

    public IEnumerable<Product> GetAllProduct()
    {

        string path = @"C:\Users\arif.tamboli_6361\Desktop\DotNetLerning\dotnetlearning\Nihilent Dot net training\Day 9\Product.json";
        string jsonStringFromFile = File.ReadAllText(path);
        List<Product> productsFromFile = JsonSerializer.Deserialize<List<Product>>(jsonStringFromFile);
        return productsFromFile;

    }

    // public void AddProduct(Product product)
    // {
    //     _products.Add(product);
    // }
    // public void UpdateProduct(Product product)
    // {
    //     var selectedProduct = getProductById(product.Id);
    //     if (selectedProduct != null)
    //     {
    //         selectedProduct.Title = product.Title;
    //         selectedProduct.Description = product.Description;
    //         selectedProduct.Price = product.Price;
    //     }

    // }
    // public void DeleteProduct(Product product)
    // {
    //     var selectedProduct = getProductById(product.Id);
    //     if (selectedProduct != null)
    //     {
    //     _products.Remove(product);
    //     }
    // }

    // public Product getProductById(int id) {
    //     return _products.FirstOrDefault(p => p.Id == id);
    // } 
}