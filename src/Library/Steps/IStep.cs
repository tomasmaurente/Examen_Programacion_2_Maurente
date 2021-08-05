using System.Collections.Generic;

namespace Library
{
    public interface IStep
    {
        public void Execute(ref int timesInStep, ref List<AbstractReward> rewards);
    }
}