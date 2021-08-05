using System.Collections.Generic;

namespace Library
{
    public interface IScenary : IStep
    {
        public AbstractReward PointsOfVisit(int timesInStep);
    }
}