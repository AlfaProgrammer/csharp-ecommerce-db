using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Products")]
public class Product
{
    [Key]
    public int ProductID { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }

    [Column("Price", TypeName = "int")]
    public double Price { get; set; }

    public List<Order> OrdersContainingProduct { get; set; }
}
