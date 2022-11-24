using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.InternationalBusiness.GetAllInternationalBusiness
{
    public class GetAllInternationalBusinessQueryHandler : IRequestHandler<GetAllInternationalBusinessQuery, List<GenericResponseVM>>
    {
        private readonly IInternationalBusinessRepository _internationalBusinessRepository;
        private readonly IMapper _mapper;

        public GetAllInternationalBusinessQueryHandler(IInternationalBusinessRepository internationalBusinessRepository, IMapper mapper)
        {
            _internationalBusinessRepository = internationalBusinessRepository;
            _mapper = mapper;
        }

        public async Task<List<GenericResponseVM>> Handle(GetAllInternationalBusinessQuery request, CancellationToken cancellationToken)
        {
            var listIntternationalBusiness = await _internationalBusinessRepository.GetAllAsync();
            var internationalBusiness = _mapper.Map<List<GenericResponseVM>>(listIntternationalBusiness).OrderBy(x => x.Value).ToList();
            return internationalBusiness;
        }
    }
}
