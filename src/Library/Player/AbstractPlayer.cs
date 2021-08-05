using System.Collections.Generic;

namespace Library
{
    public abstract class AbstractPlayer : AbstractRewardedPlayer
    {
        private IStepCounter stepCounter = new StepCounter();
        public string Name
        {
            get
            { 
                return Name;
            }
            private set
            {
                if (Name != "")
                {
                    this.Name = value;
                }
            }
        }
        
        public AbstractPlayer(string name, Dictionary<AbstractReward,int> availableRewards)
        : base(availableRewards)
        {
            this.Name = name;
        }

        public void ExecuteStep(IStep step)
        {
            int timesInStep = this.stepCounter.GetStepInformation(step);
            List<AbstractReward> rewards = new List<AbstractReward>();
            step.Execute(ref timesInStep ,ref rewards);
            this.AddReward(rewards);
            this.stepCounter.ReceiveStepConfirmation(step);     
        }
    }
}
