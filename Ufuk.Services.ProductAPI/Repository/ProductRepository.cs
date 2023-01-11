using AutoMapper;
using Ufuk.Services.ProductAPI.DbContexts;
using Ufuk.Services.ProductAPI.Models.Dtos;

namespace Ufuk.Services.ProductAPI.Repository
{
    //20th step.
    public class ProductRepository : IProductRepository
    {
        //21th step.
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;
        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
