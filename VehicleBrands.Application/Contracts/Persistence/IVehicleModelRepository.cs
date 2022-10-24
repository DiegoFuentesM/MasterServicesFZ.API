using MasterServicesFZ.Domain;

namespace MasterServicesFZ.Application.Contracts.Persistence
{
    public interface IVehicleModelRepository : IAsyncRepository<VehicleModel>
    {
        Task<List<int>> GetAllModelsByVehicleType(int vehicleType);
    }
}
