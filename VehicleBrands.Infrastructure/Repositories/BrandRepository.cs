using Core.Application.Contracts.Persistence;
using Core.Domain;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories
{
    public class BrandRepository : RepositoryBase<VehicleBrand>, IVehicleBrandRepository
    {
        public BrandRepository(PostgresDbContext context) : base(context)
        {
        }
    }
}
