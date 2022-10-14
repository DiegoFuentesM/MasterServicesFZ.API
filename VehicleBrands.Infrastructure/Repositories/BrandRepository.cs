using VehicleBrands.Application.Contracts.Persistence;
using VehicleBrands.Domain;
using VehicleBrands.Infrastructure.Persistence;

namespace VehicleBrands.Infrastructure.Repositories
{
    public class BrandRepository : RepositoryBase<VehicleBrand>, IVehicleBrandRepository
    {
        public BrandRepository(VehicleBrandsDbContext context) : base(context)
        {
        }
    }
}
