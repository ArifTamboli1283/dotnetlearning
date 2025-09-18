namespace CatologServices;
using CatologEntities;
public interface ICatologService
{
    IEnumerable<Product> GetAllProdut();
    public Product GetProductById(int id);

    public void AddProduct(Product product);

    public void DeleteProduct(Product product);

    public void UpdateProduct(Product product);
}