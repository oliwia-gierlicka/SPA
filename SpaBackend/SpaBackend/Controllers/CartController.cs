using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpaBackend.Models;
using SpaBackend.Services.Abstract;

namespace SpaBackend.Controllers;

[ApiController]
[Authorize]
[Route("[controller]")]
public class CartController:ControllerBase
{
    private readonly ICartService _cartService;
    private readonly IUserProvider _userProvider;

    public CartController(ICartService cartService, IUserProvider userProvider)
    {
        _cartService = cartService;
        _userProvider = userProvider;
    }

    [HttpGet]
    public ActionResult GetCart()
    {
        var userId = _userProvider.GetUserId();
        return Ok(_cartService.GetCartItems(userId));
    }

    [HttpPost]
    public async Task<ActionResult> AddToCart(CartAddForm form)
    {
        var userId = _userProvider.GetUserId();
        await _cartService.AddToCartAsync(form, userId);
        return Ok();
    }

    [HttpDelete("{productId}")]
    public async Task<ActionResult> Delete(int productId)
    {
        var userId = _userProvider.GetUserId();
        await _cartService.DeleteFromCartAsync(productId, userId);
        return Ok();
    }

    [HttpPost("buy")]
    public async Task<ActionResult> Buy()
    {
        var userId = _userProvider.GetUserId();
        await _cartService.Buy(userId);
        return Ok();
    }
}