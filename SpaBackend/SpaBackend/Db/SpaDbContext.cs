using Microsoft.EntityFrameworkCore;
using SpaBackend.Db.Entity;

namespace SpaBackend.Db;

public class SpaDbContext:DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Visit> Visits { get; set; }
    
    public SpaDbContext(DbContextOptions options) : base(options)
    {
    }
}