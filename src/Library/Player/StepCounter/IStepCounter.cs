
/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es declarar las operacoines necesarias para que un objeto sea del tipo IStepCounter. 
            Esta interfaz se debe implementar por todos aquellos abjetos que quieran llevar la cuenta de los Steps que visitan.
    
    OCP: Esta clase es ejemplo de como implementar una funcionalidad en AbstractPlayer haciendo cambios minimos en ella. AbstractPlayer al implementar esta
    interfaz solo debe agregar las operaciones dictadas, asi solo solo estamos extendiendo el codigo y no modificandolo.
*/

namespace Library
{
    public interface IStepCounter
    {
        StepCounter StepCounter { get; }
        public int GetStepInformation(IStep step);
        public void ReceiveStepConfirmation(IStep step);
    }
}