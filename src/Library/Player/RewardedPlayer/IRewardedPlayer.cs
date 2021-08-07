using System.Collections.Generic;

/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es declarar las operacoines necesarias para que un objeto sea del tipo IRewardedPlayer. 
            Esta interfaz se debe implementar por todos aquellos abjetos que quieran almacenar Rewards.

    OCP: Esta clase es ejemplo de como implementar una funcionalidad en AbstractPlayer haciendo cambios minimos en ella. AbstractPlayer al implementar esta
    interfaz solo debe agregar las operaciones dictadas, asi solo solo estamos extendiendo el codigo y no modificandolo.
    
    LSP: No se aplica.

    ISP: Esta interfaz cumple con ISP ya que todas las operaciones que define esta interfaz son utilizadas en su totalidad por los objetos que la utilizan
    o implementan.

    DIP: Esta interfaz cumple con DIP. Esta creada para que el objeto compuesto que requiera utilizar las operaciones que define esta interfaz, dependa
    de la interfaz y no del objeto que la implemente.

    EXPERT: No se aplica.

    POLYMORPHISM: No se aplica.

    CREATOR: No se aplica. 

    LEY DE DEMETER: No se aplica.
*/

namespace Library
{
    public interface IRewardedPlayer
    {
        public void AddReward(List<AbstractReward> incomingReward);
        public AbstractReward TotalPoints();
        public AbstractReward TotalCoins();
    }
}