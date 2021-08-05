namespace Library
{
    public interface IStepCounter
    {
        public int GetStepInformation(IStep step);
        public void ReceiveStepConfirmation(IStep step);
    }
}