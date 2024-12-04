using ShopMaster.Services.RewardAPI.Message;

namespace ShopMaster.Services.RewardAPI.Services
{
    public interface IRewardService
    {
        Task UpdateRewards(RewardsMessage rewardsMessage);
    }
}
