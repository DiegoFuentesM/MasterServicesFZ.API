using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Fees.GetAllFees
{
    public class GetAllFeesQuery : IRequest<List<GenericResponseVM>>
    {
    }
}
