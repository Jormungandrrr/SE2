﻿using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SE2_Game.Game.Map
{
    public class Grid
    {
        private Size gridSize;
        private Size cellSize;
        private Size cellCount;
        private Cell[] cells;

        /// <summary>
        /// The width and height of the grid in pixels.
        /// </summary>
        public Size GridSize { get { return this.gridSize; } }
        /// <summary>
        /// The width and height of a cell in pixels.
        /// </summary>
        public Size CellSize { get { return this.cellSize; } }
        /// <summary>
        /// The number of horizontal and vertical cells.
        /// </summary>
        public Size CellCount { get { return this.cellCount; } }
        /// <summary>
        /// Gives the position of the goal cell.
        /// </summary>
        public Point GoalPosition
        {
            get
            {
                foreach (Cell cell in cells)
                {
                    if (cell.Type == Cell.CellType.Goal)
                    {
                        return cell.Position;
                    }
                }

                try
                {
                    return new Point(-1, -1);
                }
                catch (System.Exception)
                {

                    throw;
                }
                
            }
        }

        /// <summary>
        /// Construct a new grid instance with a given size and cell count.
        /// </summary>
        /// <param name="gridSize">The size of the grid in pixels.</param>
        /// <param name="cellCount">The number of cells required for both
        /// directions. This is used to calculate the width and height of
        /// each cell.</param>
        /// <param name="wallProbability">The chance that a cell will become
        /// a wall cell, expressed in a range from 0 to 100. Note that this
        /// only applies to empty cells: the player and goal will always be
        /// of type Normal and Goal, respectively.</param>
        public Grid(Size gridSize, Size cellCount, int wallProbability)
        {
            this.gridSize = gridSize;
            this.cellSize = new Size(gridSize.Width / cellCount.Width,
                                     gridSize.Height / cellCount.Height);
            this.cellCount = cellCount;

            this.cells = new Cell[cellCount.Width * cellCount.Height];
            for (int i = 0; i < this.cells.Length; ++i)
            {
                Point index = new Point(i % cellCount.Width, i / cellCount.Width);
                this.cells[i] = new Cell(index,
                    this.CellIndexToPosition(index),
                    this.CellSize);

                if (i > 0 && Random.Next(100) <= wallProbability)
                {
                    this.cells[i].Type = Cell.CellType.Wall;
                }
            }
            this.cells[this.cells.Length - 1].Type = Cell.CellType.Goal;
        }

        public Grid(List<string> map, Size gridSize)
        {
            this.gridSize = gridSize;
            this.cellCount.Height = map.Count;
            string[] wordslength = map[0].Split(',');
            this.cellCount.Width = wordslength.Length -1;
            this.cellSize = new Size(gridSize.Width / cellCount.Width,gridSize.Height / cellCount.Height);
            this.cells = new Cell[cellCount.Width * cellCount.Height];

            int wordnumber = 0;
            try
            {


                foreach (string s in map)
                {
                    string[] words = s.Split(',');
                    List<string> celllist = new List<string>(words);
                    celllist.RemoveAt(celllist.Count - 9);

                    foreach (string c in celllist)
                    {
                        Point index = new Point(wordnumber % cellCount.Width, wordnumber / (cellCount.Width));
                        this.cells[wordnumber] = new Cell(index,
                        this.CellIndexToPosition(index),
                        this.CellSize);
                        switch (c)
                        {
                            case "Normal":
                                this.cells[wordnumber].Type = Cell.CellType.Normal;
                                break;

                            case "Wall":
                                this.cells[wordnumber].Type = Cell.CellType.Wall;
                                break;

                            case "Goal":
                                this.cells[wordnumber].Type = Cell.CellType.Goal;
                                break;
                        }
                        wordnumber++;

                    }
                }
                this.cells[this.cells.Length - 1].Type = Cell.CellType.Goal;
            }
            catch
            {
                MessageBox.Show("Ongeldige map");
            }
        }

        /// <summary>
        /// Draw the current grid on the screen.
        /// </summary>
        /// <param name="g">The Graphics instance to draw with.</param>
        public void Draw(Graphics g)
        {
            foreach (Cell cell in this.cells)
            {
                cell.Draw(g);
            }
        }

        /// <summary>
        /// Returns a free position on the grid, where free means a position
        /// that is not occupied by other entities or things.
        /// </summary>
        /// <returns></returns>
        public Point FreePosition()
        {
            Point randomPosition = new Point();

            while (randomPosition.Equals(World.Instance.Player.Position) ||
                   this.CellTypeAtPosition(randomPosition) == Cell.CellType.Wall)
            {
                randomPosition = this.CellIndexToPosition(new Point(
                    Random.Next(this.CellCount.Width),
                    Random.Next(this.CellCount.Height)));
            }

            return randomPosition;
        }

        public Cell.CellType CellTypeAtPosition(Point position)
        {
                Point index = this.PositionToCellIndex(position);
                int arrayIndex = (index.Y * (this.cellCount.Width)) + index.X;
                return this.cells[arrayIndex].Type;
        }

        /// <summary>
        /// Converts a position to the index of a cell in the grid. The index
        /// is considered to be the top left pixel of a cell.
        /// </summary>
        /// <param name="position">The position to convert.</param>
        /// <returns>The cell index for the cell at the given position.</returns>
        private Point PositionToCellIndex(Point position)
        {
            Size cs = this.CellSize;
            return new Point((position.X - (position.X % cs.Width)) / cs.Width,
                             (position.Y - (position.Y % cs.Height)) / cs.Height);
        }

        /// <summary>
        /// Converts a cell index to an absolute position in pixels.
        /// </summary>
        /// <param name="index">The cell index to convert.</param>
        /// <returns>The position of the top left pixel of this cell.</returns>
        private Point CellIndexToPosition(Point index)
        {
            return new Point(index.X * this.CellSize.Width,
                             index.Y * this.CellSize.Height);
        }

        public List<string> MapLayout()
        {
            int count = 0;
            string row = "";
            List<string> content = new List<string>();
            foreach (Cell cell in this.cells)
            {
                if (count >= this.CellCount.Width)
                {
                    content.Add(row);
                    row = "";
                    count = 0;
                }
                row += cell.Type + ",";
                count++;
            }
            return content;
        }
    }
}
