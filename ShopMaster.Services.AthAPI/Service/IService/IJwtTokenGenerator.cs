using ShopMaster.Services.AthAPI.Models;

namespace ShopMaster.Services.AthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}
