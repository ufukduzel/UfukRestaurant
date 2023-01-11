﻿using AutoMapper;
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

        public Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(int productId)
        {
            throw new NotImplementedException();
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