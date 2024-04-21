using System.Collections;
using SpaBackend.Db;
using SpaBackend.Db.Entity;
using SpaBackend.Models;
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

    public IEnumerable<ProductDetails> GetProductDetails()
    {
        return _dbContext.Products.Select(x => new ProductDetails
        {
            Id = x.Id,
            Name = x.Name,
            Description = x.Description,
            Price = x.Price,
            Amount = x.Amount
        });
    }
}