using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Orders")]
public class Order
{
    [Key]
    public int OrderId { get; set; }
    public string Data { get; set; }
    
    [Column("Status", TypeName = "bit")]
    public bool Status { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    public List<Product> OrderedProducts { get; set; }
}
