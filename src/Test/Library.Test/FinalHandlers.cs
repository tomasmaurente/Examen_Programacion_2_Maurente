using NUnit.Framework;

namespace Library
{
    public class GameTests
    {
        // Player.
        private AbstractPlayer player1;
        private AbstractPlayer player2;
        private AbstractPlayer player3;
        private AbstractPlayer player4;
        // Handlers.
        private StartHandler handler;

        [SetUp]
        public void Setup()
        {
            // Player.
            this.player1 = new Player("Juan");
            this.player2 = new Player("Pepo");
            this.player3 = new Player("Ceci");
            this.player4 = new Player("Alejandra");
            // Handlers.
            this.handler = new StartHandler();
        }
        [Test]
        public void Party()
        {
            this.handler.GetInTable(this.player1);
            this.handler.GetInTable(this.player2);
            this.handler.GetInTable(this.player3);
            this.handler.MovePlayer(this.player1, 1, false);
            this.handler.ExecuteStep(this.player1);
            try
            {
                this.handler.GetInTable(this.player4);
            }
            catch (GameIsAlreadyStartedException)
            {
                this.handler.MovePlayer(this.player2, 2, false);
                this.handler.ExecuteStep(this.player2);

                this.handler.MovePlayer(this.player3, 3, false);
                this.handler.ExecuteStep(this.player3);
                try
                {
                    this.handler.MovePlayer(this.player1, -1, false);
                }
                catch (JustMoveFowardExeption)
                {
                    try
                    {
                        this.handler.MovePlayer(this.player1, 65, false);
                    }
                    catch (EndOfTheRoadException)
                    {
                        this.handler.ExecuteStep(this.player1);
                        this.handler.MovePlayer(this.player2, 4, false);
                        this.handler.ExecuteStep(this.player1);

                        this.handler.MovePlayer(this.player3, 3, false);
                        this.handler.ExecuteStep(this.player1);
                    }
                }

            }
            Assert.True(this.handler.GetPodium()[0] == player1 && this.handler.GetPodium()[1] == player3 && this.handler.GetPodium()[2] == player2);

        }
    }
}