using AutoMapper;
using Ufuk.Services.ProductAPI.Models.Dto;
using Ufuk.Services.ProductAPI.Models.Dtos;

namespace Ufuk.Services.ProductAPI
{
    //17th step.
    public class MappingConfig
    {
        //18th step.
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }
    }
}
