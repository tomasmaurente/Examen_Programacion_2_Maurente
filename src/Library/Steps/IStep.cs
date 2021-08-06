using System.Collections.Generic;

namespace Library
{
    public interface IStep
    {
        public void Execute( int timesInStep, ref List<AbstractReward> rewards);
    }
}