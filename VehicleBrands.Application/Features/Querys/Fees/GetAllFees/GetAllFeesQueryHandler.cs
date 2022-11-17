using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Fees.GetAllFees
{
    public class GetAllFeesQueryHandler : IRequestHandler<GetAllFeesQuery, List<GenericResponseVM>>
    {
        private readonly IFeeRepository _FeeRepository;
        private readonly IMapper _mapper;

        public GetAllFeesQueryHandler(IFeeRepository feeRepository, IMapper mapper)
        {
            _FeeRepository = feeRepository;
            _mapper = mapper;
        }

        public async Task<List<GenericResponseVM>> Handle(GetAllFeesQuery request, CancellationToken cancellationToken)
        {
            var feeList = await _FeeRepository.GetAllAsync();
            return _mapper.Map<List<GenericResponseVM>>(feeList).OrderBy(f => f.Value).ToList();
        }
    }
}
