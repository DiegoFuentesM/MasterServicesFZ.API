using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MasterServicesFZ.Domain;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.VehicleModels.GetAllModelsByVehicleType
{
    public class GetAllModelsByVehicleTypeQueryHandler : IRequestHandler<GetAllModelsByVehicleTypeQuery, List<GenericResponseVM>>
    {
        private readonly IVehicleModelRepository _vehicleModelRepository;

        public GetAllModelsByVehicleTypeQueryHandler(IVehicleModelRepository vehicleModelRepository)
        {
            _vehicleModelRepository = vehicleModelRepository;
        }

        public async Task<List<GenericResponseVM>> Handle(GetAllModelsByVehicleTypeQuery request, CancellationToken cancellationToken)
        {
            return await _vehicleModelRepository.GetAllModelsByVehicleType(request.VehicleTypeId);
        }
    }
}
