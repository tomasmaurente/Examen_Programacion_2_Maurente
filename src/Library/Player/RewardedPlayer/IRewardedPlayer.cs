using System.Collections.Generic;

/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es declarar las operacoines necesarias para que un objeto sea del tipo IRewardedPlayer. 
            Esta interfaz se debe implementar por todos aquellos abjetos que quieran almacenar Rewards.

    OCP: Esta clase es ejemplo de como implementar una funcionalidad en AbstractPlayer haciendo cambios minimos en ella. AbstractPlayer al implementar esta
    interfaz solo debe agregar las operaciones dictadas, asi solo solo estamos extendiendo el codigo y no modificandolo.
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