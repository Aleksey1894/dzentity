using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace panda99.Models
{
    public class Category
    {
        [Key]       
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("categoriename")]
        public string? CategorieName { get; set; }

        public ICollection<ProductCategory> ProductCategories{ get; set; }
    }
}
