using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Occupations.GetAllOccupationsQuery
{
    public class GetAllOccupationsQueryHandler : IRequestHandler<GetAllOccupationsQuery, List<Occupation>>
    {
        private readonly IOccupationRepository _occupationRepository;
        private readonly IMapper _mapper;

        public GetAllOccupationsQueryHandler(IOccupationRepository occupationRepository, IMapper mapper)
        {
            _occupationRepository = occupationRepository;
            _mapper = mapper;
        }

        public async Task<List<Occupation>> Handle(GetAllOccupationsQuery request, CancellationToken cancellationToken)
        {
            var listOccupations = await _occupationRepository.GetAllAsync();
            var occupations = _mapper.Map<List<Occupation>>(listOccupations);
            return occupations;
        }
    }
}
