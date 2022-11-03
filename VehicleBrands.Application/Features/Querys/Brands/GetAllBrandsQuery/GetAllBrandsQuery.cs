using MediatR;
using MasterServicesFZ.Application.Features.Shared.VMs;

namespace MasterServicesFZ.Application.Features.Querys.Brands.GetAllBrandsQuery
{
    public class GetAllBrandsQuery : IRequest<List<GenericResponseVM>>
    {
    }
}
