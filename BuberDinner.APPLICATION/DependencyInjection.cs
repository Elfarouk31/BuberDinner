
using BuberDinner.APPLICATION.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.APPLICATION;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationServices, AuthenticationServices>();
        return services;
    }
}