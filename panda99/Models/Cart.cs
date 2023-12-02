using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace panda99.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(UserId))]
        public User? User { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }


        [ForeignKey(nameof(ProductId))]
        public Product? Product { get; set; } = new Product();
        [Column("product_id")]
        public int ProductId { get; set; }
        

        [Column("quantity")]
        public int Quantity { get; set; }
    }
}
