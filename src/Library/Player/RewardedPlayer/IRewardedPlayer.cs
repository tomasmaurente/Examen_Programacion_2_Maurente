using System.Collections.Generic;

/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es declarar las operacoines necesarias para que un objeto sea del tipo IRewardedPlayer. 
            Esta interfaz se debe implementar por todos aquellos abjetos que quieran almacenar Rewards.

*/

namespace Library
{
    public interface IRewardedPlayer
    {
        RewardedPlayer RewardedPlayer {get;}
        public void AddReward(List<AbstractReward> incomingReward);
        public AbstractReward TotalPoints();
        public AbstractReward TotalCoins();
    }
}