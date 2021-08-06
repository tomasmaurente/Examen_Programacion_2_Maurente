
/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es definir AbstractReward, esta abstraccion debe ser heredada por 
    un el nuevo reward en caso de querer crear uno.
    
    OCP: No se aplica.

    LSP: Esta clase cumple con LSP ya que en varias ocaciones en el codigo el tipo AbstractReward es utilizado para englovar todos los rewards. 
    Esto es util ya que si se quisiera añadir un nuevo reward, tal como "Bonus", se deberia crear una clase Bonus y heredar esta, e implementarla 
    en el step que fuese a devolver este reward.

    ISP: No se aplica.
*/

namespace Library
{
    public abstract class AbstractReward
    {
        public int Value { get; set; }
        public AbstractReward(int value)
        {
            this.Value = value;
        }
    }
}