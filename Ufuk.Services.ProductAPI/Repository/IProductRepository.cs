using Ufuk.Services.ProductAPI.Models.Dtos;

namespace Ufuk.Services.ProductAPI.Repository
{
    //10th step.
    public interface IProductRepository
    {
        //16th step.
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);
    }
}
