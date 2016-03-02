using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UseCaseHelper
{
    class Line
    {
        private string name;
        private int x1;
        private int y1;
        private int x2;
        private int y2;


        public Line(string name, int x1, int y1, int x2, int y2)
        {
            this.name = name;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public void Draw(Graphics grap)
        {
            grap.DrawLine(Form1.pen, this.x1, this.y1, this.x2, this.y2);
        }

        public string Name { get { return this.name; } set { this.name = value; } }
        public int X1 { get { return this.X1; } set { this.X1 = value; } }
        public int Y1 { get { return this.y1; } set { this.y1 = value; } }
        public int X2 { get { return this.X2; } set { this.X2 = value; } }
        public int Y2 { get { return this.y2; } set { this.y2 = value; } }



    }
}
