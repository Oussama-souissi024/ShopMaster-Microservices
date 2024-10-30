using ShopMaster.Web.Models;

namespace ShopMaster.Web.Service.IService
{
	public interface IBaseService
	{
		Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true);
	}
}
