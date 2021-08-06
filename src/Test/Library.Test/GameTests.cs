using NUnit.Framework;

namespace Library
{
    public class FinalHandlersTests
    {
        // Player.
        private AbstractPlayer player1;
        private AbstractPlayer player2;
        private AbstractPlayer player3;
        // Handlers.
        private FinalHandler handler;
        private StartHandler startHandler;

        [SetUp]
        public void Setup()
        {
            // Player.
            this.player1 = new Player("Juan");
            this.player2 = new Player("Pepo");
            this.player3 = new Player("Ceci");
            // Handlers.
            this.handler = new FinalHandler();
            this.startHandler = new StartHandler();
        }
        [Test]
        public void ReceivePlayer()
        {
            this.handler.ReceivePlayer(this.player2);
        }
        [Test]
        public void IsAlwaysAvailable()
        {
            Assert.True(this.handler.IsAvailable());
        }
        [Test]
        public void GetLastPlayerThrowsExeption()
        {
            Assert.Throws<Library.AlreadyFinishedException>(() => this.handler.GetLastPlayer());
        }
        [Test]
        public void MovePlayerThrowsExeption()
        {
            Assert.Throws<Library.EndOfTheRoadException>(() => this.handler.MovePlayer(this.player1, 1, false));
        }
        [Test]
        public void MovePlayerThrowsExeptionEvenWithCrazyNumber()
        {
            Assert.Throws<Library.EndOfTheRoadException>(() => this.handler.MovePlayer(this.player1, 65211, false));
        }
        [Test]
        public void MovePlayerThrowsExeptionEvenWithTrueArgument()
        {
            Assert.Throws<Library.EndOfTheRoadException>(() => this.handler.MovePlayer(this.player1, 65211, false));
        }
        [Test]
        public void GetPodiumRight()
        {
            this.startHandler.GetInTable(this.player1);
            this.startHandler.GetInTable(this.player2);
            this.startHandler.MovePlayer(this.player1, 1, false);
            this.startHandler.ExecuteStep(this.player1);
            this.startHandler.MovePlayer(this.player1, 1, false);
            this.startHandler.ExecuteStep(this.player1);
            this.startHandler.MovePlayer(this.player1, 1, false);
            this.startHandler.ExecuteStep(this.player1);
            this.startHandler.MovePlayer(this.player1, 1, false);
            this.startHandler.ExecuteStep(this.player1);
            this.startHandler.MovePlayer(this.player1, 1, false);
            this.startHandler.ExecuteStep(this.player1);
            this.startHandler.MovePlayer(this.player1, 1, false);
            this.startHandler.ExecuteStep(this.player1);
            this.startHandler.MovePlayer(this.player1, 1, false);
            this.startHandler.ExecuteStep(this.player1);


            this.startHandler.MovePlayer(this.player2, 1, false);
            this.startHandler.ExecuteStep(this.player2);

            //Assert.True(this.handler)

        }
    }
}