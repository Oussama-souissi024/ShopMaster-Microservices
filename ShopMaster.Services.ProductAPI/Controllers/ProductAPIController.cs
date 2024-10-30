using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopMaster.Services.ProductAPI.Data;
using ShopMaster.Services.ProductAPI.Models;
using ShopMaster.Services.ProductAPI.Models.Dto;


namespace ShopMaster.Services.CouponAPI.Controllers
{
	[Route("api/product")]
	[ApiController]
	[Authorize]
	public class ProductAPIController : ControllerBase
	{
		private readonly AppDbContext _db;
		private ProductAPI.Models.Dto.ResponseDto _response;
		private IMapper _mapper;

		public ProductAPIController(AppDbContext db, IMapper mapper)
		{
			_db = db;
			_mapper = mapper;
			_response = new ResponseDto();
		}

		[HttpGet]
		public ResponseDto Get()
		{
			try
			{
				IEnumerable<Product> objList = _db.Products.ToList();
				_response.Result = _mapper.Map<IEnumerable<ProductDto>>(objList);
			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response;
		}

		[HttpGet]
		[Route("{id:int}")]
        [Authorize]
        public ResponseDto Get(int id)
		{
			try
			{
                Product obj = _db.Products.First(u => u.ProductId == id);
				_response.Result = _mapper.Map<ProductDto>(obj);
			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response;
		}


		//[HttpPost]
		//[Authorize(Roles = "ADMIN")]
		//public ResponseDto Post([FromBody] CouponDto couponDto)
		//{
		//	try
		//	{
		//		Coupon obj = _mapper.Map<Coupon>(couponDto);
		//		_db.Coupons.Add(obj);
		//		_db.SaveChanges();



		//		var options = new Stripe.CouponCreateOptions
		//		{
		//			AmountOff = (long)(couponDto.DiscountAmount * 100),
		//			Name = couponDto.CouponCode,
		//			Currency = "usd",
		//			Id = couponDto.CouponCode,
		//		};
		//		var service = new Stripe.CouponService();
		//		service.Create(options);


		//		_response.Result = _mapper.Map<CouponDto>(obj);
		//	}
		//	catch (Exception ex)
		//	{
		//		_response.IsSuccess = false;
		//		_response.Message = ex.Message;
		//	}
		//	return _response;
		//}

		[HttpPost]
		[Authorize(Roles = "ADMIN")]
		public ResponseDto Post ([FromBody] ProductDto productDto)
		{
			try
			{
                Product obj = _mapper.Map<Product>(productDto);
                _db.Products.Add(obj);
                _db.SaveChanges();
                _response.Result = _mapper.Map<ProductDto>(obj);
            }
			catch(Exception ex) 
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response;
		}

		[HttpPut]
		[Authorize(Roles = "ADMIN")]
		public ResponseDto Put([FromBody] ProductDto productDto)
		{
			try
			{
                Product obj = _mapper.Map<Product>(productDto);
				_db.Products.Update(obj);
				_db.SaveChanges();

				_response.Result = _mapper.Map<ProductDto>(obj);
			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response;
		}

		//[HttpDelete]
		//[Route("{id:int}")]
		//[Authorize(Roles = "ADMIN")]
		//public ResponseDto Delete(int id)
		//{
		//	try
		//	{
		//		Coupon obj = _db.Coupons.First(u => u.CouponId == id);
		//		_db.Coupons.Remove(obj);
		//		_db.SaveChanges();


		//		var service = new Stripe.CouponService();
		//		service.Delete(obj.CouponCode);


		//	}
		//	catch (Exception ex)
		//	{
		//		_response.IsSuccess = false;
		//		_response.Message = ex.Message;
		//	}
		//	return _response;
		//}
		[HttpDelete]
        [Route("{id:int}")]
        public ResponseDto Delete  (int id)
        {
            try
			{
                Product obj = _db.Products.FirstOrDefault(c => c.ProductId == id);
                _db.Products.Remove(obj);
                _db.SaveChanges();
				_response.IsSuccess = true;
				_response.Message = "Coupon Deleted Successfully";
            }
			catch(Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response;

		}
	}
}
