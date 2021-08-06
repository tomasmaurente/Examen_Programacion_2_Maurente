using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;

namespace Library
{
    public class PlayerTests
    {
        // Player.
        private AbstractPlayer player;
        private IStep step;
        IStepCounter stepCounter;

        [SetUp]
        public void Setup()
        {
            // Player.
            this.player = new Player("Juan");
            this.stepCounter = new StepCounter();
        }
        [Test]
        public void PlayerInTermal()
        {
            this.step = new ThermalWaters(2);
            player.ExecuteStep(step);
            Assert.AreEqual(2, player.TotalPoints().Value);
        }
        [Test]
        public void PlayerTwiceInTermal()
        {
            this.step = new ThermalWaters(2);
            player.ExecuteStep(step);
            player.ExecuteStep(step);
            Assert.AreEqual(4, player.TotalPoints().Value);
        }
        [Test]
        public void PlayerInFarm()
        {
            this.step = new Farm(2);
            player.ExecuteStep(step);
            Assert.AreEqual(2, player.TotalCoins().Value);
        }
        [Test]
        public void PlayerTwiceInFarm()
        {
            this.step = new Farm(2);
            player.ExecuteStep(step);
            player.ExecuteStep(step);
            Assert.AreEqual(4, player.TotalCoins().Value);
        }
        [Test]
        public void PlayerInMountain()
        {
            this.step = Mountain.GetMountain();
            player.ExecuteStep(step);
            Assert.AreEqual(1, player.TotalPoints().Value);
        }
        [Test]
        public void PlayerInMountains()
        {
            this.step = Mountain.GetMountain();
            player.ExecuteStep(step);
            player.ExecuteStep(step);
            Assert.AreEqual(3, player.TotalPoints().Value);
        }
        [Test]
        public void PlayerInOcean()
        {
            this.step = Ocean.GetOcean();
            player.ExecuteStep(step);
            Assert.AreEqual(1, player.TotalPoints().Value);
        }
        [Test]
        public void PlayerInOceans()
        {
            this.step = Ocean.GetOcean();
            player.ExecuteStep(step);
            player.ExecuteStep(step);
            Assert.AreEqual(4, player.TotalPoints().Value);
        }
        [Test]
        public void PlayerInPostOffice()
        {
            this.step = new PostOffice(1, 1);
            player.ExecuteStep(step);
            Assert.True(1 == player.TotalPoints().Value && 1 == player.TotalCoins().Value);
        }
        [Test]
        public void ListOfRewardsWhitNegative()
        {
            this.step = new ThermalWaters(-2);
            player.ExecuteStep(step);
            Assert.AreEqual(0, player.TotalPoints().Value);
        }
        [Test]
        public void NullStep()
        {
            player.ExecuteStep(null);
            Assert.AreEqual(0, player.TotalPoints().Value);
        }
        [Test]
        public void GetStepInformationTest()
        {
            this.step = new ThermalWaters(-2);
            stepCounter.ReceiveStepConfirmation(this.step);
            Assert.AreEqual(stepCounter.GetStepInformation(this.step), 1);
        }
        [Test]
        public void GetStepInformationWithOutPreviousConfirmationTest()
        {
            this.step = new ThermalWaters(-2);
            Assert.AreEqual(stepCounter.GetStepInformation(this.step), 1);
        }
        [Test]
        public void GetStepInformationWithPlentyPreviousConfirmationTest()
        {
            this.step = new ThermalWaters(-2);
            stepCounter.ReceiveStepConfirmation(this.step);
            stepCounter.ReceiveStepConfirmation(this.step);
            stepCounter.ReceiveStepConfirmation(this.step);
            Assert.AreEqual(stepCounter.GetStepInformation(this.step), 3);
        }
        [Test]
        public void GetDiferentsStepsInformationTest()
        {
            // Arrange.
            this.step = new ThermalWaters(-2);
            IStep step2 = new Farm(9);
            IStep step3 = Mountain.GetMountain();
            // Act.
            stepCounter.GetStepInformation(step);
            stepCounter.GetStepInformation(step2);
            stepCounter.ReceiveStepConfirmation(step2);
            stepCounter.ReceiveStepConfirmation(step3);
            stepCounter.GetStepInformation(step3);
            Assert.True(stepCounter.GetStepInformation(step) == 1 && stepCounter.GetStepInformation(step2) == 2 && stepCounter.GetStepInformation(step3) == 1);
        }
        [Test]
        public void GetTotalPointsIfChargerCoinsTest()
        {
            this.step = new Farm(1);
            player.ExecuteStep(step);
            player.ExecuteStep(step);
            player.ExecuteStep(step);
            player.ExecuteStep(step);
            Assert.AreEqual(0, player.TotalPoints().Value);
        }
        [Test]
        public void GetTotalPointsTest()
        {
            this.step = Ocean.GetOcean();
            player.ExecuteStep(step);
            player.ExecuteStep(step);
            player.ExecuteStep(step);
            player.ExecuteStep(step);
            Assert.AreEqual(16, player.TotalPoints().Value);
        }
        [Test]
        public void GetTotalPointsWithNoPointsTest()
        {
            Assert.AreEqual(0, player.TotalCoins().Value);
        }
        [Test]
        public void GetTotalCoinsTest()
        {
            this.step = new Farm(1);
            player.ExecuteStep(step);
            player.ExecuteStep(step);
            player.ExecuteStep(step);
            player.ExecuteStep(step);
            Assert.AreEqual(4, player.TotalCoins().Value);
        }
        [Test]
        public void GetTotalCoinsIfChargerPointsTest()
        {
            this.step = Ocean.GetOcean();
            player.ExecuteStep(step);
            player.ExecuteStep(step);
            player.ExecuteStep(step);
            player.ExecuteStep(step);
            Assert.AreEqual(0, player.TotalCoins().Value);
        }
        [Test]
        public void GetTotalCoinsWithNoCoinsTest()
        {
            Assert.AreEqual(0, player.TotalCoins().Value);
        }
    }
}