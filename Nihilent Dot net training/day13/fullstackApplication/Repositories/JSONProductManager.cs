namespace Repositories;
using System.Collections.Generic;
using Entities;
using System.IO;
using System.Text.Json;
public static class JSONCatologManager
{
    public static string GetJsonFilePath()
    {
        return Path.Combine(Directory.GetCurrentDirectory(), "Data", "Product.json");
    }

    public static IEnumerable<Product>? GetProduct()
    {
        var jsonfile = File.ReadAllText(GetJsonFilePath());
        return JsonSerializer.Deserialize<IEnumerable<Product>>(jsonfile);
    }

    
    public static void SaveProduct(IEnumerable<Product> products)
    {
        var json = JsonSerializer.Serialize(products);
        File.WriteAllText(GetJsonFilePath(), json);
    }
}