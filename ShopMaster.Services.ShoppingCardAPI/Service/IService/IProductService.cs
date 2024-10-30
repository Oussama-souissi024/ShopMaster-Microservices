using ShopMaster.Services.ShoppingCardAPI.Models.Dto;

namespace ShopMaster.Services.ShoppingCardAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
