using MasterServicesFZ.Domain;

namespace MasterServicesFZ.Application.Contracts.Persistence
{
    public interface IVehicleTypeRepository : IAsyncRepository<VehicleType>
    {
        public Task<int> GetClassBrandId(string classId, string brandId);
        public Task<List<VehicleType>> GetAllByClassBrandId(int classBrandId);
    }
}
