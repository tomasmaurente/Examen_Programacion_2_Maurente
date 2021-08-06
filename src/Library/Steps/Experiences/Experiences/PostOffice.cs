using System.Collections.Generic;

namespace Library
{
    public class PostOffice : ICoinExperience , IPointExperience
    {
        private List<AbstractReward> reward = new List<AbstractReward>();
        public PostOffice(int coinReward, int pointReward)
        {
            this.reward.Add(SetCoinReward(coinReward));
            this.reward.Add(SetPointReward(pointReward));
        }

        public void Execute(ref int timesInStep, ref List<AbstractReward> rewards)
        {
            foreach (AbstractReward internalReward in reward)
            {
                rewards.Add(internalReward);
            }
        }

        public AbstractReward SetCoinReward(int value)
        {
            return new Coin(value);
        }

        public AbstractReward SetPointReward(int value)
        {
            return new Point(value);
        }
    }
}