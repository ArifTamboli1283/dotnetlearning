// See https://aka.ms/new-console-template for more information


string connectionString = "mongodb://localhost:27017";
string databseName = "ecommerce";
string collectionName = "products";

var repo = new ProgramRepository(connectionString, databseName, collectionName);    
Console.WriteLine("Hello, World!");
