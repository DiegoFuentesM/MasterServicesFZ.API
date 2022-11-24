using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.MaritalStatuses.GetAllMaritalStatusesQuery
{
    public class GetAllMaritalStatusesQueryHandler : IRequestHandler<GetAllMaritalStatusesQuery, List<GenericResponseVM>>
    {
        private readonly IMaritalStatusRepository _maritalStatusRepository;
        private readonly IMapper _mapper;

        public GetAllMaritalStatusesQueryHandler(IMaritalStatusRepository maritalStatusRepository, IMapper mapper)
        {
            _maritalStatusRepository = maritalStatusRepository;
            _mapper = mapper;
        }

        public async Task<List<GenericResponseVM>> Handle(GetAllMaritalStatusesQuery request, CancellationToken cancellationToken)
        {
            var listMaritalStatuses = await _maritalStatusRepository.GetAllAsync();
            var maritalStatuses = _mapper.Map<List<GenericResponseVM>>(listMaritalStatuses).OrderBy(x => x.Value).ToList();
            return maritalStatuses;
        }
    }
}
