using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.ContractTypes.GetAllContractTypes
{
    public class GetAllContractTypesQuery : IRequest<List<GenericResponseVM>>
    {
    }
}
