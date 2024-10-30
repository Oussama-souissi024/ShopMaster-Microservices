using ShopMaster.Services.ShoppingCardAPI.Models.Dto;

namespace ShopMaster.Services.ShoppingCardAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
