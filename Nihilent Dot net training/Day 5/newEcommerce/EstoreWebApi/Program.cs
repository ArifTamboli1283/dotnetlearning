var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
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

app.MapGet("/api/product", () =>
{
    return new[] {
        new {id = 1, name = "abcd", price = 12121},
        new {id = 2, name = "", price = 0},
        new {id = 3, name = "", price = 0}
    };
});
app.Run();

