namespace SpaBackend.Db.Entity;

public class User
{
    public int Id { get; set; }
    public string Role { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? PostCode { get; set; }
    public string? HouseNumber { get; set; }
    public string? ApartmentNumber { get; set; }
    public string Email { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
}