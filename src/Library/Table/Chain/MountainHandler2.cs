
/*
    SRP: Esta clase cumple con SRP ya que su unica resposabilidad es definir un handler. Cada handler contiene un IStep ejecutable. 
*/

namespace Library
{
    public class MountainHandler2 : AbstractHandler
    {
        public MountainHandler2()
        : base(new FinalHandler(), Mountain.GetMountain())
        { }
    }
}