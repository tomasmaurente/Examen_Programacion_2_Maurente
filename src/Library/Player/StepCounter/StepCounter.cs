using System.Collections.Generic;

namespace Library
{
    public class StepCounter
    {
        private Dictionary<IStep, int> stepsCounter = new Dictionary<IStep, int>();
        public int GetStepInformation(IStep step)
        {
            if (step != null)
            {
                if (!(stepsCounter.ContainsKey(step)))
                {
                    stepsCounter.Add(step, 1);
                }
                return stepsCounter[step];
            }
            return 0;
        }

        public void ReceiveStepConfirmation(IStep step)
        {
            if (step != null)
            {
                if (!(stepsCounter.ContainsKey(step)))
                {
                    stepsCounter.Add(step, 1);
                }
                else
                {
                    stepsCounter[step] += 1;
                }
            }
            return;
        }
    }
}