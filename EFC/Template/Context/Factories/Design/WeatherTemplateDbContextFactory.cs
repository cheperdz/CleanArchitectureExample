using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.IO;

namespace EFC.Template.Context.Factories.Design;

/// <summary> Design time factory for creating the database context </summary>
public class WeatherTemplateDbContextFactory : IDesignTimeDbContextFactory<WeatherTemplateDbContext>
{
    // SQLite connection string (archivo local)
    private static readonly string ConnectionStringSqlite = "Data Source=WeatherTemplate.db";

    // Alternativa: SQLite en memoria (los datos se pierden al cerrar la aplicación)
    // private static readonly string ConnectionStringSqliteInMemory = "Data Source=:memory:";

    public WeatherTemplateDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<WeatherTemplateDbContext>();

        // Configurar SQLite
        builder.UseSqlite(ConnectionStringSqlite);

        return new WeatherTemplateDbContext(builder.Options);
    }
}
