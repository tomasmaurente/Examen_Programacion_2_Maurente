namespace Library
{
    public abstract class AbstractReward
    {
        public int Value { get; set; }
        public AbstractReward(int value)
        {
            this.Value = value;
        }
    }
}