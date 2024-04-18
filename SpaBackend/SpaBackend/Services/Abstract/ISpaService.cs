using SpaBackend.Db.Entity;

namespace SpaBackend.Services.Abstract;

public interface ISpaService
{
    IEnumerable<Service> GetServicesByCategory(string name);
}