using MasterServicesFZ.Domain;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.VehicleModels.GetAllModelsByVehicleType
{
    public class GetAllModelsByVehicleTypeQuery : IRequest<List<int>>
    {
        public int VehicleTypeId { get; set; }

        public GetAllModelsByVehicleTypeQuery(int vehicleTypeId)
        {
            VehicleTypeId = vehicleTypeId;
        }
    }
}
