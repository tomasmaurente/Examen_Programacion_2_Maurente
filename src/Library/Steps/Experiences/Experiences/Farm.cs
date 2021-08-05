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

        public void Execute(ref int timesInStep, ref List<AbstractReward> rewards)
        {
            rewards.Add(reward);
        }

        public AbstractReward SetCoinReward(int value)
        {
            return new Coin(value);
        }
    }
}