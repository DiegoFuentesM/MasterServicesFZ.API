using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Municipalities.GetMunicipalityByDepartament
{
    public class GetMunicipalityByDepartamentQueryHandler : IRequestHandler<GetAllMunicipalityByDepartamentQuery, List<GenericResponseVM>>
    {
        private readonly IMunicipalityRepository _municipalityRepository;
        private readonly IMapper _mapper;

        public GetMunicipalityByDepartamentQueryHandler(IMunicipalityRepository municipalityRepository, IMapper mapper)
        {
            _municipalityRepository = municipalityRepository;
            _mapper = mapper;
        }

        public async Task<List<GenericResponseVM>> Handle(GetAllMunicipalityByDepartamentQuery request, CancellationToken cancellationToken)
        {
            var municipalityList = await _municipalityRepository.GetAllMunicipalityByDepartamentQuery(request._departament);

            return _mapper.Map<List<GenericResponseVM>>(municipalityList);
        }
    }
}
