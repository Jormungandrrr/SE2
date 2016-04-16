using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE2_Game.Game
{
    class Spikes: Item
    {
        public Spikes(Point Position) : base(Position)
        {
            this.Weight = 0;
            this.Amount = 10;
            this.Name = "Spike";
            this.Brush.Color = Color.DarkRed;
            this.ItemType = Type.PDamage;
            this.Text = "S";
        }
    }
}
