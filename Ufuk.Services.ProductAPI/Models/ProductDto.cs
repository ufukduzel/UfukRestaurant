using System.ComponentModel.DataAnnotations;

namespace Ufuk.Services.ProductAPI.Models.Dtos //13th step.
{
    //11th step.
    public class ProductDto
    {
        //12th step.
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
    }
}
