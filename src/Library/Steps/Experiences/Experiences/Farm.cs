using System.Collections.Generic;

 
/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es definir la experiencia Farm.
*/


namespace Library
{
    public class Farm : ICoinExperience
    {
        private AbstractReward reward;
        public Farm(int coinReward)
        {
            this.reward = SetCoinReward(coinReward);
        }

        public void Execute(int timesInStep, ref List<AbstractReward> rewards)
        {
            rewards.Add(reward);
        }

        public Coin SetCoinReward(int value)
        {
            if (value > 0)
            {
                return new Coin(value);
            }
            return new Coin(0);
        }
    }
}