
/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es definir AbstractReward, esta abstraccion debe ser heredada por 
    un el nuevo reward en caso de querer crear uno.
    
    OCP: No se aplica.
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