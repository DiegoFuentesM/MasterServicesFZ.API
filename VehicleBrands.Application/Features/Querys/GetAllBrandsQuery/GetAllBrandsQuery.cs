using MediatR;
using Core.Application.Features.Querys.GetAllBrandsQuery.Vm;
using Core.Domain;

namespace Core.Application.Features.Querys.GetAllBrandsQuery
{
    public class GetAllBrandsQuery : IRequest<List<VehicleBrand>>
    {
    }
}
