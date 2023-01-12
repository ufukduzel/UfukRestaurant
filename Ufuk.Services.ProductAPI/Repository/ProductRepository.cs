using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Ufuk.Services.ProductAPI.DbContexts;
using Ufuk.Services.ProductAPI.Models.Dto;
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

        //24th step.
        public async Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            Product product = _mapper.Map<ProductDto, Product>(productDto);
            if (product.ProductId > 0)
            {
                _db.Products.Update(product);
            }
            else
            {
                _db.Products.Add(product);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Product, ProductDto>(product);
        }

        //23th step.
        public async Task<bool> DeleteProduct(int productId)
        {
            try
            {
                Product product = await _db.Products.FirstOrDefaultAsync(u => u.ProductId == productId);
                if (product == null)
                {
                    return false;
                }
                _db.Products.Remove(product);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //22th step.
        public async Task<ProductDto> GetProductById(int productId)
        {
            Product product = await _db.Products.Where(x => x.ProductId == productId).FirstOrDefaultAsync();
            return _mapper.Map<ProductDto>(product);
        }
        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            //IEnumerable<Product> productList = await _db.Products.ToListAsync();
            List<Product> productList = await _db.Products.ToListAsync();
            return _mapper.Map<List<ProductDto>>(productList);
        }
    }
}
