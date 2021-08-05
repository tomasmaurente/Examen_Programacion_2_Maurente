namespace Library
{
    public class OceanHandler : AbstractHandler
    {
        public OceanHandler()
        : base(new MountainHandler2(), new Ocean())
        { }
    }
}