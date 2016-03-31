using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE2_Game.Game
{
    class Armour : Item
    {
        public Armour(Point Position) : base(Position)
        {
            this.Weight = 5;
            this.Amount = 20;
            this.Name = "Armour";
            this.Brush.Color = Color.Gray;
            this.ItemType = Type.Armour;
            this.Text = "A";
    }

    }
}
