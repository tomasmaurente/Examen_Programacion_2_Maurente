namespace Library
{
    public class TermalWatersHandler : AbstractHandler
    {
        public TermalWatersHandler()
        : base(new MountainHandler(), new ThermalWaters(2))
        { }
    }
}