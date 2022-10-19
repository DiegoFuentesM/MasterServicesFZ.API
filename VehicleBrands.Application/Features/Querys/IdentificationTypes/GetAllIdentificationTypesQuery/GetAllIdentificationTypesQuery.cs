using MasterServicesFZ.Domain;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.GetAllIdentificationTypesQuery
{
    public class GetAllIdentificationTypesQuery : IRequest<List<IdentificactionType>>
    {
    }
}
