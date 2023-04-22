namespace DataAccess.Models;

public class ErrorLog
{
    public int Id { get; set; }
    public string Trace { get; set; }
    public DateTime CreatedDate {  get; set; }
    public string MethodName { get; set; }
}
