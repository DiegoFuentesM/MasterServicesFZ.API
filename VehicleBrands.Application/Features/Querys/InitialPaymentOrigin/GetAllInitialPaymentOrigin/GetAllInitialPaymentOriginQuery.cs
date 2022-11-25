using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.InitialPaymentOrigin.GetAllInitialPaymentOrigin
{
    public class GetAllInitialPaymentOriginQuery : IRequest<List<GenericResponseVM>>
    {
    }
}
