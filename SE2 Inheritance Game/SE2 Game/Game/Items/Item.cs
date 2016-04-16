using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE2_Game.Game
{
    public abstract class Item : ICarryable
    {
        public Point Position { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Amount { get; set; }
        public string Text { get; set; }
        public Type ItemType { get; set; }
        public enum Type {Heal,Damage,Armour,PDamage}
        protected SolidBrush Brush = new SolidBrush(Color.FromArgb(0, 255, 0));
        

        public Item(Point Position)
        {
            this.Position = Position;
        }

        public void Draw(Graphics g)
        {
            Rectangle r = new Rectangle(
            this.Position + new Size(World.borderSize * 2, World.borderSize * 2),
            World.Instance.Grid.CellSize - new Size(World.borderSize * 4, World.borderSize * 4));
            g.FillRectangle(this.Brush, r);
            g.DrawRectangle(World.pen, r);
            g.DrawString(System.Convert.ToString(this.Text),
            World.font, Brushes.White, r, World.stringFormat);
        }
    }
}
