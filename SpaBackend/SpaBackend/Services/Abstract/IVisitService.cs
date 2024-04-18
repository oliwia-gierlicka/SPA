using SpaBackend.Db.Entity;
using SpaBackend.Models;

namespace SpaBackend.Services.Abstract;

public interface IVisitService
{
    IEnumerable<Visit> Get(int userId);
    Task Delete(int id, int userId);
    Task Create(VisitForm form, int userId);
}