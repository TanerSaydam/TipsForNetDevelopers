namespace DataAccess.Models;

public class PerformanceLog
{
    public int Id { get; set; }
    public string MethodName { get; set; }
    public DateTime StartingDate { get; set; }
    public DateTime EndingDate { get; set;}
    public int TransactionTimeInSecond { get; set; }
    public int TransactionTimeInMiliseconds { get; set; }
}
