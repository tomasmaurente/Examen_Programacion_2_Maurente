using System.Collections.Generic;

namespace Library
{
    public class StartHandler : AbstractHandler, IStartHandler
    {
        private bool _canGetIn = true;
        private List<AbstractPlayer> _listOfPlayers;
        public StartHandler()
        : base(new FarmHandler(), null)
        { }

        public void GetInTable(AbstractPlayer player)
        {
            if (this.IsAvailable())
            {
                this.players.Add(player);
                this._listOfPlayers.Add(player);
            }
            else
            {
                this._canGetIn = false;
                throw new GameIsAlreadyStartedException();
            }
        }
        public List<AbstractPlayer> GetPlayers()
        {
            return _listOfPlayers;
        }
        public override bool IsAvailable()
        {
            return _canGetIn && this.players.Count < 5;
        }
        public override void ExecuteStep(AbstractPlayer player)
        {
            this._canGetIn = false;
        }
    }
}