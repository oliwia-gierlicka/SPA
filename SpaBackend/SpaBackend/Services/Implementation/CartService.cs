using Microsoft.EntityFrameworkCore;
using SpaBackend.Db;
using SpaBackend.Db.Entity;
using SpaBackend.Models;
using SpaBackend.Services.Abstract;

namespace SpaBackend.Services.Implementation;

public class CartService : ICartService
{
    private readonly SpaDbContext _dbContext;

    public CartService(SpaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<CartItem> GetCartItems(int userId)
    {
        return _dbContext.CartItems.Where(x => x.UserId == userId);
    }

    public async Task AddToCartAsync(CartAddForm form, int userId)
    {
        _dbContext.CartItems.Add(new CartItem
        {
            UserId = userId,
            ProductId = form.ProductId,
            Quantity = form.Quantity,
            Price = form.Price
        });
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteFromCartAsync(int productId, int userId)
    {
        var item = await _dbContext.CartItems.FirstOrDefaultAsync(x => x.ProductId == productId);

        if (item is not null && item.UserId == userId)
        {
            _dbContext.CartItems.Remove(item);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task Buy(int userId)
    {
        var id = Guid.NewGuid();
        var products = _dbContext.CartItems.Where(x => x.UserId == userId);
        
        _dbContext.CartItems.RemoveRange(products);

        foreach (var cartItem in products)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == cartItem.ProductId);

            _dbContext.Transactions.Add(new Transaction
            {
                TransactionId = id,
                ProductId = cartItem.ProductId,
                Price = cartItem.Price,
                Quantity = cartItem.Quantity,
                UserId = cartItem.UserId
            });

            product.Amount -= cartItem.Quantity;
            _dbContext.Products.Update(product);

        }
        
        _dbContext.CartItems.RemoveRange(products);
        await _dbContext.SaveChangesAsync();
    }
}