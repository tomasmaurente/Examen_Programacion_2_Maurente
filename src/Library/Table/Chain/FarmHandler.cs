namespace Library
{
    public class FarmHandler : AbstractHandler
    {
        public FarmHandler()
        : base(new PostOfficeHandler(), new Farm(3))
        { }
    }
}