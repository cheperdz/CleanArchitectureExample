using EFC.Template.Configuration;
using Entities.Template;
using Microsoft.EntityFrameworkCore;

namespace EFC.Template.Context;

public class WeatherTemplateDbContext(DbContextOptions<WeatherTemplateDbContext> options) : DbContext(options)
{
    public DbSet<Weather> Weathers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new WeatherTypeConfiguration());
    }
}
