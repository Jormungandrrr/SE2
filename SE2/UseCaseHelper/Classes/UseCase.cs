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

        public List<Actor> Actors { get { return this.actors; } set { this.actors = value;  } }
    }
}
