namespace Library
{
    public class FinalHandler : AbstractHandler
    {
        public FinalHandler()
        : base(null, null)
        { }

        public override void ReceivePlayer(AbstractPlayer player)
        {
            this.players.Add(player);
        }
        public override bool IsAvailable()
        {
            return true;
        }
        public override AbstractPlayer GetLastPlayer()
        {
            throw new AlreadyFinishedException();
        }
        public override void MovePlayer(AbstractPlayer player, int spotsToMove, bool playerAlreadyFound)
        {
            if (spotsToMove > 0)
            {
                this.ReceivePlayer(player);
                throw new EndOfTheRoadException();
            }
            else
            {
                this.ReceivePlayer(player);
            }
        }
        public override void ExecuteStep(AbstractPlayer player)
        {
            return;
        }
    }
}