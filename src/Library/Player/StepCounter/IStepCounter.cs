
/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es declarar las operacoines necesarias para que un objeto sea del tipo IStepCounter. 
         Esta interfaz se debe implementar por todos aquellos abjetos que quieran llevar la cuenta de los Steps que visitan.
    
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

    ACOPLAMIENTO: Esta clase genera BAJO acoplamiento ya que hace que la dependencia de la clase compuesta pueda ser substituida por cualquier objeto
    que implemente esta interfaz.
*/

/// <summary>
/// Esta interfaz se crea para poder eliminar dependencias de AbstractPlayer.
/// </summary>

namespace Library
{
    public interface IStepCounter
    {
        public int GetStepInformation(IStep step);
        public void ReceiveStepConfirmation(IStep step);
    }
}