namespace CatologRepositories;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using CatologEntities;
public static class JSONProductManager
{
    public static string GetJsonFilePath()
    {
        return Path.Combine(Directory.GetCurrentDirectory(), "Data", "Product.json");
    }
    public static IEnumerable<Product> GetAllProduct()
    {
        var jsonFile = File.ReadAllText(GetJsonFilePath());
        return JsonSerializer.Deserialize<List<Product>>(jsonFile);
    }

    public static void SaveAllProducts(IEnumerable<Product> products)
    {
        var allNewProduct = JsonSerializer.Serialize(products);
        File.WriteAllText(GetJsonFilePath(), allNewProduct);
    }

}