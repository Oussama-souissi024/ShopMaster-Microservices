using AutoMapper;
using ShopMaster.Services.ProductAPI.Models;
using ShopMaster.Services.ProductAPI.Models.Dto;

namespace ShopMaster.Services.ProductAPI
{
    public class MappingConfig
    {
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
