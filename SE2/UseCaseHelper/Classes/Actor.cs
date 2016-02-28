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
        private int actornumber;
        public Actor(int x, int y, string name, int count)
        {
            this.x = x;
            this.y = y;
            this.name = name;
            this.actornumber = count;
        }
        public int X { get { return this.x; } }
        public int Y { get { return this.y; } }
        public Rectangle Box { get { return this.box; } set {  this.box = value; } }
        public string Name { get { return this.name; } }
        public int Actornumber { get { return this.actornumber; } }



    }
}
