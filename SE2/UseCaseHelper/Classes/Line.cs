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
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private Actor a;
        private UseCase u;

        public Line(Actor a, UseCase u)
        {
            this.x1 = a.X;
            this.y1 = a.Y;
            this.x2 = u.x;
            this.y2 = u.y;
            this.a = a;
            this.u = u;
        }

        Pen Thickline = new Pen(Color.FromArgb(255, 0, 0, 0), 5);

        public void Draw(Graphics grap)
        {
            grap.DrawLine(Form1.pen, this.x1, (this.y1 + 18), this.x2, this.y2);
        }

        public int X1 { get { return this.X1; } set { this.X1 = value; } }
        public int Y1 { get { return this.y1; } set { this.y1 = value; } }
        public int X2 { get { return this.X2; } set { this.X2 = value; } }
        public int Y2 { get { return this.y2; } set { this.y2 = value; } }
        public Actor A { get { return this.a; } }
        public UseCase U { get { return this.u; } }



    }
}
