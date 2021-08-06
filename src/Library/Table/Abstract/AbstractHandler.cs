using System.Collections.Generic;

namespace Library
{
    public abstract class AbstractHandler
    {
        protected AbstractHandler next;
        protected List<AbstractPlayer> players = new List<AbstractPlayer>();
        protected IStep step;
        protected AbstractHandler(AbstractHandler next, IStep step)
        {
            this.next = next;
            this.step = step;
        }
        public virtual void ReceivePlayer(AbstractPlayer player)
        {
            if (this.IsAvailable())
            {
                this.players.Add(player);
            }
            else
            {
                throw new IsNotAvailableException();
            }
        }
        public virtual bool IsAvailable()
        {
            return this.players.Count < 2;
        }
        public virtual AbstractPlayer GetLastPlayer()
        {
            if (players.Count > 0)
            {
                return players[0];
            }
            else
            {
                return this.next.GetLastPlayer();
            }
        }                
        public virtual void MovePlayer(AbstractPlayer player, int spotsToMove, bool playerAlreadyFound)
        {
            if(spotsToMove >= 0 )
            {
                if (this.players.Contains(player))
                {
                    this.players.Remove(player);
                    this.next.MovePlayer(player, spotsToMove - 1, true);
                }
                else
                {
                    if (playerAlreadyFound)
                    {
                        if (spotsToMove == 0)
                        {
                            this.ReceivePlayer(player);
                            return;
                        }
                        this.next.MovePlayer(player, spotsToMove - 1, true);
                    }
                    else
                    {
                        this.next.MovePlayer(player, spotsToMove, false);
                    }
                }
            }
            else
            {
                throw new JustMoveFowardExeption();
            }
        }            
        public virtual void ExecuteStep(AbstractPlayer player)
        {
            if (this.players.Contains(player))
            {
                player.ExecuteStep(step);
            }
            else
            {
                this.next.ExecuteStep(player);
            }
        }
    }
}