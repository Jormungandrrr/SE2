using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SE2_Game.Game
{
    public interface ICarryable
    {
        string Name { get; set; }
        int Weight { get; set; }
        int Amount { get; set; }
        string Text { get; set; }
        Point Position { get; set; }

        void Draw(Graphics g);
    }
}
