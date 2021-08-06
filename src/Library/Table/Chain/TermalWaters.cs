
/*
    SRP: Esta clase cumple con SRP ya que su unica resposabilidad es definir un handler. Cada handler contiene un IStep ejecutable. 
    
    OCP: No se aplica.

    LSP: Esta clase cumple con LSP ya que en varias ocaciones es utilizada como parametro de tipo AbstractHandler.
*/

namespace Library
{
    public class TermalWatersHandler : AbstractHandler
    {
        public TermalWatersHandler()
        : base(new MountainHandler(), new ThermalWaters(2))
        { }
    }
}