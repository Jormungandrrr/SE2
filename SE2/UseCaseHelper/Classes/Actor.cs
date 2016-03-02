using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    class Actor
    {
        private string name;
        private int x;
        private int y;
        private Rectangle box;
        public Actor(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public int X { get { return this.x; } }
        public int Y { get { return this.y; } }
        public Rectangle Box { get { return this.box; } set {  this.box = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }

        public void Draw(Graphics grap)
        {
            grap.DrawEllipse(Form1.pen, (this.X - 12), (this.Y - 25), 25, 25); //head
            grap.DrawLine(Form1.pen, this.X, this.Y, 25, (this.Y + 25)); // body
            grap.DrawLine(Form1.pen, this.X, (this.Y + 25), 35, this.Y + 40); //right foot
            grap.DrawLine(Form1.pen, this.X, (this.Y + 25), 15, this.Y + 40); //left foot
            grap.DrawLine(Form1.pen, this.X, (this.Y + 15), 35, this.Y); //right hand
            grap.DrawLine(Form1.pen, this.X, (this.Y + 15), 15, this.Y); //left hand
            grap.DrawString(this.Name, Form1.DrawFont, Form1.DrawBrush, (this.X - 20), (this.Y + 38));
            //grap.DrawRectangle(pen, (a.X - 20), (a.Y - 35), 43, 90);
            this.Box = new Rectangle((this.X - 20), (this.Y - 35), 43, 90);
        }


    }
}
