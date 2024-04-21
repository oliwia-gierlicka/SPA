using SpaBackend.Db.Entity;
using SpaBackend.Models;

namespace SpaBackend.Services.Abstract;

public interface IVisitService
{
    IEnumerable<Visit> Get(int userId);
    IEnumerable<Visit> GetEmployeeVisits(int userId);
    Task Delete(int id, int userId);
    Task Create(VisitForm form, int userId);
    Task<IEnumerable<DateTime>> GetAvailability(int serviceId, int employeeId, DateTime when);
}