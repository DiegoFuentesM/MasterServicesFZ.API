using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Core.Application.Contracts.Persistence;
using Infrastructure.Persistence;
using Infrastructure.Repositories;
using MasterServicesFZ.Infrastructure.Persistence;

namespace Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PostgresDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("PostgreConnection"))
            );
            services.AddDbContext<SqlDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SqlConnection"))
            );

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IVehicleBrandRepository, BrandRepository>();

            return services;
        }
    }
}
