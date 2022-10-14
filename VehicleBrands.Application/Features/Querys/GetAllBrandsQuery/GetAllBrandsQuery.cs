using MediatR;
using VehicleBrands.Application.Features.Querys.GetAllBrandsQuery.Vm;
using VehicleBrands.Domain;

namespace VehicleBrands.Application.Features.Querys.GetAllBrandsQuery
{
    public class GetAllBrandsQuery : IRequest<List<VehicleBrand>>
    {
    }
}
