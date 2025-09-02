var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpLogging(_ => { });

var app = builder.Build();

app.UseHttpLogging();

app.MapGet("/", () => "Мое первое ASPA");

app.Run();