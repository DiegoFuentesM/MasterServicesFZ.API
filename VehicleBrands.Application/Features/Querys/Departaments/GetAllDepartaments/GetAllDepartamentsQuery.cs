using MasterServicesFZ.Domain;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Departaments.GetAllDepartaments
{
    public class GetAllDepartamentsQuery : IRequest<List<Departament>>
    {
    }
}
