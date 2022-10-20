using MasterServicesFZ.Domain;

namespace MasterServicesFZ.Application.Contracts.Persistence
{
    public interface IMunicipalityRepository : IAsyncRepository<Municipality>
    {
        Task<List<Municipality>> GetAllMunicipalityByDepartamentQuery(string departamentId);
    }
}
