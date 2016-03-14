using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontwikkelopdracht
{
    class Cell
    {
        private Point position;
        private string celltype;
        public bool Special { get; }

        public Cell()
        {

        }

        public Point Position { get { return this.position; } }

    }
}
