using MasterServicesFZ.Domain;

namespace MasterServicesFZ.Application.Contracts.Persistence
{
    public interface IVehicleClassRepository : IAsyncRepository<VehicleClassBrand>
    {
        Task<List<VehicleClassBrand>> GetClassByBrandId(string brandId);
    }
}
