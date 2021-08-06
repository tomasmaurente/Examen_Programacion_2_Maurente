using System.Collections.Generic;
 
/*
    SRP: Esta interfaz cumple con SRP ya que su unica responsabilidad es definir las operaciones necesarias que debe tener Step.
    
    OCP: No se aplica.

    LSP: Esta interfaz cumple con LSP ya que en varias oaciones en el codigo se utiliza el tipo que define para englovar todos los subtipos que la suceden.
*/

namespace Library
{
    public interface IStep
    {
        public void Execute(int timesInStep, ref List<AbstractReward> rewards);
    }
}