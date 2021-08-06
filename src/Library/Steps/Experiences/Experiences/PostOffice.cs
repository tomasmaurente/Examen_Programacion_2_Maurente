using System.Collections.Generic;

namespace Library
{
    public class PostOffice : ICoinExperience, IPointExperience
    {
        private List<AbstractReward> reward = new List<AbstractReward>();
        public PostOffice(int coinReward, int pointReward)
        {
            this.reward.Add(SetCoinReward(coinReward));
            this.reward.Add(SetPointReward(pointReward));
        }

        public void Execute(int timesInStep, ref List<AbstractReward> rewards)
        {
            foreach (AbstractReward internalReward in reward)
            {
                rewards.Add(internalReward);
            }
        }

        public AbstractReward SetCoinReward(int value)
        {
            if (value > 0)
            {
                return new Coin(value);
            }
            return new Coin(0);
        }

        public AbstractReward SetPointReward(int value)
        {
            if (value > 0)
            {
                return new Point(value);
            }
            return new Point(0);
        }
    }
}