
/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es definir un Reward.
    OCP: No se aplica.
*/

namespace Library
{
    public class Point : AbstractReward
    {
        public Point(int value)
        : base(value)
        {
        }
    }
}