using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.VehicleTypes.GetAllVehicleTypesByBrandAndClassQuery
{
    public class GetAllVehicleTypesByBrandAndClassQueryHandler : IRequestHandler<GetAllVehicleTypesByBrandAndClassQuery, List<VehicleType>>
    {
        private readonly IVehicleTypeRepository _vehicleTypeRepository;
        private readonly IMapper _mapper;

        public GetAllVehicleTypesByBrandAndClassQueryHandler(IVehicleTypeRepository vehicleTypeRepository, IMapper mapper)
        {
            _vehicleTypeRepository = vehicleTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<VehicleType>> Handle(GetAllVehicleTypesByBrandAndClassQuery request, CancellationToken cancellationToken)
        {
            int classBrandId = await _vehicleTypeRepository.GetClassBrandId(request.ClassId, request.BrandId);
            var listVehicleTypes = await _vehicleTypeRepository.GetAllByClassBrandId(classBrandId);
            var vehicleTypes = _mapper.Map<List<VehicleType>>(listVehicleTypes);
            return vehicleTypes;
        }
    }
}
