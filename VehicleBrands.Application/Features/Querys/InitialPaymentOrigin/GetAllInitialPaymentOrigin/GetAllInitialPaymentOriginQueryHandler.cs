using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.InitialPaymentOrigin.GetAllInitialPaymentOrigin
{
    public class GetAllInitialPaymentOriginQueryHandler : IRequestHandler<GetAllInitialPaymentOriginQuery, List<GenericResponseVM>>
    {
        private readonly IInitialPaymentOriginRepository _initialPaymentOriginRepository;
        private readonly IMapper _mapper;

        public GetAllInitialPaymentOriginQueryHandler(IInitialPaymentOriginRepository initialPaymentOriginRepository, IMapper mapper)
        {
            _initialPaymentOriginRepository = initialPaymentOriginRepository;
            _mapper = mapper;
        }

        public async Task<List<GenericResponseVM>> Handle(GetAllInitialPaymentOriginQuery request, CancellationToken cancellationToken)
        {
            var initialPaymentOrigins = await _initialPaymentOriginRepository.GetAllAsync();
            return _mapper.Map<List<GenericResponseVM>>(initialPaymentOrigins).OrderBy(o => o.Value).ToList();
        }
    }
}
