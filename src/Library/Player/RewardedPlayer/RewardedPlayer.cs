using System.Collections.Generic;

namespace Library
{
    public class AbstractRewardedPlayer
    {
        public AbstractRewardedPlayer(Dictionary<AbstractReward,int> availableRewards)
        {
            this.rewards = availableRewards;
        }
        private Dictionary<AbstractReward,int> rewards;
        public IReadOnlyDictionary<AbstractReward,int> Rewards
        {
            get
            {
                return this.rewards;
            }
        }

        public void AddReward(List<AbstractReward> incommeReward)
        {
            foreach(AbstractReward reward in incommeReward)
            {
                try
                {
                    rewards[reward] += reward.GetValue();
                }
                catch (KeyNotFoundException)
                {
                    continue;
                }
            }
        }
    }
}
