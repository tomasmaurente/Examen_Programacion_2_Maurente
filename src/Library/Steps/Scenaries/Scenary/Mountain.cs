using System.Collections.Generic;

/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es definir el escenario Mountain.
    
    OCP: No se aplica.
    
    LSP: Esta interfaz cumple con LSP ya que en repetidas ocaciones los objetos de esta clase estan en listas que contienen un supertipo.

    ISP: No se aplica.

    DIP: Esta clase cumple con DIP ya que solo depende de AbstractReward, una abstración.
    
    EXPERT: Esta clase es la experta en conocer la recompensa del Step.
*/

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

        public Point PointsOfVisit(int timesInStep)
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