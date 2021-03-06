
/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es definir un Reward.

    OCP: No se aplica.
    
    LSP: Esta clase cumple con LSP ya que en varias ocaciones es contenido en listas bajo el tipo de AbstractReward.

    ISP: No se aplica.

    DIP: No se aplica.

    EXPERT: Esta clase es la Expert en saber el valor del punto.

    POLYMORPHISM: No se aplica.

    CREATOR: No se aplica. 

    LEY DE DEMETER: No se aplica.

    COHESION: no se aplica.
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