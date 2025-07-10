using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace WebApplication1.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }
        [MinLength(3)]
        [MaxLength(100)]
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();


    }
}
