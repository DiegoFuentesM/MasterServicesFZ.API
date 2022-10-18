using MasterServicesFZ.Domain;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.GetAllIdinticationTypesQuery
{
    public class GetAllIdentificationTypesQuery : IRequest<List<IdentificactionType>>
    {
    }
}
