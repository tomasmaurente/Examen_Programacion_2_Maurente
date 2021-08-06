namespace Library
{
    public interface IScenary : IStep
    {
        public AbstractReward PointsOfVisit(int timesInStep);
    }
}