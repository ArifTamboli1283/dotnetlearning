
namespace Catelog
{
    public class ProductDBRepository : IProductRepository
    {

        // to Perform crud operation using mongo
        public List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return new List<Product>();
        }

        public Product GetProduct(int id)
        {
            return new Product();
        }

        public void UpdateProduct(Product product)
        {
            
        }
    }
}