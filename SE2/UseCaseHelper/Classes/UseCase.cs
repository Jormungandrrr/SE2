using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UseCaseHelper
{
    class UseCase
    {
        public string name { get; set; }
        public string summary { get; set; }
        private List<Actor> actors = new List<Actor>();
        public string discription { get; set; }
        public string exceptions { get; set; }
        public string result { get; set; }
        public int x { get; private set; }
        public int y { get; private set; }
        public Rectangle box { get; set; }


        public UseCase(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;

        }

        public void Draw(Graphics grap)
        {
            grap.DrawEllipse(Form1.pen, (this.x - 75), (this.y - 45), 200, 100);
            grap.DrawString(this.name, Form1.DrawFont, Form1.DrawBrush, this.x, this.y);
            this.box = new Rectangle((this.x - 80), (this.y - 50), 220, 110);
        }

        public List<Actor> Actors { get { return this.actors; } set { this.actors = value;  } }
    }
}
