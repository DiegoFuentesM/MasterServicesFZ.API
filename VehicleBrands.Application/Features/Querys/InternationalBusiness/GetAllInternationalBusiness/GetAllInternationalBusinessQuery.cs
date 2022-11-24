using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.InternationalBusiness.GetAllInternationalBusiness
{
    public class GetAllInternationalBusinessQuery : IRequest<List<GenericResponseVM>>
    {
    }
}
