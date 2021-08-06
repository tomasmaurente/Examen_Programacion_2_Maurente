using System.Collections.Generic;

namespace Library
{
    public abstract class AbstractPlayer : IRewardedPlayer, IStepCounter
    {
        public StepCounter StepCounter { get; }
        public RewardedPlayer RewardedPlayer { get; }
        public string Name { get; private set; }

        public AbstractPlayer(string name)
        : base()
        {
            this.Name = name;
            this.RewardedPlayer = new RewardedPlayer();
            this.StepCounter = new StepCounter();
        }

        public void ExecuteStep(IStep step)
        {
            if (step != null)
            {
                int timesInStep = this.GetStepInformation(step);
                List<AbstractReward> rewards = new List<AbstractReward>();
                step.Execute(timesInStep, ref rewards);
                this.AddReward(rewards);
                this.ReceiveStepConfirmation(step);
            }
        }

        public void AddReward(List<AbstractReward> incomingReward)
        {
            this.RewardedPlayer.AddReward(incomingReward);
        }

        public AbstractReward TotalPoints()
        {
            return this.RewardedPlayer.TotalPoints();
        }

        public AbstractReward TotalCoins()
        {
            return this.RewardedPlayer.TotalCoins();
        }

        public int GetStepInformation(IStep step)
        {
            return this.StepCounter.GetStepInformation(step);
        }

        public void ReceiveStepConfirmation(IStep step)
        {
            this.StepCounter.ReceiveStepConfirmation(step);
        }
    }
}
