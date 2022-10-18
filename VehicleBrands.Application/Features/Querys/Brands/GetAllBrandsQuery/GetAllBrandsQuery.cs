using MediatR;
using MasterServicesFZ.Domain;

namespace MasterServicesFZ.Application.Features.Querys.Brands.GetAllBrandsQuery
{
    public class GetAllBrandsQuery : IRequest<List<VehicleBrand>>
    {
    }
}
