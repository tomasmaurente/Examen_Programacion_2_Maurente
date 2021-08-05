using System.Collections.Generic;

namespace Library
{
    public class StepCounter : IStepCounter
    {
        private Dictionary< IStep, int > stepsCounter = new Dictionary<IStep, int>();
        public int GetStepInformation(IStep step)
        {
            if (!(stepsCounter.ContainsKey(step)))
            {
                stepsCounter.Add(step,1);
            }
            return stepsCounter[step];
        }

        public void ReceiveStepConfirmation(IStep step)
        {
            stepsCounter[step] += 1;
        }
    }
}