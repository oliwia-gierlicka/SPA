namespace SpaBackend.Db.Entity;

public class Transaction
{
    public int Id { get; set; }
    public Guid TransactionId { get; set; }
    public int ProductId { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public int UserId { get; set; }
}