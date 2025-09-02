
namespace Catelog
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }

        public void DeleteProduct(int productId)
        {
           _productRepository.DeleteProduct(productId);
        }

        public Product GetProduct(int productId)
        {
           return _productRepository.GetProduct(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetAllProduct();
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.UpdateProduct(product);
        }
    }
}