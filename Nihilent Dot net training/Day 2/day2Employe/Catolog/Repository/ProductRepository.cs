
namespace Catelog
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DeleteProduct(int id)
        {
            var product = GetProduct(id);
            if (product != null)
            {
                products.Remove(product);
            }
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return products;
        }

        public Product GetProduct(int id)
        {
            return new Product();
            // return products.FirstOrDefault(p => p.getId() == id);
        }

        public void UpdateProduct(Product product)
        {
            // 
        }
    } 
}