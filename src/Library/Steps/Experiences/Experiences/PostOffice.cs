using System.Collections.Generic;
 
/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es definir la experiencia PostOffice.
    
    OCP: No se aplica.
    
    LSP: Esta interfaz cumple con LSP ya que en repetidas ocaciones los objetos de esta clase estan en listas que contienen un supertipo.

    ISP: No se aplica.
*/
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

        public Coin SetCoinReward(int value)
        {
            if (value > 0)
            {
                return new Coin(value);
            }
            return new Coin(0);
        }

        public Point SetPointReward(int value)
        {
            if (value > 0)
            {
                return new Point(value);
            }
            return new Point(0);
        }
    }
}