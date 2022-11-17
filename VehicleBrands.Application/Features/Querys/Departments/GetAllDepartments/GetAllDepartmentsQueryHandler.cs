using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Departaments.GetAllDepartaments
{
    public class GetAllDepartmentsQueryHandler : IRequestHandler<GetAllDepartmentsQuery, List<GenericResponseVM>>
    {
        private readonly IDepartmentRepository _DepartmentRepository;
        private readonly IMapper _mapper;

        public GetAllDepartmentsQueryHandler(IDepartmentRepository departamentRepository, IMapper mapper)
        {
            _DepartmentRepository = departamentRepository;
            _mapper = mapper;
        }

        public async Task<List<GenericResponseVM>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
        {
            var departamentList = await _DepartmentRepository.GetAllAsync();
            var departaments = _mapper.Map<List<GenericResponseVM>>(departamentList.OrderBy(d => d.Nombre).ToList());
            return departaments;
        }
    }
}
