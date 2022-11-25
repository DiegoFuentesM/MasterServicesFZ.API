using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Professions.GetAllProfessions
{
    public class GetAllProfessionsQuery : IRequest<List<GenericResponseVM>>
    {
    }
}
