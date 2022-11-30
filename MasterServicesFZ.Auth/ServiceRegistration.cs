using MasterServicesFZ.Application.Contracts.Auth;
using MasterServicesFZ.Auth.Handlers;
using MasterServicesFZ.Auth.Models;
using MasterServicesFZ.Auth.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MasterServicesFZ.Auth
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddAuthServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IClientService, ClientService>();
            services.AddScoped<ICacheService, CacheService>();

            services.Configure<ApikeyClientsSettings>(configuration.GetSection("ApikeyClientsSettings"));

            services.AddScoped<ApiKeyAuthenticationHandler>();

            services.AddAuthentication(o =>
            {
                o.DefaultScheme = ApiKeyAuthenticationOptions.DefaultScheme;
            }).AddScheme<ApiKeyAuthenticationOptions, ApiKeyAuthenticationHandler>(ApiKeyAuthenticationOptions.DefaultScheme, o => { });

            services.AddMemoryCache();
            return services;
        }
    }
}
