
// interface act like  contract

namespace Catelog
{
    public interface IProductRepository
    {
        void AddProduct(Product product);

        void DeleteProduct(int productId);

        IEnumerable<Product> GetAllProduct();

        Product GetProduct(int id);

        void UpdateProduct(Product product);
    }
}