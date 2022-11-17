using AutoMapper;
using MediatR;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MasterServicesFZ.Application.Features.Shared.VMs;

namespace MasterServicesFZ.Application.Features.Querys.Brands.GetAllBrandsQuery
{
    public class GetAllBrandsQueryHandler : IRequestHandler<GetAllBrandsQuery, List<GenericResponseVM>>
    {
        private readonly IVehicleBrandRepository _vehicleBrandRepository;
        private readonly IMapper _mapper;

        public GetAllBrandsQueryHandler(IVehicleBrandRepository vehicleBrandRepository, IMapper mapper)
        {
            _vehicleBrandRepository = vehicleBrandRepository;
            _mapper = mapper;
        }

        public async Task<List<GenericResponseVM>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            var vehicleBrandList = await _vehicleBrandRepository.GetAllAsync();
            var brands = _mapper.Map<List<GenericResponseVM>>(vehicleBrandList.OrderBy(b => b.nombre).ToList());
            return brands;
        }
    }
}
