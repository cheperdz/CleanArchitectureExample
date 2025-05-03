using EFC;
using Interactors;
using Presenters;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddProjectDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddRepositories(configuration);
        services.AddUseCaseInteractors();
        services.AddPresenters();
        return services;
    }
}
