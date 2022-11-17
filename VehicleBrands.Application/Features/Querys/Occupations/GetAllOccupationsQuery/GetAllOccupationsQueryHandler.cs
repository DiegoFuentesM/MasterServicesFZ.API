using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Occupations.GetAllOccupationsQuery
{
    public class GetAllOccupationsQueryHandler : IRequestHandler<GetAllOccupationsQuery, List<GenericResponseVM>>
    {
        private readonly IOccupationRepository _occupationRepository;
        private readonly IMapper _mapper;

        public GetAllOccupationsQueryHandler(IOccupationRepository occupationRepository, IMapper mapper)
        {
            _occupationRepository = occupationRepository;
            _mapper = mapper;
        }

        public async Task<List<GenericResponseVM>> Handle(GetAllOccupationsQuery request, CancellationToken cancellationToken)
        {
            var listOccupations = await _occupationRepository.GetAllAsync();
            var occupations = _mapper.Map<List<GenericResponseVM>>(listOccupations).OrderBy(o => o.Value).ToList();
            return occupations;
        }
    }
}
