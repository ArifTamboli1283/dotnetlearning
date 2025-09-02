namespace Catelog
{
    public interface IProductService
    {
        void AddProduct(Product product);
        Product GetProduct(int productId);

        IEnumerable<Product> GetProducts();

        void UpdateProduct(Product product);

        void DeleteProduct(int productId);


    }
}