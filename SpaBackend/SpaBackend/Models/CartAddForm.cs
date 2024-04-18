namespace SpaBackend.Models;

public class CartAddForm
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}