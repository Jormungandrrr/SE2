using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using SE2_Game.Entity;
using SE2_Game.Game;

namespace SE2_Game_Unit_Test
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class EnemyTest
    {
        private Enemy enemy;

        [TestInitialize]
        public void TestInitialize()
        {
            World.Instance.Create(new Size(100, 100), new Size(10, 10), 0, 3);
            this.enemy = new Enemy(new Point());
        }

        [TestMethod]
        public void TestConstructor()
        {
            Assert.AreEqual(100, this.enemy.HitPoints,
                "Enemy is expected to start with 100 hitpoints");
            Assert.AreEqual(new Point(), this.enemy.Position);

            Enemy otherEnemy = new Enemy(new Point(50, 50));
            Assert.AreEqual(new Point(50, 50), otherEnemy.Position);
        }
    }
}
