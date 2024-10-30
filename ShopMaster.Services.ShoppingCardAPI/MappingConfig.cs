using AutoMapper;
using ShopMaster.Services.ShoppingCardAPI.Models;
using ShopMaster.Services.ShoppingCardAPI.Models.Dto;

namespace ShopMaster.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartHeaderDto, CartHeader>().ReverseMap();
                config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
