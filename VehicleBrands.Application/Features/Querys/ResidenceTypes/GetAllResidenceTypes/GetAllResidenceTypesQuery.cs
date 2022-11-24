using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.ResidenceTypes.GetAllResidenceTypes
{
    public class GetAllResidenceTypesQuery : IRequest<List<GenericResponseVM>>
    {
    }
}
