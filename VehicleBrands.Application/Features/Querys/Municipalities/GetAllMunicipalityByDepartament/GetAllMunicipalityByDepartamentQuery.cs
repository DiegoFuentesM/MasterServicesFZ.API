using MasterServicesFZ.Domain;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.Municipalities.GetMunicipalityByDepartament
{
    public class GetAllMunicipalityByDepartamentQuery : IRequest<List<Municipality>>
    {
        public string _departament { get; set; } = String.Empty;

        public GetAllMunicipalityByDepartamentQuery(string departamentId)
        {
            _departament = departamentId ?? throw new ArgumentNullException(nameof(departamentId));
        }
    }
}
