using ShopMaster.Web.Models;

namespace ShopMaster.Web.Service.IService
{
	public interface ICouponService
	{
		Task<ResponseDto?> GetCouponAsync(string couponCode);
		Task<ResponseDto?> GetAllCouponsAsync();
		Task<ResponseDto?> GetCouponByIdAsync(int id);
		Task<ResponseDto?> CreateCouponsAsync(CouponDto couponDto);
		Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto);
		Task<ResponseDto?> DeleteCouponsAsync(int id);
	}
}
