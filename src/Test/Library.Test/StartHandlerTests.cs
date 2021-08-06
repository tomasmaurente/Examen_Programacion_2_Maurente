using NUnit.Framework;

namespace Library
{
    public class StartHandlerTests
    {
        // Player.
        private AbstractPlayer player;
        // Handler.
        private StartHandler handler;

        [SetUp]
        public void Setup()
        {
            // Player.
            this.player = new Player("Juan");
            // Handlers.
            this.handler = new StartHandler();
        }

        [Test]
        public void GetInTableTest()
        {
            this.handler.GetInTable(this.player);
            Assert.True(handler.GetPlayers()[0] == this.player);
        }
        [Test]
        public void CantGetInTableBecauseSomeoneHasAlreadyStarted()
        {
            this.handler.GetInTable(this.player);
            this.handler.ExecuteStep(this.player);
            Assert.Throws<Library.GameIsAlreadyStartedException>(() => this.handler.GetInTable(new Player("Pepo")));
        }
        [Test]
        public void CantGetInTableBecauseSomeoneHasAlreadyMoved()
        {
            this.handler.GetInTable(this.player);
            this.handler.MovePlayer(this.player, 1, true);
            Assert.Throws<Library.GameIsAlreadyStartedException>(() => this.handler.GetInTable(new Player("Pepo")));
        }
        [Test]
        public void CantGetInTableTooManyPlayers()
        {
            this.handler.GetInTable(this.player);
            this.handler.GetInTable(this.player);
            this.handler.GetInTable(this.player);
            this.handler.GetInTable(this.player);
            this.handler.GetInTable(this.player);
            Assert.Throws<Library.TooManyPlayersInTableExeption>(() => this.handler.GetInTable(this.player));
        }
        [Test]
        public void GetPlayers()
        {
            this.handler.GetInTable(this.player);
            this.handler.GetInTable(this.player);
            this.handler.GetInTable(this.player);
            this.handler.GetInTable(this.player);
            this.handler.GetInTable(this.player);
            Assert.True(this.handler.GetPlayers().Count == 5);
        }
        [Test]
        public void EmptyGetPLayers()
        {
            Assert.True(this.handler.GetPlayers().Count == 0);
        }
        [Test]
        public void IsAvailableIfNobodyIsInTable()
        {
            Assert.True(this.handler.IsAvailable());
        }
        [Test]
        public void InNotAvailableIsPLayerExecute()
        {
            this.handler.GetInTable(this.player);
            this.handler.ExecuteStep(this.player);
            Assert.False(this.handler.IsAvailable());
        }
        [Test]
        public void IsNotAvailableIfPlayerMove()
        {
            this.handler.GetInTable(this.player);
            this.handler.MovePlayer(this.player, 1, true);
            Assert.False(this.handler.IsAvailable());
        }
        [Test]
        public void GetPodiumRight()
        {
            AbstractPlayer player2 = new Player("Carlos");

            this.handler.GetInTable(this.player);
            this.handler.GetInTable(player2);
            this.handler.MovePlayer(this.player, 1, false);
            this.handler.ExecuteStep(this.player);
            this.handler.MovePlayer(this.player, 1, false);
            this.handler.ExecuteStep(this.player);
            this.handler.MovePlayer(this.player, 1, false);
            this.handler.ExecuteStep(this.player);
            this.handler.MovePlayer(this.player, 1, false);
            this.handler.ExecuteStep(this.player);
            this.handler.MovePlayer(this.player, 1, false);
            this.handler.ExecuteStep(this.player);
            this.handler.MovePlayer(this.player, 1, false);
            this.handler.ExecuteStep(this.player);
            this.handler.MovePlayer(this.player, 1, false);
            this.handler.ExecuteStep(this.player);


            this.handler.MovePlayer(player2, 1, false);
            this.handler.ExecuteStep(player2);

            Assert.True(this.handler.GetPodium()[0] == player2);
        }
    }
}