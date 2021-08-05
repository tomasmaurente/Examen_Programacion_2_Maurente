namespace Library
{
    public abstract class AbstractReward
    {
        private int value {
            get
            {
                return this.value;
            }
            set
            {
                if (value > 0)
                {
                    this.value = value;
                }
            } 
        }

        public AbstractReward(int value)
        {
            this.value = value;
        }

        public int GetValue()
        {
            return this.value;
        }
    }
}