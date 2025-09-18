namespace CatologRepositories;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using CatologEntities;
public static class JSONProductManager
{
    public static string GetJsonFilePath()
    {
        string filePath = @"C:\Users\arif.tamboli_6361\Desktop\DotNetLerning\dotnetlearning\Nihilent Dot net training\day15\Data\Product.json";
        return filePath;
    }
    public static IEnumerable<Product> GetAllProduct()
    {
        string filePath = @"C:\Users\arif.tamboli_6361\Desktop\DotNetLerning\dotnetlearning\Nihilent Dot net training\day15\Data\Product.json";
        var jsonFile = File.ReadAllText(filePath);
        // var jsonFile = File.ReadAllText(GetJsonFilePath());
        return JsonSerializer.Deserialize<List<Product>>(jsonFile);
    }

    public static void SaveAllProducts(IEnumerable<Product> products)
    {
        string filePath = @"C:\Users\arif.tamboli_6361\Desktop\DotNetLerning\dotnetlearning\Nihilent Dot net training\day15\Data\Product.json";
        var allNewProduct = JsonSerializer.Serialize(products);
        File.WriteAllText(filePath, allNewProduct);
    }

}