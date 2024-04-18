using SpaBackend.Db.Entity;

namespace SpaBackend.Services.Abstract;

public interface IProductService
{
    IEnumerable<Product> GetProducts();
}