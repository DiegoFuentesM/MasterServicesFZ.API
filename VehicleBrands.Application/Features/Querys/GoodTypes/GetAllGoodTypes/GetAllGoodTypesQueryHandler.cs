using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.GoodTypes.GetAllGoodTypes
{
    public class GetAllGoodTypesQueryHandler : IRequestHandler<GetAllGoodTypesQuery, List<GenericResponseVM>>
    {
        private readonly IGoodTypeRepository _goodTypeRepository;
        private readonly IMapper _mapper;

        public GetAllGoodTypesQueryHandler(IGoodTypeRepository goodTypeRepository, IMapper mapper)
        {
            _goodTypeRepository = goodTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<GenericResponseVM>> Handle(GetAllGoodTypesQuery request, CancellationToken cancellationToken)
        {
            var listGoodTypes = await _goodTypeRepository.GetAllAsync();
            var goodTypes = _mapper.Map<List<GenericResponseVM>>(listGoodTypes).OrderBy(g => g.Value).ToList();
            return goodTypes;
        }
    }
}
