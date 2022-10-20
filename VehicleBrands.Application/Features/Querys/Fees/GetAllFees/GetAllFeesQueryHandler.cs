using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Domain;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Fees.GetAllFees
{
    public class GetAllFeesQueryHandler : IRequestHandler<GetAllFeesQuery, List<Fee>>
    {
        private readonly IFeeRepository _FeeRepository;
        private readonly IMapper _mapper;

        public GetAllFeesQueryHandler(IFeeRepository feeRepository, IMapper mapper)
        {
            _FeeRepository = feeRepository;
            _mapper = mapper;
        }

        public async Task<List<Fee>> Handle(GetAllFeesQuery request, CancellationToken cancellationToken)
        {
            var feeList = await _FeeRepository.GetAllAsync();
            return _mapper.Map<List<Fee>>(feeList);
        }
    }
}
