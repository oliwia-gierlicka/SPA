using Microsoft.EntityFrameworkCore;
using SpaBackend.Db.Entity;

namespace SpaBackend.Db;

public class SpaDbContext:DbContext
{
    public DbSet<Product> Products { get; set; }

    public SpaDbContext(DbContextOptions options) : base(options)
    {
    }
}