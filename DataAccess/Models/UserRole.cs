using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models;

public class UserRole
{
    public int Id { get; set; }

    [ForeignKey("Role")]
    public int RoleId { get; set; }
    public virtual Role Role { get; set; }

    [ForeignKey("User")]
    public int UserId { get; set; }
    public virtual User User { get; set; }
}
