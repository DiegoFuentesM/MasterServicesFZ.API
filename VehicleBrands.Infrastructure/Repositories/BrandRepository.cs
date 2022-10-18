using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Infrastructure.Persistence;

namespace MasterServicesFZ.Infrastructure.Repositories
{
    public class BrandRepository : RepositoryBase<VehicleBrand>, IVehicleBrandRepository
    {
        public BrandRepository(PostgresDbContext context) : base(context)
        {
        }
    }
}
