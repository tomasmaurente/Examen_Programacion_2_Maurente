namespace Library
{
    public class PostOfficeHandler : AbstractHandler
    {
        public PostOfficeHandler()
        : base(new TermalWatersHandler(), new PostOffice(4,4))
        { }
    }
}