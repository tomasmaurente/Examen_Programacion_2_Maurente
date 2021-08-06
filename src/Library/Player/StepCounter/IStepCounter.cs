namespace Library
{
    public interface IStepCounter
    {
        StepCounter StepCounter { get; }
        public int GetStepInformation(IStep step);
        public void ReceiveStepConfirmation(IStep step);
    }
}