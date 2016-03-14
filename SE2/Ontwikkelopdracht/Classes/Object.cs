using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontwikkelopdracht
{
    class Object
    {
        private string name;
        private Point position;
        private int velocity;
        private Rectangle box;
        private Image spritetexture;

        public Object()
        {

        }

        public void LoadTexture()
        {

        }

        public string Name { get { return this.name } set { this.name = value; } }
        public Point Position { get { return this.position } set { this.position = value; } }
        public int Velocity { get { return this.velocity } set { this.velocity = value; } }
        public Rectangle Box { get { return this.box } set { this.box = value; } }
        public Image SpriteTexture { get { return this.spritetexture } set { this.spritetexture = value; } }
    }
}
