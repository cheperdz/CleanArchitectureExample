using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EFC.Template.Context;
using EFC.Template.Repositories;
using EFC.Template.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EFC;

public static class DependencyContainer
{
    public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<WeatherTemplateDbContext>(options => options.UseSqlite(configuration.GetConnectionString("WeatherTemplate")));

        services.AddScoped<IWeatherRepository, WeatherRepository>();

        return services;
    }
}
