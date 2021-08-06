using System.Collections.Generic;

/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es definir el escenario Ocean.
*/

namespace Library
{
    public class Ocean : IScenary
    {
        private AbstractReward reward;
        private static Ocean instance;

        private Ocean()
        {
        }

        public static Ocean GetOcean()
        {
            if (instance == null)
            {
                instance = new Ocean();
            }
            return instance;
        }

        public Point PointsOfVisit(int timesInStep)
        {
            int pointsToAdd = 1;
            for (int times = 1; times < timesInStep; times++)
            {
                pointsToAdd += 2;
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