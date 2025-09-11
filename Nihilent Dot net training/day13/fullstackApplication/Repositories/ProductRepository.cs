namespace Repositories;

using Entities;
using System.IO;
using System.Text.Json;
public class ProductRepository: IProductRepository
{
    private readonly List<Product> _products = new List<Product>();
    public IEnumerable<Product>? GetAllProduct()
    {
        return JSONCatologManager.GetProduct();
    }

    public Product GetProductById(int id)
    {
        IEnumerable<Product> products = GetAllProduct();
        return products.FirstOrDefault(x => x.Id == id);
    }

    public void AddProduct(Product product)
    {
        List<Product> products = GetAllProduct().ToList();
        products.Add(product);
        JSONCatologManager.SaveProduct(products);
    }

    public void UpdateProduct(Product product)
    {
        var productnew = GetProductById(product.Id);
        if (productnew != null)
        {
            productnew = product;
        }
        // JSONCatologManager.SaveProduct(products);
    }
    public void DeleteProduct(Product product)
    {
        List<Product> allProducts = GetAllProduct().ToList();
        var existingProduct = GetProductById(product.Id);
        if (existingProduct != null)
        {
            allProducts.RemoveAll(p => p.Id == product.Id);
        }

        JSONCatologManager.SaveProduct(allProducts);

    }

}
