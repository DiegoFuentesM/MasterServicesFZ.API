using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Departaments.GetAllDepartaments
{
    public class GetAllDepartamentsQuery : IRequest<List<GenericResponseVM>>
    {
    }
}
