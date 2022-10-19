using MasterServicesFZ.Domain;

namespace MasterServicesFZ.Application.Contracts.Persistence
{
    public interface IMunicipalityRepository : IAsyncRepository<Municipality>
    {
        Task<IEnumerable<Municipality>> GetAllMunicipalityByDepartamentQuery(string departamentId);
    }
}
