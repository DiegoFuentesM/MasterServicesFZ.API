using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.AccountTypes.GetAllActiveAccountTypes
{
    public class GetAllActiveAccountTypesQuery : IRequest<List<GenericResponseVM>>
    {
    }
}
