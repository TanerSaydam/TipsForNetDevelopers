namespace DataAccess.Models;

public class HealthCheckResult
{
    public int Id { get; set; }
    public DateTime Timestamp { get; set; }
    public string Status { get; set; }  
    public string Description { get; set; }
}
