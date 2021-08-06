
/*
    SRP: Esta clase cumple con SRP ya que su unica resposabilidad es definir un handler. Cada handler contiene un IStep ejecutable. 
    
    OCP: No se aplica.
    
    LSP: Esta clase cumple con LSP ya que en varias ocaciones es utilizada como parametro de tipo AbstractHandler.

    ISP: No se aplica.

    DIP: Esta clase cumple con DIP ya que depende solamente de abstracciones. Sus dependencias son con AbstractPlayer e IStep.
*/

namespace Library
{
    public class OceanHandler : AbstractHandler
    {
        public OceanHandler()
        : base(new MountainHandler2(), Ocean.GetOcean())
        { }
    }
}