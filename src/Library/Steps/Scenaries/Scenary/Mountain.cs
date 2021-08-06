using System.Collections.Generic;

namespace Library
{
    public class Mountain : IScenary
    {
        private AbstractReward reward;
        private static Mountain instance;

        private Mountain()
        {
        }

        public static IStep GetMountain()
        {
            if (instance == null)
            {
                instance = new Mountain();
            }
            return instance;
        }

        public AbstractReward PointsOfVisit(int timesInStep)
        {
            int pointsToAdd = 1;
            for (int times = 1; times < timesInStep; times++)
            {
                pointsToAdd += 1;
            }
            return new Point(pointsToAdd);
        }

        public void Execute(int timesInStep, ref List<AbstractReward> rewards)
        {
            this.reward = this.PointsOfVisit(timesInStep);
            rewards.Add(this.reward);
        }
    }
}