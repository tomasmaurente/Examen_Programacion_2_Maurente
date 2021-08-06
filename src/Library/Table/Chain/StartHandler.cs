using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class StartHandler : AbstractHandler, IStartHandler
    {
        private bool canGetIn = true;
        private List<AbstractPlayer> listOfPlayers = new List<AbstractPlayer>();
        public StartHandler()
        : base(new FarmHandler(), null)
        { }
        public void GetInTable(AbstractPlayer player)
        {
            if (this.IsAvailable())
            {
                this.players.Add(player);
                this.listOfPlayers.Add(player);
            }
            else
            {
                this.canGetIn = false;
                throw new GameIsAlreadyStartedException();
            }
        }
        public List<AbstractPlayer> GetPlayers()
        {
            return listOfPlayers;
        }
        public override bool IsAvailable()
        {
            if (canGetIn)
            {
                if (this.players.Count < 5)
                {
                    return true;
                }
                throw new TooManyPlayersInTableExeption();
            }
            return false;
        }
        public override void ExecuteStep(AbstractPlayer player)
        {
            if (this.players.Contains(player))
            {
                this.canGetIn = false;
            }
            else
            {
                this.next.ExecuteStep(player);
            }
        }
        public override void MovePlayer(AbstractPlayer player, int spotsToMove, bool playerAlreadyFound)
        {
            if(spotsToMove >= 0 )
            {
                if (this.players.Contains(player))
                {
                    this.players.Remove(player);
                    this.next.MovePlayer(player, spotsToMove - 1, true);
                    this.canGetIn = false;
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
        public List<AbstractPlayer> GetPodium()
        {
            return this.listOfPlayers.OrderBy(p => p.TotalPoints().Value).ThenBy(p => p.TotalCoins().Value).ToList();
        }
    }
}