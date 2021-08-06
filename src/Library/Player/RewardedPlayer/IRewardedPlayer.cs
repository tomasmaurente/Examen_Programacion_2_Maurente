using System.Collections.Generic;

namespace Library
{
    public interface IRewardedPlayer
    {
        RewardedPlayer RewardedPlayer {get;}
        public void AddReward(List<AbstractReward> incomingReward);
        public AbstractReward TotalPoints();
        public AbstractReward TotalCoins();
    }
}