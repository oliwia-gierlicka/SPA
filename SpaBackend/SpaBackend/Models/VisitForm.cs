namespace SpaBackend.Models;

public class VisitForm
{
    public string ServiceName { get; set; }
    public DateTime Date { get; set; }
    public int Length { get; set; }
    public int EmployeeId { get; set; }
}