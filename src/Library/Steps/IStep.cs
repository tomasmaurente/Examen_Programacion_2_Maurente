using System.Collections.Generic;
 
/*
    SRP: Esta interfaz cumple con SRP ya que su unica responsabilidad es definir las operaciones necesarias que debe tener Step.
    
    OCP: No se aplica.

    LSP: Esta interfaz cumple con LSP ya que en varias oaciones en el codigo se utiliza el tipo que define para englovar todos los subtipos que la suceden.

    ISP: No se aplica.

    DIP: Esta clase cumple con DIP ya que no tiene dependencias.
    
    EXPERT: No se aplica.

    POLYMORPHISM: No se aplica.

    CREATOR: No se aplica. 
*/

namespace Library
{
    public interface IStep
    {
        public void Execute(int timesInStep, ref List<AbstractReward> rewards);
    }
}