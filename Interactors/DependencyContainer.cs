using Microsoft.Extensions.DependencyInjection;
using Ports.Input;

namespace Interactors;

public static class DependencyContainer
{
    public static IServiceCollection AddUseCaseInteractors(this IServiceCollection services)
    {
        services.AddScoped<ICreateWeatherInputPort, CreateWeatherInteractor>();
        services.AddScoped<IGetWeatherInputPort, GetWeatherInteractor>();

        return services;
    }
}
