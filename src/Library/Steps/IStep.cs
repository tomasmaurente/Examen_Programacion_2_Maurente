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

    LEY DE DEMETER: No se aplica.

    COHESION: La cohesion de esta clase es ALTA ya que solo existe para definir las operaciones que un Step debe tener.

    ACOPLAMIENTO: Esta clase genera BAJO acoplamiento ya que hace que la dependencia de la clase que interactue pueda ser substituida por cualquier
    objeto que implemente esta interfaz, tales como los steps.
*/

namespace Library
{
    public interface IStep
    {
        public void Execute(int timesInStep, ref List<AbstractReward> rewards);
    }
}