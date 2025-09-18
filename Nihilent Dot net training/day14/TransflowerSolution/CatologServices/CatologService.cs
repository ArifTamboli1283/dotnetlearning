namespace CatologServices;

using CatologRepositories;
using CatologEntities;
public class CatologService : ICatologService
{
    private readonly IProductRepository _productRepository;
    public CatologService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public IEnumerable<Product> GetAllProdut()
    {
        return _productRepository.GetAllProdut();
    }
    public Product GetProductById(int id)
    {
        return _productRepository.GetProductById(id);
    }

    public void AddProduct(Product product)
    {
         _productRepository.AddProduct(product);
    }

    public void DeleteProduct(Product product)
    {
        _productRepository.DeleteProduct(product);
    }

    public void UpdateProduct(Product product)
    {
        _productRepository.UpdateProduct(product);
    }

}
