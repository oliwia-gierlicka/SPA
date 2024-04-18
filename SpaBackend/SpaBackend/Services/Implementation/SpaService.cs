using SpaBackend.Db;
using SpaBackend.Db.Entity;
using SpaBackend.Services.Abstract;

namespace SpaBackend.Services.Implementation;

public class SpaService : ISpaService
{
    private readonly SpaDbContext _dbContext;

    public SpaService(SpaDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public IEnumerable<Service> GetServicesByCategory(string name)
    {
        return _dbContext.Services.Where(x => x.Category == name);
    }
}