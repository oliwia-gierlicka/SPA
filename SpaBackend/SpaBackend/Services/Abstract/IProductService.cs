using SpaBackend.Db.Entity;
using SpaBackend.Models;

namespace SpaBackend.Services.Abstract;

public interface IProductService
{
    IEnumerable<Product> GetProducts();
    IEnumerable<ProductDetails> GetProductDetails();
}