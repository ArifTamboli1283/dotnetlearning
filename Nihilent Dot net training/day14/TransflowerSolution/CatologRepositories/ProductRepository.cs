namespace CatologRepositories;

using CatologEntities;

public class ProductRepository : IProductRepository
{
    public IEnumerable<Product> GetAllProdut()
    {
        return JSONProductManager.GetAllProduct();
    }
    public Product GetProductById(int id)
    {
        var allProducts = JSONProductManager.GetAllProduct();
        return allProducts.FirstOrDefault(x => x.Id == id);
    }

    public void AddProduct(Product product)
    {
         List<Product> allNewProduct = JSONProductManager.GetAllProduct().ToList();
        allNewProduct.Add(product);
        JSONProductManager.SaveAllProducts(allNewProduct);
    }
    public void DeleteProduct(Product product)
    {
        List<Product> allNewProduct = JSONProductManager.GetAllProduct().ToList();
        var existingProduct = GetProductById(product.Id);
        if (existingProduct != null)
        {
            allNewProduct.RemoveAll(p => p.Id == product.Id);
        }
        JSONProductManager.SaveAllProducts(allNewProduct);
    }

      public void UpdateProduct(Product product)
    {
        var productnew = GetProductById(product.Id);
        if (productnew != null)
        {
            productnew = product;
        }
        // JSONCatologManager.SaveProduct(products);
    }
}