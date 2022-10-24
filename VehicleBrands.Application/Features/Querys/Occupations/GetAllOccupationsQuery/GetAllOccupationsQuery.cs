using MasterServicesFZ.Domain;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Occupations.GetAllOccupationsQuery
{
    public class GetAllOccupationsQuery : IRequest<List<Occupation>>
    {
    }
}
