// using Presenters;
// using InversionOfControl;
// using EntityFrameworkCore;
// using EntityFrameworkCore.Repositories;
// using InteractorPorts.Calendar.Bloque.Input;
// using InteractorPorts.Calendar.Bloque.Output;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen(options =>
// {
//     options.SwaggerDoc("v1", new OpenApiInfo
//     {
//         Version = "v1",
//         Title = "Mi API",
//         Description = "Descripción de mi API"
//     });
// });

// builder.Services.AddProjectDependencies(builder.Configuration); // Inversión de control, ¿Se pueden agregar más cosas que estén en Program.cs?

builder.Services.AddCors
(
    options => options.AddDefaultPolicy(builder =>
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader())
);

var app = builder.Build();

app.Use(async (context, next) => // Middleware de registro de solicitudes
{
    Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
    await next.Invoke();
});

// app.UseSwagger();
// app.UseSwaggerUI(c =>
// {
//     c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mi API v1");
//     c.RoutePrefix = string.Empty; // opcional: hace que Swagger UI sea la página principal
// });

app.UseRouting();
app.UseCors();
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

app.Run();
