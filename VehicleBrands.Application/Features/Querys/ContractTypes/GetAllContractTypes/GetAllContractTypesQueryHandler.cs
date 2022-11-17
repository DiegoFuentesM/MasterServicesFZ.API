using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.ContractTypes.GetAllContractTypes
{
    internal class GetAllContractTypesQueryHandler : IRequestHandler<GetAllContractTypesQuery, List<GenericResponseVM>>
    {
        private readonly IContractTypeRepository _contractTypeRepository;
        private readonly IMapper _mapper;

        public GetAllContractTypesQueryHandler(IContractTypeRepository contractTypeRepository, IMapper mapper)
        {
            _contractTypeRepository = contractTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<GenericResponseVM>> Handle(GetAllContractTypesQuery request, CancellationToken cancellationToken)
        {
            var contractTypesList = await _contractTypeRepository.GetAllAsync();
            var contractTypes = _mapper.Map<List<GenericResponseVM>>(contractTypesList).OrderBy(c => c.Value).ToList();
            return contractTypes;
        }
    }
}
