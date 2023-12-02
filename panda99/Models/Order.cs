using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace panda99.Models
{
    public class Order
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("orderdate")]
        public DateTime OrderDate { get; set; }

        [Required]
        [Column("quantity")]
        public int Quantity { get; set; }

        [Required]
        [Column("totalprice")]
        public decimal TotalPrice { get; set; }
       
        public ICollection<Deliveri> Deliveries { get; set; }
    }
}
