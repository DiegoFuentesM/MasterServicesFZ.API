using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Professions.GetAllProfessions
{
    public class GetAllProfessionsQueryHandler : IRequestHandler<GetAllProfessionsQuery, List<GenericResponseVM>>
    {
        private readonly IProfessionRepository _professionRepository;
        private readonly IMapper _mapper;

        public GetAllProfessionsQueryHandler(IProfessionRepository professionRepository, IMapper mapper)
        {
            _professionRepository = professionRepository;
            _mapper = mapper;
        }

        public async Task<List<GenericResponseVM>> Handle(GetAllProfessionsQuery request, CancellationToken cancellationToken)
        {
            var professions = await _professionRepository.GetAllAsync();
            return _mapper.Map<List<GenericResponseVM>>(professions).OrderBy(x => x.Value).ToList();
        }
    }
}
