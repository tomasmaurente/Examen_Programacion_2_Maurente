using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;

namespace Library
{
    public class HandlersTests
    {
        // Player.
        private AbstractPlayer player1;
        private AbstractPlayer player2;
        private AbstractPlayer player3;
        // Handler.
        private StartHandler handler;
        
        [SetUp]
        public void Setup()
        {
            // Player.
            this.player1 = new Player("Juan"); 
            this.player2 = new Player("Pepo"); 
            this.player3 = new Player("Ceci");  
            // Handlers.
            this.handler = new StartHandler();
        }
        [Test]
        public void ReceivePlayer()
        {
            this.handler.GetInTable(this.player1);
            this.handler.ReceivePlayer(this.player2);
            Assert.True(handler.GetPlayers().Count > 0);
        }
        [Test]
        public void ThereIsLimitedSpaceInEachHandler()
        {
            this.handler.GetInTable(this.player1);
            this.handler.GetInTable(this.player2);
            this.handler.GetInTable(this.player3);
            this.handler.MovePlayer(this.player1,1,false);
            this.handler.MovePlayer(this.player2,1,false);
            Assert.Throws<Library.IsNotAvailableException>(() => this.handler.MovePlayer(this.player3,1,false));
        }
        [Test]
        public void GetLastPlayerTest()
        {
            this.handler.GetInTable(this.player1);
            this.handler.GetInTable(this.player2);
            this.handler.MovePlayer(this.player1,1,false);
            this.handler.MovePlayer(this.player2,2,false);
            Assert.AreEqual(this.handler.GetLastPlayer(),this.player1);
        }
        [Test]
        public void GetLastPlayerFromTheBegginingTest()
        {
            this.handler.GetInTable(this.player1);
            this.handler.GetInTable(this.player2);
            this.handler.MovePlayer(this.player2,2,false);
            Assert.AreEqual(this.handler.GetLastPlayer(),this.player1);
        }
        [Test]
        public void GetLastPlayerFromTheSameSpotTest()
        {
            this.handler.GetInTable(this.player1);
            this.handler.GetInTable(this.player2);
            this.handler.MovePlayer(this.player1,2,false);
            this.handler.MovePlayer(this.player2,2,false);
            Assert.AreEqual(this.handler.GetLastPlayer(),this.player1);
        }
        [Test]
        public void MovePlayer()
        {
            this.handler.GetInTable(this.player1);
            this.handler.MovePlayer(this.player1,1 ,false);
            Assert.AreEqual(this.handler.GetLastPlayer(),this.player1);
        }
        [Test]
        public void PlayerNotInTable()
        {
            this.handler.GetInTable(this.player1);
            Assert.Throws<Library.EndOfTheRoadException>(() => this.handler.MovePlayer(this.player2,1,false));
        }
        [Test]
        public void TableHaveAnEnd()
        {
            this.handler.GetInTable(this.player1);
            Assert.Throws<Library.EndOfTheRoadException>(() => this.handler.MovePlayer(this.player1,1000,false));
        }
        [Test]
        public void JustMoveFoward()
        {
            this.handler.GetInTable(this.player1);
            Assert.Throws<Library.JustMoveFowardExeption>(() => this.handler.MovePlayer(this.player1,-1000,false));
        }
        [Test]
        public void CanNotStayInSamePlace()
        {
            this.handler.GetInTable(this.player1);
            Assert.Throws<Library.JustMoveFowardExeption>(() => this.handler.MovePlayer(this.player1,0,false));
        }
        [Test]
        public void WrongBoolInCommand()
        {
            this.handler.GetInTable(this.player1);
            this.handler.GetInTable(this.player2);
            this.handler.MovePlayer(this.player1,5,true);
            this.handler.MovePlayer(this.player2,4,false);
            this.handler.MovePlayer(this.player1,1,true);
            Assert.AreEqual(this.handler.GetLastPlayer(),this.player1);
        }
        [Test]
        public void ExecuteFarm()
        {
            this.handler.GetInTable(this.player1);
            this.handler.MovePlayer(this.player1,1,false);
            this.handler.ExecuteStep(this.player1);
            Assert.True(this.player1.TotalCoins().Value == 3);
        }
        [Test]
        public void ExecutePostOffice()
        {
            this.handler.GetInTable(this.player1);
            this.handler.MovePlayer(this.player1,2,false);
            this.handler.ExecuteStep(this.player1);
            Assert.True(this.player1.TotalCoins().Value == 4 && this.player1.TotalPoints().Value == 4);
        }
        [Test]
        public void ExecuteThermalWaters()
        {
            this.handler.GetInTable(this.player1);
            this.handler.MovePlayer(this.player1,3,false);
            this.handler.ExecuteStep(this.player1);
            Assert.True(this.player1.TotalPoints().Value == 2);
        }
        [Test]
        public void ExecuteMountain1()
        {
            this.handler.GetInTable(this.player1);
            this.handler.MovePlayer(this.player1,4,false);
            this.handler.ExecuteStep(this.player1);
            Assert.True(this.player1.TotalPoints().Value == 1);
        }
        [Test]
        public void ExecuteOcean()
        {
            this.handler.GetInTable(this.player1);
            this.handler.MovePlayer(this.player1,5,false);
            this.handler.ExecuteStep(this.player1);
            Assert.True(this.player1.TotalPoints().Value == 1);
        }
        [Test]
        public void ExecuteMountain2()
        {
            this.handler.GetInTable(this.player1);
            this.handler.MovePlayer(this.player1,6,false);
            this.handler.ExecuteStep(this.player1);
            Assert.True(this.player1.TotalPoints().Value == 1);
        }
        [Test]
        public void ExecuteFinal()
        {
            this.handler.GetInTable(this.player1);
            this.handler.MovePlayer(this.player1,7,false);
            this.handler.ExecuteStep(this.player1);
            Assert.True(this.player1.TotalCoins().Value == 0 && this.player1.TotalPoints().Value == 0);
        }
        [Test]
        public void ExecuteAllSteps()
        {
            this.handler.GetInTable(this.player1);
            this.handler.MovePlayer(this.player1,1,false);
            this.handler.ExecuteStep(this.player1);
            this.handler.MovePlayer(this.player1,1,false);
            this.handler.ExecuteStep(this.player1);
            this.handler.MovePlayer(this.player1,1,false);
            this.handler.ExecuteStep(this.player1);
            this.handler.MovePlayer(this.player1,1,false);
            this.handler.ExecuteStep(this.player1);
            this.handler.MovePlayer(this.player1,1,false);
            this.handler.ExecuteStep(this.player1);
            this.handler.MovePlayer(this.player1,1,false);
            this.handler.ExecuteStep(this.player1);
            this.handler.MovePlayer(this.player1,1,false);
            this.handler.ExecuteStep(this.player1);
            Assert.AreEqual(this.player1.TotalCoins().Value, 7 );
            Assert.AreEqual(this.player1.TotalPoints().Value, 10);
        }
        [Test]
        public void ExecuteAllTripBothOfPlayers()
        {
            this.handler.GetInTable(this.player1);
            this.handler.MovePlayer(this.player1,1,false);
            this.handler.ExecuteStep(this.player1);
            this.handler.MovePlayer(this.player1,1,false);
            this.handler.ExecuteStep(this.player1);
            this.handler.MovePlayer(this.player1,1,false);
            this.handler.ExecuteStep(this.player1);
            this.handler.MovePlayer(this.player1,1,false);
            this.handler.ExecuteStep(this.player1);
            this.handler.MovePlayer(this.player1,1,false);
            this.handler.ExecuteStep(this.player1);
            this.handler.MovePlayer(this.player1,1,false);
            this.handler.ExecuteStep(this.player1);
            this.handler.MovePlayer(this.player1,1,false);
            this.handler.ExecuteStep(this.player1);
            Assert.AreEqual(this.player1.TotalCoins().Value, 7 );
            Assert.AreEqual(this.player1.TotalPoints().Value, 10);
        }
    }
} 