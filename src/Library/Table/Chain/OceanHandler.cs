
/*
    SRP: Esta clase cumple con SRP ya que su unica resposabilidad es definir un handler. Cada handler contiene un IStep ejecutable. 
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