// var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddHttpLogging(_ => { });
//
// var app = builder.Build();
//
// app.UseHttpLogging();
//
// app.MapGet("/", () => "Мое первое ASPA");
//
// app.Run();

using Microsoft.AspNetCore.HttpLogging;

namespace ASPA001;

// точка входа в программу
public class Program
{
    // Main метод вызывается при старте программы
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddHttpLogging(options =>
        {
            options.LoggingFields = HttpLoggingFields.RequestMethod
                                    | HttpLoggingFields.RequestPath
                                    | HttpLoggingFields.ResponseStatusCode
                                    | HttpLoggingFields.RequestHeaders
                                    | HttpLoggingFields.ResponseHeaders;
        });

        var app = builder.Build();

        app.UseHttpLogging();

        // создаем роут для вывода тексты
        app.MapGet("/", () => "Привет, ASPA001!");

        // запускаем 
        app.Run();
    }
}