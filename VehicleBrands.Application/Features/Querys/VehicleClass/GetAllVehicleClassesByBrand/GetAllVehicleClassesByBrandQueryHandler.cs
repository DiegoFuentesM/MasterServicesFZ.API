using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.VehicleClass.GetAllVehicleClassesByBrand
{
    public class GetAllVehicleClassesByBrandQueryHandler : IRequestHandler<GetAllVehicleClassesByBrandQuery, List<VehicleClassVM>>
    {
        private readonly IVehicleClassRepository _vehicleClassRepository;
        private readonly IMapper _mapper;

        public GetAllVehicleClassesByBrandQueryHandler(IVehicleClassRepository vehicleClassRepository, IMapper mapper)
        {
            _vehicleClassRepository = vehicleClassRepository;
            _mapper = mapper;
        }

        public async Task<List<VehicleClassVM>> Handle(GetAllVehicleClassesByBrandQuery request, CancellationToken cancellationToken)
        {
            var classList = await _vehicleClassRepository.GetClassByBrandId(request._BrandId);
            return _mapper.Map<List<VehicleClassVM>>(classList);
        }
    }
}
