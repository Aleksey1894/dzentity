using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace panda99.Models
{
    public class Product
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("productname")]
        public string? ProductName { get; set; }

        [Required]
        [Column("price")]
        public decimal Price { get; set; }

        [MaxLength(500)]
        [Column("description")]
        public string? Description { get; set; }

       
        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
