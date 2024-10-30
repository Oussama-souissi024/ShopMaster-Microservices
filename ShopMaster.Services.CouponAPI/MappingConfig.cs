using AutoMapper;
using ShopMaster.Services.CouponAPI.Models;
using ShopMaster.Services.CouponAPI.Models.Dto;

namespace ShopMaster.Services.CouponAPI
{
	public class MappingConfig
	{
		public static MapperConfiguration RegisterMaps()
		{
			var mappingConfig = new MapperConfiguration(config =>
			{
				config.CreateMap<CouponDto, Coupon>();
				config.CreateMap<Coupon, CouponDto>();
			});
			return mappingConfig;
		}
	}
}
