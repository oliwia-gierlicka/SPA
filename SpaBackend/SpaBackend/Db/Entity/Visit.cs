namespace SpaBackend.Db.Entity;

public class Visit
{
    public int Id { get; set; }
    public string ServiceName { get; set; }
    public DateTime Date { get; set; }
    public int Length { get; set; }
    public int EmployeeId { get; set; }
    public int UserId { get; set; }
    public bool IsDone { get; set; }
}