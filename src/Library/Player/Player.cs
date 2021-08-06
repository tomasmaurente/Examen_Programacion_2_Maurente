
/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es definir un Player.

    OCP: No se aplica.

    LSP: Esta clase cumple con LSP ya que en repetidas ocaciones se lo almacena como AbstracPlayer.
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
