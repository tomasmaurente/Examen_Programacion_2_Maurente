using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;

namespace Library
{
    public class StepsTests
    {
        // Player.
        private AbstractPlayer player;
        private IStep step;
        private List<AbstractReward> rewards;

        
        [SetUp]
        public void Setup()
        {
            // Player.
            this.player = new Player("Juan");  
            this.rewards = new List<AbstractReward>();

        }       
        [Test]
        public void Farm()
        {
            this.step = new Farm(2);
            this.step.Execute(1,ref this.rewards);
            Assert.AreEqual(2, this.rewards[0].Value);
        }
        [Test]
        public void FarmDoNotCareHowManyTimes()
        {
            this.step = new Farm(2);
            this.step.Execute(122222,ref this.rewards);
            Assert.AreEqual(2, this.rewards[0].Value);
        }
        [Test]
        public void FarmNegativeInput()
        {
            this.step = new Farm(-3);
            this.step.Execute(0,ref this.rewards);
            Assert.AreEqual(0, this.rewards[0].Value);
        }
        [Test]
        public void ThermalWaters()
        {
            this.step = new ThermalWaters(2);
            this.step.Execute(1,ref this.rewards);
            Assert.AreEqual(2, this.rewards[0].Value);
        }
        [Test]
        public void ThermalWatersDoNotCareHowManyTimes()
        {
            this.step = new ThermalWaters(2);
            this.step.Execute(36527,ref this.rewards);
            Assert.AreEqual(2, this.rewards[0].Value);
        }
        [Test]
        public void ThermalWatersNegativeInput()
        {
            this.step = new ThermalWaters(-3);
            this.step.Execute(0,ref this.rewards);
            Assert.AreEqual(0, this.rewards[0].Value);
        }
        [Test]
        public void PostOffice()
        {
            this.step = new PostOffice(2,2);
            this.step.Execute(1,ref this.rewards);
            Assert.True(2 == this.rewards[0].Value && 2 == this.rewards[1].Value );
        }
        [Test]
        public void PostOfficeDoNotCareHowManyTimes()
        {
            this.step = new PostOffice(2,2);
            this.step.Execute(5685459,ref this.rewards);
            Assert.True(2 == this.rewards[0].Value && 2 == this.rewards[1].Value );
        }
        [Test]
        public void PostOfficeNegativeInput()
        {
            this.step = new PostOffice(-3, -7);
            this.step.Execute(0,ref this.rewards);
            Assert.True(0 == this.rewards[0].Value && 0 == this.rewards[1].Value );
        }
        [Test]
        public void Mountain()
        {
            this.step = new Mountain();
            this.step.Execute(1,ref this.rewards);
            Assert.AreEqual(1, this.rewards[0].Value);
        }
        [Test]
        public void MountainDoCareHowManyTimes()
        {
            this.step = new Mountain();
            this.step.Execute(15,ref this.rewards);
            Assert.AreEqual(15, this.rewards[0].Value);
        }
        [Test]
        public void MountainNegativeInput()
        {
            this.step = new Mountain();
            this.step.Execute(-3,ref this.rewards);
            Assert.AreEqual(1, this.rewards[0].Value);
        }
        [Test]
        public void Ocean()
        {
            this.step = new Ocean();
            this.step.Execute(1,ref this.rewards);
            Assert.AreEqual(1, this.rewards[0].Value);
        }
        [Test]
        public void OceanDoCareHowManyTimes()
        {
            this.step = new Ocean();
            this.step.Execute(5,ref this.rewards);
            Assert.AreEqual(9, this.rewards[0].Value);
        }
        [Test]
        public void OceanNegativeInput()
        {
            this.step = new Ocean();
            this.step.Execute(-3,ref this.rewards);
            Assert.AreEqual(1, this.rewards[0].Value);
        }
    }
}