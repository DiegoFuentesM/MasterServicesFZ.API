using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Infrastructure.Persistence;
using MasterServicesFZ.Infrastructure.Repositories;

namespace MasterServicesFZ.Infrastructure
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
            services.AddDbContext<CreditProductsDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("CreditProductsConnection"))
            );

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped(typeof(IAsyncRepository<>), typeof(SqlRepositoryBase<>));

            services.AddScoped<IVehicleBrandRepository, BrandRepository>();
            services.AddScoped<IIdentificationTypeRepository, IdentificationTypeRepository>();
            services.AddScoped<IDepartamentRepository, DepartamentRepository>();
            services.AddScoped<IVehicleTypeRepository, VehicleTypeRepository>();
            services.AddScoped<IMunicipalityRepository, MunicipalityRepository>();
            services.AddScoped<IVehicleClassRepository, VehicleClassRepository>();
            services.AddScoped<IFeeRepository, FeeRepository>();
            services.AddScoped<IVehicleModelRepository, VehicleModelRepository>();
            services.AddScoped<IOccupationRepository, OccupationRepository>();
            services.AddScoped<IContractTypeRepository, ContractTypeRepository>();
            services.AddScoped<IAccountTypeRepository, AccountTypeRepository>();

            return services;
        }
    }
}
