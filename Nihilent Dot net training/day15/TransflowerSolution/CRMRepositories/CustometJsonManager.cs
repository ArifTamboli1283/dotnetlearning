using CRMEntities;
public static class CustomerJsonManager
{
    public static getJsonPath()
    {
        return @"C:\Users\arif.tamboli_6361\Desktop\DotNetLerning\dotnetlearning\Nihilent Dot net training\day15\Data\Customer.json";
    }

    public static IEnumerable<Customer> getAllCutomer()
    {

        string filePath = @"C:\Users\arif.tamboli_6361\Desktop\DotNetLerning\dotnetlearning\Nihilent Dot net training\day15\Data\Customer.json";
        var jsonFile = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Customer>>(jsonFile);
    }

     public static void SaveALlCustomer(IEnumerable<Product> products)
    {
        string filePath = @"C:\Users\arif.tamboli_6361\Desktop\DotNetLerning\dotnetlearning\Nihilent Dot net training\day15\Data\Customer.json";
        var jsonFile = JsonSerializer.Serialize(products);
        return Fill.WriteAllText(filePath, jsonFile);
    }
}