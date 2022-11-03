using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Occupations.GetAllOccupationsQuery
{
    public class GetAllOccupationsQuery : IRequest<List<GenericResponseVM>>
    {
    }
}
