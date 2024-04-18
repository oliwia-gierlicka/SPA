using SpaBackend.Db;
using SpaBackend.Db.Entity;
using SpaBackend.Services.Abstract;

namespace SpaBackend.Services.Implementation;

public class ProductService : IProductService
{
    private readonly SpaDbContext _dbContext;

    public ProductService(SpaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<Product> GetProducts()
    {
        return _dbContext.Products;
    }
}