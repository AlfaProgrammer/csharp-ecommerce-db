using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Customers")]
public class Customer
{
    [Key]
    public int CustomerId { get; set; }
    [Required]
    public string Name { get; set; }
    public string Surname { get; set; }
    [Required]
    [Column("customer_email")]
    public string Email { get; set; }

    public List<Order> Orders { get; set; }

}
