using MasterServicesFZ.Application.Features.Shared.VMs;
using MasterServicesFZ.Domain;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.VehicleModels.GetAllModelsByVehicleType
{
    public class GetAllModelsByVehicleTypeQuery : IRequest<List<GenericResponseVM>>
    {
        public int VehicleTypeId { get; set; }

        public GetAllModelsByVehicleTypeQuery(int vehicleTypeId)
        {
            VehicleTypeId = vehicleTypeId;
        }
    }
}
