using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SE2_Game.Game
{
    class HealthPotion : Item
    {
        public HealthPotion(Point Position) : base(Position)
        {
            this.Weight = 0;
            this.Amount = 50;
            this.Name = "HealtPotion";
            this.Brush.Color = Color.LightGreen;
            this.ItemType = Type.Heal;
            this.Text = "HP";
        }
    }
}
