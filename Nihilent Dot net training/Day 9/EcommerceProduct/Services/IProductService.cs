namespace Services;

using Entities;

public interface IProductService
{
    IEnumerable<Product> GetAllProduct();
    // void DleteProduct(Product product);

    // Product getProductById(int id);

    // void AddProduct(Product product);

    // void UpdateProduct(Product product);
}
