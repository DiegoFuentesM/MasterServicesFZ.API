using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.GoodTypes.GetAllGoodTypes
{
    public class GetAllGoodTypesQuery : IRequest<List<GenericResponseVM>>
    {
    }
}
