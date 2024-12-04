
using ShopMaster.Services.OrderAPI.Models.Dto;

namespace ShopMaster.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
