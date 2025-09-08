namespace OnlineShoppingWebApi.Repositories;
using OnlineShoppingWebApi.Entities;

public interface IProductRepository
{
    public IEnumerable<Product> GetAllProducts();
    public Product GetProductById(int id);

    void AddProduct(Product product);

    void UpdateProduct(Product product);
    
    void DeleteProduct(Product product);
}