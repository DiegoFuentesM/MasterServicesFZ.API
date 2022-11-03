using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Municipalities.GetMunicipalityByDepartament
{
    public class GetAllMunicipalityByDepartamentQuery : IRequest<List<GenericResponseVM>>
    {
        public string _departament { get; set; } = String.Empty;

        public GetAllMunicipalityByDepartamentQuery(string departamentId)
        {
            _departament = departamentId ?? throw new ArgumentNullException(nameof(departamentId));
        }
    }
}
