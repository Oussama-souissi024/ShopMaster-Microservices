using Microsoft.AspNetCore.Identity;

namespace ShopMaster.Services.AthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
