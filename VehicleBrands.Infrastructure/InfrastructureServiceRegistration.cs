using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VehicleBrands.Application.Contracts.Persistence;
using VehicleBrands.Infrastructure.Persistence;
using VehicleBrands.Infrastructure.Repositories;

namespace VehicleBrands.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VehicleBrandsDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("PostgreConnection"))
            );
                
            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IVehicleBrandRepository, BrandRepository>();

            return services;
        }
    }
}
