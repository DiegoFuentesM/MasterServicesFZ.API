using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.GetAllIdentificationTypesQuery
{
    public class GetAllIdentificationTypesQueryHandler : IRequestHandler<GetAllIdentificationTypesQuery, List<IdentificactionType>>
    {
        private readonly IIdentificationTypeRepository _identificationRepository;
        private readonly IMapper _mapper;

        public GetAllIdentificationTypesQueryHandler(IIdentificationTypeRepository identificationRepository, IMapper mapper)
        {
            _identificationRepository = identificationRepository;
            _mapper = mapper;
        }

        public async Task<List<IdentificactionType>> Handle(GetAllIdentificationTypesQuery request, CancellationToken cancellationToken)
        {
            var listIdentificationTypes = await _identificationRepository.GetAllAsync();
            var identificationTypes = _mapper.Map<List<IdentificactionType>>(listIdentificationTypes);
            return identificationTypes;
        }
           
    }
}
