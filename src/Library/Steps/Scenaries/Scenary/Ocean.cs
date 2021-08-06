using System.Collections.Generic;

namespace Library
{
    public class Ocean : IScenary
    {
        private AbstractReward reward;

        public Ocean()
        {
        }

        public AbstractReward PointsOfVisit(int timesInStep)
        {
            int pointsToAdd = 1;
            for (int times = 1; times < timesInStep; times++)
            {
                pointsToAdd += 2;
            }
            return new Point(pointsToAdd);
        }
        public void Execute(ref int timesInStep, ref List<AbstractReward> rewards)
        {
            this.reward = this.PointsOfVisit(timesInStep);
            rewards.Add(this.reward);
        }
    }
}