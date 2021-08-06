namespace Library
{
    public class MountainHandler : AbstractHandler
    {
        public MountainHandler()
        : base (new OceanHandler(), Mountain.GetMountain())
        {}
    }
}