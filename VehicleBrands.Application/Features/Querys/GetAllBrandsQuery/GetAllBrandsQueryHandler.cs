using AutoMapper;
using MediatR;
using Core.Application.Contracts.Persistence;
using Core.Application.Features.Querys.GetAllBrandsQuery.Vm;
using Core.Domain;

namespace Core.Application.Features.Querys.GetAllBrandsQuery
{
    public class GetAllBrandsQueryHandler : IRequestHandler<GetAllBrandsQuery, List<VehicleBrand>>
    {
        private readonly IVehicleBrandRepository _vehicleBrandRepository;
        private readonly IMapper _mapper;

        public GetAllBrandsQueryHandler(IVehicleBrandRepository vehicleBrandRepository, IMapper mapper)
        {
            _vehicleBrandRepository = vehicleBrandRepository;
            _mapper = mapper;
        }

        public async Task<List<VehicleBrand>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            var vehicleBrandList = await _vehicleBrandRepository.GetAllAsync();
            var brands = _mapper.Map<List<VehicleBrand>>(vehicleBrandList.ToList());
            return brands;
            //throw new NotImplementedException();
        }
    }
}
