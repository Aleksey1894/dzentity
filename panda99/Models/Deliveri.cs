using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace panda99.Models
{
    public class Deliveri
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } = new Order();

        [Column("orderid")]
        public int OrderId { get; set; }

        [Column("description")]
        public string Description { get; set; }


    }
}
