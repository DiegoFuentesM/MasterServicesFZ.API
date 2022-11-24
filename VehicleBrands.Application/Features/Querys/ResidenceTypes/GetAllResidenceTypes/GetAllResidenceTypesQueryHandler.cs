using AutoMapper;
using MasterServicesFZ.Application.Contracts.Persistence;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterServicesFZ.Application.Features.Querys.ResidenceTypes.GetAllResidenceTypes
{
    public class GetAllResidenceTypesQueryHandler : IRequestHandler<GetAllResidenceTypesQuery, List<GenericResponseVM>>
    {
        private readonly IResidenceTypeRepository _residenceTypeRepository;
        private readonly IMapper _mapper;

        public GetAllResidenceTypesQueryHandler(IResidenceTypeRepository residenceTypeRepository, IMapper mapper)
        {
            _residenceTypeRepository = residenceTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<GenericResponseVM>> Handle(GetAllResidenceTypesQuery request, CancellationToken cancellationToken)
        {
            var listResidenceTypes = await _residenceTypeRepository.GetAllAsync();
            var residenceTypes = _mapper.Map<List<GenericResponseVM>>(listResidenceTypes).OrderBy(x => x.Value).ToList();
            return residenceTypes;
        }
    }
}
