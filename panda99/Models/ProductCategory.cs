using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace panda99.Models
{
    public class ProductCategory
    {
       
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category? Category { get; set; }
        [Column("category_id")]
        public int CategoryId { get; set; }


        [ForeignKey(nameof(ProductId))]
        public Product? Product { get; set; } = new Product();
        [Column("product_id")]
        public int ProductId { get; set; }

    }



}

