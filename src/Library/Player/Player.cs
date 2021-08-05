using System.Collections.Generic;

namespace Library
{
    public class Player : AbstractPlayer
    {
        public Player(string name, Dictionary<AbstractReward,int> availableRewards)
        : base(name, availableRewards)
        {
        }      
    }
}