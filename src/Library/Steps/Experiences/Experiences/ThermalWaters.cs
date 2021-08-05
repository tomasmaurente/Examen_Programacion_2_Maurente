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

        public void Execute(ref int timesInStep, ref List<AbstractReward> rewards)
        {
            rewards.Add(reward);
        }

        public AbstractReward SetPointReward(int value)
        {
            return new Point(value);
        }
    }
}