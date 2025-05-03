using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
// using EFC.Template.Context;
using EFC.Template.Repositories;
using EFC.Template.Repositories.Interfaces;

namespace EFC;

public static class DependencyContainer
{
    public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
    {

        // services.AddDbContext<WeatherTemplateDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("ProyectoSpgdb")));

        services.AddScoped<IWeatherRepository, WeatherRepository>();

        return services;
    }
}
