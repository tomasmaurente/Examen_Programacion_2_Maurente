
/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es declarar las operacoines necesarias para que un objeto sea del tipo IStepCounter. 
            Esta interfaz se debe implementar por todos aquellos abjetos que quieran llevar la cuenta de los Steps que visitan.

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