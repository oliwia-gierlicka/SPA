namespace SpaBackend.Db.Entity;

public class Service
{
    public int Id { get; set; }
    public string Category { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public decimal Price { get; set; }
    public int Length { get; set; }
}