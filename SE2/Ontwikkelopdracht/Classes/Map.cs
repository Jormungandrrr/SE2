using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ontwikkelopdracht
{
    class Map
    {
        private Object background;
        public int Gravity;
        private Player actor;
        private int height;
        private int width;
        List<Object> objectList;
        List<Enemy> enemyList;

        public Map()
        {

        }

        public void Finish()
        {

        }
        public void CollisionDetection()
        {

        }
        public void Draw()
        {

        }
        public void Load()
        {

        }
        public Object Backround { get { return this.background } set { this.background = value; } }
        public Player Actor { get { return this.actor } set { this.actor = value; } }
        public int Height { get { return this.height } set { this.height = value; } }
        public int Width { get { return this.width } set { this.width = value; } }

        public List<Object> Objectlist { get { return this.objectList; } set { this.objectList = value; } }
        public List<Enemy> Enemylist { get { return this.enemyList; } set { this.enemyList = value; } }
    }
}
