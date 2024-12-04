using ShopMaster.Services.EmailAPI.Message;
using ShopMaster.Services.EmailAPI.Models.Dto;

namespace ShopMaster.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
