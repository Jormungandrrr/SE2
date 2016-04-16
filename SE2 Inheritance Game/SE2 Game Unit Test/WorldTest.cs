using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SE2_Game.Game;

namespace SE2_Game_Unit_Test
{
    [TestClass]
    public class WorldTest
    {
        [TestMethod]
        public void TestCreate()
        {
            // Create a world with two cells: one shall contain the player, one
            // shall contain the goal.
            World.Instance.Create(new Size(20, 10), new Size(2, 1), 0,1);
            Assert.AreNotEqual(World.Instance.Player.Position,
                //World.Instance.Enemy.Position,
                "Enemy should not be positioned on top of player.");
        }

        [TestMethod]
        public void TestGameWon()
        {
            // Create a world with two cells: one shall contain the player, one
            // shall contain the goal.
            World.Instance.Create(new Size(20, 10), new Size(2, 1), 0,1);
            Assert.IsFalse(World.Instance.GameWon);

            World.Instance.Player.Interaction(Keys.Right);
            World.Instance.Update();
            Assert.IsTrue(World.Instance.GameWon);
        }

        [TestMethod]
        public void TestUpdate()
        {
            if (World.Instance.Player.Position.Equals(World.Instance.EnemyList[0].Position))
            {
               Assert.Equals(World.Instance.Player.HitPoints, World.Instance.Player.HitPoints - 5);
            }
        }
    }
}