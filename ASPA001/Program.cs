using Microsoft.AspNetCore.HttpLogging;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpLogging(_ => { });

var app = builder.Build();

app.UseHttpLogging();

app.MapGet("/", () =>
    "Поздравляем, вы запустили ASP.NET Core!\n" +
    "Посетитель! Добро пожаловать на ASPA001!\n" +
    $"ASPA001 версия: {System.Environment.Version}"
);

app.Run();
