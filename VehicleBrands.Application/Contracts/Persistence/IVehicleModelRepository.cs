using MasterServicesFZ.Application.Features.Shared.VMs;
using MasterServicesFZ.Domain;

namespace MasterServicesFZ.Application.Contracts.Persistence
{
    public interface IVehicleModelRepository : IAsyncRepository<GenericResponseVM>
    {
        Task<List<GenericResponseVM>> GetAllModelsByVehicleType(int vehicleType);
    }
}
