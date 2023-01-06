using System.ComponentModel.DataAnnotations;

namespace Ufuk.Services.ProductAPI.Models
{
    public class Product
    {
        //7th step.
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1, 1000)]
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }

    }
}
