using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopMaster.Web.Models;
using ShopMaster.Web.Service;
using ShopMaster.Web.Service.IService;

namespace ShopMaster.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> ProductIndex()
        {
            List<ProductDto>? productList = new();
            ResponseDto? response = await _productService.GetAllProductsAsync();

            if (response != null && response.IsSuccess)
            {
                productList = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
                TempData["success"] = "Products loaded successfully";
            }
            else
            {
                TempData["error"] = response?.Message;
            }

            return View(productList);
        }

		public async Task<IActionResult> ProductCreate()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> ProductCreate(ProductDto model)
		{
			if (ModelState.IsValid)
			{
				ResponseDto? response = await _productService.CreateProductsAsync(model);

				if (response != null && response.IsSuccess)
				{
					TempData["success"] = "Product created successfully";
					return RedirectToAction(nameof(ProductIndex));
				}
				else
				{
					TempData["error"] = response?.Message;
				}
			}
			return View(model);
		}

		public async Task<IActionResult> ProductDelete(int productId)
		{
			ResponseDto? response = await _productService.GetProductByIdAsync(productId);

			if (response != null && response.IsSuccess)
			{
				ProductDto? model = JsonConvert.DeserializeObject<ProductDto>(Convert.ToString(response.Result));
				return View(model);
			}
			else
			{
				TempData["error"] = response?.Message;
			}
			return RedirectToAction("ProductIndex");
		}

		[HttpPost]
		public async Task<IActionResult> ProductDelete(ProductDto productDto)
		{
			ResponseDto? response = await _productService.DeleteProductsAsync(productDto.ProductId);

			if (response != null && response.IsSuccess)
			{
				TempData["success"] = "Product deleted successfully";
				return RedirectToAction(nameof(ProductIndex));
			}
			else
			{
				TempData["error"] = response?.Message;
			}
			return View(productDto);
		}

		public async Task<IActionResult> ProductEdit(int productId)
		{
			ResponseDto? response = await _productService.GetProductByIdAsync(productId);

			if (response != null && response.IsSuccess)
			{
				ProductDto? model = JsonConvert.DeserializeObject<ProductDto>(Convert.ToString(response.Result));
				return View(model);
			}
			else
			{
				TempData["error"] = response?.Message;
			}
			return RedirectToAction("ProductIndex");
		}

		[HttpPost]
		public async Task<IActionResult> ProductEdit(ProductDto productDto)
		{
			if (ModelState.IsValid)
			{
				ResponseDto? response = await _productService.UpdateProductsAsync(productDto);

				if (response != null && response.IsSuccess)
				{
					TempData["success"] = "Product updated successfully";
					return RedirectToAction(nameof(ProductIndex));
				}
				else
				{
					TempData["error"] = response?.Message;
				}
			}
			return View(productDto);
		}

	}
}
