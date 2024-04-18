using SpaBackend.Db.Entity;
using SpaBackend.Models;

namespace SpaBackend.Services.Abstract;

public interface ICartService
{
    IEnumerable<CartItem> GetCartItems(int userId);
    Task AddToCartAsync(CartAddForm form, int userId);
    Task DeleteFromCartAsync(int productId, int userId);
    Task Buy(int userId);
}