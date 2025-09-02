using HR;
using Catelog;

IProductRepository productRepository = new ProductRepository();
IProductService productService = new ProductService(productRepository);
List<Product> productsList = new List<Product>()
{
    new Product("laptop", 1200),

    new Product("SmartPhone", 1200),

    new Product("Tablet", 1200),

};

foreach (Product product in productsList)
{
    productService.AddProduct(product);
}