using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace panda99.Models
{
    public class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? UserName { get; set; }

        [Required]            
        [Column("email")]
        public string? Email { get; set; }

    }
}
