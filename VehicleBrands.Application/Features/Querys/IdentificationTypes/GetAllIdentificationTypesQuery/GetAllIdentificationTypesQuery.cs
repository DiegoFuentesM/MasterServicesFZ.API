using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.GetAllIdentificationTypesQuery
{
    public class GetAllIdentificationTypesQuery : IRequest<List<GenericResponseVM>>
    {
    }
}
