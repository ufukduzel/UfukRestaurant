using Ufuk.Web.Models;

namespace Ufuk.Web.Services.IServices
{
    //48th step.
    public interface IProductService : IBaseService // 68th step.
    {
        //53rd step.
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductByIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDto productDto);
        Task<T> UpdateProductAsync<T>(ProductDto productDto);
        Task<T> DeleteProductAsync<T>(int id);
    }
}
