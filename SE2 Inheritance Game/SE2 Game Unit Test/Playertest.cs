using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SE2_Game.Entity;
using SE2_Game.Game;
using System.Drawing;
using System.Windows.Forms;



namespace SE2_Game_Unit_Test
{
    [TestClass]
    public class Playertest
    {

        private Player player;

        [TestInitialize]
        public void TestInitialize()
        {
            World.Instance.Create(new Size(100, 100), new Size(10, 10), 0,5);
            this.player = new Player();
        }

        [TestMethod]
        public void TestConstructor()
        {
            Assert.AreEqual(100, this.player.HitPoints,
                "Player is expected to start with 100 hitpoints");
            Assert.AreEqual(new Point(), this.player.Position);
        }


        [TestMethod]
        public void TestPlayer()
        {
            Player p = new Player();
            Assert.AreEqual(100, p.hitPoints);
            Point startposition = new Point(0,0);
            Assert.AreEqual(startposition, p.Position);

        }

        [TestMethod]
        public void TestPositioningValid()
        {
            this.player.Interaction(Keys.Right);
            this.player.Update();
            Assert.AreEqual(new Point(10, 0), this.player.Position);
            this.player.Interaction(Keys.Down);
            this.player.Update();
            Assert.AreEqual(new Point(10, 10), this.player.Position);
            this.player.Interaction(Keys.Left);
            this.player.Update();
            Assert.AreEqual(new Point(0, 10), this.player.Position);
            this.player.Interaction(Keys.Up);
            this.player.Update();
            Assert.AreEqual(new Point(0, 0), this.player.Position);

            // Space or other (not WASD-keys) shouldn't change the position
            this.player.Interaction(Keys.Space);
            this.player.Update();
            Assert.AreEqual(new Point(0, 0), this.player.Position);
            this.player.Interaction(Keys.Escape);
            this.player.Update();
            Assert.AreEqual(new Point(0, 0), this.player.Position);
        }

        [TestMethod]
        public void TestPositioningInvalid()
        {
            // We can't move up or left from the starting position
            this.player.Interaction(Keys.Up);
            this.player.Update();
            Assert.AreEqual(new Point(0, 0), this.player.Position);
            this.player.Interaction(Keys.Left);
            this.player.Update();
            Assert.AreEqual(new Point(0, 0), this.player.Position);

            this.player.Interaction(Keys.Right);
            this.player.Update();
            Assert.AreEqual(new Point(10, 0), this.player.Position);
            this.player.Update();
            Assert.AreEqual(new Point(10, 0), this.player.Position);
        }

        [TestMethod]
        public void TestPositioningWalls()
        {
            // A field with only walls should mean we cannot move right
            // or down from the starting position.
            World.Instance.Create(new Size(100, 100), new Size(10, 10), 100,3);

            this.player.Interaction(Keys.Right);
            this.player.Update();
            Assert.AreEqual(new Point(0, 0), this.player.Position);
            this.player.Interaction(Keys.Down);
            this.player.Update();
            Assert.AreEqual(new Point(0, 0), this.player.Position);
        }



        [TestMethod]
        public void TestExample()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
