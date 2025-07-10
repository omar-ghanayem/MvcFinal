using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }
        [MinLength(3)]
        [MaxLength(100)]

        public string Description { get; set; }
        [Range(1, int.MaxValue)]
        public decimal Price {  get; set; }
        [Range (1, 1000)]
        public int Quantity { get; set; }
        //[RegularExpression("")]
        public string? Image {  get; set; }
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category? Category { get; set; }
    }
}
