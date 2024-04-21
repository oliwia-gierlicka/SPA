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
        return _dbContext.Visits.Where(x => x.UserId == userId).OrderByDescending(x => x.Date);
    }
    
    public IEnumerable<Visit> GetEmployeeVisits(int userId)
    {
        return _dbContext.Visits.Where(x => x.EmployeeId == userId).OrderByDescending(x => x.Date);
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
        var service = await _dbContext.Services.FirstOrDefaultAsync(x => x.Id == form.ServiceId);
        var serviceLength = service?.Length ?? 100000;
        if (!_dbContext.Visits.Any(x=>
                (x.Date >= form.Date && form.Date.AddMinutes(serviceLength) >= x.Date) ||
                (x.Date.AddMinutes(x.Length) >= form.Date && form.Date.AddMinutes(serviceLength) >= x.Date.AddMinutes(x.Length))
            ))
        {
            _dbContext.Visits.Add(new Visit
            {
                ServiceName = service?.Name ?? "",
                Date = form.Date,
                Length = serviceLength,
                EmployeeId = form.EmployeeId,
                UserId = userId
            });
        }

        await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<DateTime>> GetAvailability(int serviceId, int employeeId, DateTime when)
    {
        var employeeReservations = _dbContext.Visits.Where(x => x.EmployeeId == employeeId);
        var serviceLength = (await _dbContext.Services.FirstOrDefaultAsync(x => x.Id == serviceId))?.Length ?? 100000;
        
        var startTime = new DateTime(when.Year, when.Month, when.Day, 8, 0, 0);
        var endTime = new DateTime(when.Year, when.Month, when.Day, 16, 0, 0);
        var availableSlots = new List<DateTime>();

        while (startTime < endTime)
        {
            if (!employeeReservations.Any(x => x.Date == startTime))
                availableSlots.Add(startTime);

            startTime = startTime.AddMinutes(serviceLength);
        }
        
        return availableSlots;
    }
}