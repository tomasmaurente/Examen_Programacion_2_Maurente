namespace Library
{
    public class MountainHandler2 : AbstractHandler
    {
        public MountainHandler2()
        : base(new FinalHandler(), Mountain.GetMountain())
        { }
    }
}