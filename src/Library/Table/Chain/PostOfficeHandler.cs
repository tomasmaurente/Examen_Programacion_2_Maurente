
/*
    SRP: Esta clase cumple con SRP ya que su unica resposabilidad es definir un handler. Cada handler contiene un IStep ejecutable. 
    
    OCP: No se aplica.
*/

namespace Library
{
    public class PostOfficeHandler : AbstractHandler
    {
        public PostOfficeHandler()
        : base(new TermalWatersHandler(), new PostOffice(4, 4))
        { }
    }
}