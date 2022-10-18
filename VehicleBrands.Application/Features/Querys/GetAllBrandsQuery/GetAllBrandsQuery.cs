using MediatR;
using MasterServicesFZ.Application.Features.Querys.GetAllBrandsQuery.Vm;
using MasterServicesFZ.Domain;

namespace MasterServicesFZ.Application.Features.Querys.GetAllBrandsQuery
{
    public class GetAllBrandsQuery : IRequest<List<VehicleBrand>>
    {
    }
}
