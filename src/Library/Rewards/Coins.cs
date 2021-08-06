
/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es definir un Reward.
    
    OCP: No se aplica.

    LSP: Esta clase cumple con LSP ya que en varias ocaciones es contenido en listas bajo el tipo de AbstractReward.

    ISP: No se aplica.

    DIP: No se aplica.
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