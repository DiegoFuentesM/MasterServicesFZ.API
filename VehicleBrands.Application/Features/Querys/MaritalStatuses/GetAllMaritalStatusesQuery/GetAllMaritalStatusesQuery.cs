using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.MaritalStatuses.GetAllMaritalStatusesQuery
{
    public class GetAllMaritalStatusesQuery : IRequest<List<GenericResponseVM>>
    {
    }
}
