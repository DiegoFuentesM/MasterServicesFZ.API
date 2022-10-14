using VehicleBrands.Domain;

namespace VehicleBrands.Application.Contracts.Persistence
{
    public interface IVehicleBrandRepository : IAsyncRepository<VehicleBrand>
    {
    }
}
