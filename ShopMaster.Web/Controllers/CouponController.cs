using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopMaster.Web.Models;
using ShopMaster.Web.Service.IService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopMaster.Web.Controllers
{
    public class CouponController : Controller
    {
        private readonly ICouponService _couponService;
        public CouponController(ICouponService couponService)
        {
            _couponService = couponService;
        }

        // Displays all coupons
        public async Task<IActionResult> CouponIndex()
        {
            List<CouponDto>? couponList = new();
            ResponseDto? response = await _couponService.GetAllCouponsAsync();

            if (response != null && response.IsSuccess)
            {
                couponList = JsonConvert.DeserializeObject<List<CouponDto>>(Convert.ToString(response.Result));
                TempData["success"] = "Coupons loaded successfully";
            }
            else
            {
                TempData["error"] = response?.Message;
            }

            return View(couponList);
        }

        // GET: Displays the form to create a new coupon
        public async Task<IActionResult> CouponCreate()
        {
            return View();
        }

        // POST: Creates a new coupon
        [HttpPost]
        public async Task<IActionResult> CouponCreate(CouponDto model)
        {
            if (ModelState.IsValid)
            {
                ResponseDto? response = await _couponService.CreateCouponsAsync(model);

                if (response != null && response.IsSuccess)
                {
                    TempData["success"] = "Coupon created successfully";
                    return RedirectToAction(nameof(CouponIndex));
                }
                else
                {
                    TempData["error"] = response?.Message;
                }
            }
            return View(model);
        }

        // GET: Displays the coupon details for confirmation before deletion
        public async Task<IActionResult> CouponDelete(int couponId)
        {
            ResponseDto? response = await _couponService.GetCouponByIdAsync(couponId);

            if (response != null && response.IsSuccess)
            {
                CouponDto model = JsonConvert.DeserializeObject<CouponDto>(Convert.ToString(response.Result));
                return View(model);
            }
            else
            {
                TempData["error"] = response?.Message;
            }
			return RedirectToAction("CouponIndex");
		}

        // POST: Deletes the coupon
        [HttpPost]
        public async Task<IActionResult> CouponDelete(CouponDto couponDto)
        {
            ResponseDto? response = await _couponService.DeleteCouponsAsync(couponDto.CouponId);

            if (response != null && response.IsSuccess)
            {
                TempData["success"] = "Coupon deleted successfully";
                return RedirectToAction(nameof(CouponIndex));
            }
            else
            {
                TempData["error"] = response?.Message;
            }

            return View(couponDto);
        }
    }
}
