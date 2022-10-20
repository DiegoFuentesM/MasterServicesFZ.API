using MasterServicesFZ.Domain;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Fees.GetAllFees
{
    public class GetAllFeesQuery : IRequest<List<Fee>>
    {
    }
}
