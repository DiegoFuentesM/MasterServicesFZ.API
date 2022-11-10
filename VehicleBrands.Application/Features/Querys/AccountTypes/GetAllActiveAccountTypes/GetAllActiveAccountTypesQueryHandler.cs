using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.AccountTypes.GetAllActiveAccountTypes
{
    public class GetAllActiveAccountTypesQueryHandler : IRequestHandler<GetAllActiveAccountTypesQuery, List<GenericResponseVM>>
    {
        private readonly IAccountTypeRepository _accountTypeRepository;
        private readonly IMapper _mapper;

        public GetAllActiveAccountTypesQueryHandler(IAccountTypeRepository accountTypeRepository, IMapper mapper)
        {
            _accountTypeRepository = accountTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<GenericResponseVM>> Handle(GetAllActiveAccountTypesQuery request, CancellationToken cancellationToken)
        {
            var accountTypesList = await _accountTypeRepository.GetAllActive();
            var accountTypes = _mapper.Map<List<GenericResponseVM>>(accountTypesList);
            return accountTypes;
        }
    }
}
