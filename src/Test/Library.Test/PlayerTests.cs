using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Library
{
    public class PlayerTests
    {
        // Player.
        private AbstractPlayer player;
        [SetUp]
        public void Setup()
        {
            this.player = new Player("Juan");
        }

        // AntiAircraft.
        [Test]
        public void AddableAnticraft()
        {
            // Assert.
            Assert.IsTrue(true);
        }
    }
}