namespace SpaBackend.Models;

public class ServiceAvailabilityRequest
{
    public DateTime When { get; set; }
    public int EmployeeId { get; set; }
    public int ServiceId { get; set; }
}