using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Departaments.GetAllDepartaments
{
    public class GetAllDepartamentsQueryHandler : IRequestHandler<GetAllDepartamentsQuery, List<GenericResponseVM>>
    {
        private readonly IDepartamentRepository _DepartamentRepository;
        private readonly IMapper _mapper;

        public GetAllDepartamentsQueryHandler(IDepartamentRepository departamentRepository, IMapper mapper)
        {
            _DepartamentRepository = departamentRepository;
            _mapper = mapper;
        }

        public async Task<List<GenericResponseVM>> Handle(GetAllDepartamentsQuery request, CancellationToken cancellationToken)
        {
            var departamentList = await _DepartamentRepository.GetAllAsync();
            var departaments = _mapper.Map<List<GenericResponseVM>>(departamentList.ToList());
            return departaments;
        }
    }
}
