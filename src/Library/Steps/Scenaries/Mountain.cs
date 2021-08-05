using System.Collections.Generic;

namespace Library
{
    public class Mountain : IScenary
    {
        private AbstractReward reward;

        public Mountain()
        {
        }

        public AbstractReward PointsOfVisit(int timesInStep)
        {
            int pointsToAdd = 0;
            while (timesInStep != pointsToAdd)
            {
                pointsToAdd += 1;
            }
            return new Coin(pointsToAdd);
        }

        public void Execute(ref int timesInStep, ref List<AbstractReward> rewards)
        {
            this.reward = this.PointsOfVisit(timesInStep);
            rewards.Add(this.reward);
        }
    }
}