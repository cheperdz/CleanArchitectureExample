using Microsoft.Extensions.DependencyInjection;
using Ports.Template.Output;
using Presenters.Template;

namespace Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddPresenters(this IServiceCollection services)
    {
        services.AddScoped<ICreateWeatherOutputPort, CreateWeatherResponse>();
        services.AddScoped<IGetWeatherOutputPort, GetWeatherResponse>();

        return services;
    }
}
