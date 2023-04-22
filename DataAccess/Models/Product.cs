using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models;

public class Product
{
    public int Id { get; set; }    
    public string Name { get; set; }

    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
}
