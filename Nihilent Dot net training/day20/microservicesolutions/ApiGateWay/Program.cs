using Ocelet.DependacyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("ocelot.json", optional = false, reloadOnChange: true);
builder.service.AddOcelot();
var app = builder.Build();
await app.UseOcelot();
app.Run();
