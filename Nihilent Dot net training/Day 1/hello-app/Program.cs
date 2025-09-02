// See https://aka.ms/new-console-template for more information
using Catolog;
int count = 50;
count++;
if (count > 50)
{
    Console.WriteLine("count is exceed 50");
} else {
    Console.WriteLine("count is less than 50");
}
Console.WriteLine(count);

Product product= new Product("Laptop", 1000);
Console.WriteLine($"Product Name: {product.GetName()}, price : {product.GetPrice()}");

Product roduct= new Product();
Console.WriteLine($"Product Name: {roduct.GetName()}, price : {roduct.GetPrice()}");
