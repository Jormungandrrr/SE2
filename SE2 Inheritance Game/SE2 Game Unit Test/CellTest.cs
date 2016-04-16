﻿
﻿using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SE2_Game.Game.Map;

namespace SE2_Game_Unit_Test
{
    [TestClass]
    public class CellTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            Cell cell = new Cell(new Point(), new Point(), new Size());
            Assert.AreEqual(new Point(), cell.Index);
            Assert.AreEqual(new Point(), cell.Position);
            Assert.AreEqual(Cell.CellType.Normal, cell.Type);

            cell.Type = Cell.CellType.Goal;
            Assert.AreEqual(Cell.CellType.Goal, cell.Type);
        }
    }
}