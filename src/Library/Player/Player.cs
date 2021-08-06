
/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es definir un Player.

    OCP: No se aplica.
*/

namespace Library
{
    public class Player : AbstractPlayer
    {
        public Player(string name)
        : base(name)
        {
        }
    }
}
