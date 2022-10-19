using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Municipalities.GetMunicipalityByDepartament
{
    public class GetMunicipalityByDepartamentQueryHandler : IRequestHandler<GetAllMunicipalityByDepartamentQuery, List<Municipality>>
    {
        private readonly IMunicipalityRepository _municipalityRepository;
        private readonly IMapper _mapper;

        public GetMunicipalityByDepartamentQueryHandler(IMunicipalityRepository municipalityRepository, IMapper mapper)
        {
            _municipalityRepository = municipalityRepository;
            _mapper = mapper;
        }

        public async Task<List<Municipality>> Handle(GetAllMunicipalityByDepartamentQuery request, CancellationToken cancellationToken)
        {
            var municipalityEntity = _mapper.Map<Municipality>(request);
            var municipalityList = await _municipalityRepository.GetAllMunicipalityByDepartamentQuery(request._departament).ToList();
            return municipalityList;
        }
    }
}
