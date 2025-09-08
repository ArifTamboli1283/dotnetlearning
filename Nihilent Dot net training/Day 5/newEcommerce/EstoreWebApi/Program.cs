var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddOpenApi();
builder.Services.AddCors(option =>
{
    option.AddPolicy("AllowAllOrgins",
    builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
    );
});
var app = builder.Build();

app.MapGet("/hello", () =>
{
    return "hello word";
});

app.MapGet("/api/products", () =>
{
    return new[] {
        new {id = 1, name = "abcd", price = 12121},
        new {id = 2, name = "", price = 0},
        new {id = 3, name = "", price = 0}
    };
});

app.MapPost("/api/products", (dynamic Product) =>
{
    // logic toadd new data
    return Results.Created($"/api/products/{Product.Id}", Product);
});

app.MapPut("/api/products/{id}", (int id, dynamic Product) =>
{
    // logic to amend data
    return Results.Ok(Product);
});

app.MapDelete("/api/products/{id}", (int id) =>
{
    //Logic to delete data
    return Results.NoContent();
});
app.Run();

