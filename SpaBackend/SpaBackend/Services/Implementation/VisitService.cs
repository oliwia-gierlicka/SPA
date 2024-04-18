using Microsoft.EntityFrameworkCore;
using SpaBackend.Db;
using SpaBackend.Db.Entity;
using SpaBackend.Models;
using SpaBackend.Services.Abstract;

namespace SpaBackend.Services.Implementation;

public class VisitService : IVisitService
{
    private readonly SpaDbContext _dbContext;

    public VisitService(SpaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<Visit> Get(int userId)
    {
        return _dbContext.Visits.Where(x => x.UserId == userId);
    }

    public async Task Delete(int id, int userId)
    {
        var visit = await _dbContext.Visits.FirstOrDefaultAsync(x=>x.Id==id);
        if (visit is not null && visit.UserId == userId)
        {
            _dbContext.Visits.Remove(visit);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task Create(VisitForm form, int userId)
    {
        if (_dbContext.Visits.Any(x=>
                (x.Date >= form.Date && form.Date.AddMinutes(form.Length) >= x.Date) ||
                (x.Date.AddMinutes(x.Length) >= form.Date && form.Date.AddMinutes(form.Length) >= x.Date.AddMinutes(x.Length))
            ))
        {
            _dbContext.Visits.Add(new Visit
            {
                ServiceName = form.ServiceName,
                Date = form.Date,
                Length = form.Length,
                EmployeeId = form.EmployeeId,
                UserId = userId
            });
        }

        await _dbContext.SaveChangesAsync();
    }
}