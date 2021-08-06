
/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es definir un Reward.
*/

namespace Library
{
    public class Coin : AbstractReward
    {
        public Coin(int value)
        : base(value)
        {
        }
    }
}