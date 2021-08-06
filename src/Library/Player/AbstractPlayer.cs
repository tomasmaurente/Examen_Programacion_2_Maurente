using System.Collections.Generic;

namespace Library
{
    public abstract class AbstractPlayer : AbstractRewardedPlayer
    {
        private IStepCounter stepCounter = new StepCounter();
        public string Name{ get; private set; }
        
        public AbstractPlayer(string name)
        : base()
        {
            this.Name = name;
        }

        public void ExecuteStep(IStep step)
        {
            if (step != null)
            {
                int timesInStep = this.stepCounter.GetStepInformation(step);
                List<AbstractReward> rewards = new List<AbstractReward>();
                step.Execute(ref timesInStep ,ref rewards);
                this.AddReward(rewards);
                this.stepCounter.ReceiveStepConfirmation(step);     
            }
        }
    }
}
