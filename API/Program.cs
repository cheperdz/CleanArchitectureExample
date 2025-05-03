using IoC;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Template API",
        Description = "Template API using Clean Architecture with a SQLite .db file as Database, template is dockerized on the API section, programmed by irony",
        License = new OpenApiLicense
        {
            Name = "MIT License",
            Url = new Uri("https://opensource.org/licenses/MIT")
        }
    });
});

builder.Services.AddProjectDependencies(builder.Configuration);

builder.Services.AddCors
(
    options => options.AddDefaultPolicy
    (
        policyBuilder =>
            policyBuilder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
    )
);

var app = builder.Build();

app.Use(async (context, next) => // Middleware de registro de solicitudes
{
    Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
    await next.Invoke();
});

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Template API - Clean Architecture");
    c.RoutePrefix = string.Empty; // Hacer que Swagger UI sea la página principal
});

app.UseRouting();
app.UseCors();
app.MapControllers();

app.Run();
