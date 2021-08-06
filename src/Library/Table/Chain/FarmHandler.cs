
/*
    SRP: Esta clase cumple con SRP ya que su unica resposabilidad es definir un handler. Cada handler contiene un IStep ejecutable. 
    
    OCP: No se aplica.
*/

namespace Library
{
    public class FarmHandler : AbstractHandler
    {
        public FarmHandler()
        : base(new PostOfficeHandler(), new Farm(3))
        { }
    }
}