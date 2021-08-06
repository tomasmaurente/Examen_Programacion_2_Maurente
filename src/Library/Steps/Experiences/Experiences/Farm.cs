using System.Collections.Generic;

namespace Library
{
    public class Farm : ICoinExperience
    {
        private AbstractReward reward;
        public Farm(int coinReward)
        {
            this.reward = SetCoinReward(coinReward);
        }

        public void Execute(int timesInStep, ref List<AbstractReward> rewards)
        {
            rewards.Add(reward);
        }

        public AbstractReward SetCoinReward(int value)
        {
            if (value > 0)
            {
                return new Coin(value);
            }
            return new Coin(0);
        }
    }
}