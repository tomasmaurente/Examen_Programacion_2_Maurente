using System.Collections.Generic;

namespace Library
{
    public class ThermalWaters : IPointExperience
    {
        private AbstractReward reward;
        public ThermalWaters(int pointReward)
        {
            this.reward = SetPointReward(pointReward);
        }

        public void Execute(int timesInStep, ref List<AbstractReward> rewards)
        {
            rewards.Add(reward);
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