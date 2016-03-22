using System.Drawing;
using System.Windows.Forms;
using SE2_Game.Game;

namespace SE2_Game.Entity
{
    public class Player : Character
    {
        private SolidBrush Brush = new SolidBrush(Color.FromArgb(61, 123, 160));
        private Action CurrentAction
        {
            get
            {
                Action action = this.currentAction;
                this.currentAction = Action.NoAction;
                return action;
            }
            set
            {
                if (value != Action.NoAction)
                {
                    this.currentAction = value;
                }
            }
        }
        private Action currentAction = Action.NoAction;

        // We need a font and formatter to draw strings. Instead of creating
        // them on each drawing call, we define them once here.
        public Player()
        {
            this.HitPoints = 100;

            // Make drawn string appear centered in the positioning rectangle.
            this.stringFormat.Alignment = StringAlignment.Center;
            this.stringFormat.LineAlignment = StringAlignment.Center;
        }

        public override void Draw(Graphics g)
        {
            Rectangle r = new Rectangle(
            this.Position + new Size(borderSize * 2, borderSize * 2),
            World.Instance.Grid.CellSize - new Size(borderSize * 4, borderSize * 4));
            g.FillEllipse(this.Brush, r);
            g.DrawEllipse(this.pen, r);
            g.DrawString(System.Convert.ToString(this.HitPoints),
            this.font, Brushes.White, r, this.stringFormat);
        }

        public override void Update()
        {
            this.Position = base.UpdatePosition(this.Position, this.CurrentAction);
        }

        public void Interaction(Keys key)
        {
            if (key == Keys.Up || key == Keys.W)
            {
                this.CurrentAction = Action.MoveUp;
            }
            else if (key == Keys.Right || key == Keys.D)
            {
                this.CurrentAction = Action.MoveRight;
            }
            else if (key == Keys.Down || key == Keys.S)
            {
                this.CurrentAction = Action.MoveDown;
            }
            else if (key == Keys.Left || key == Keys.A)
            {
                this.CurrentAction = Action.MoveLeft;
            }
            else if (key == Keys.Space)
            {
                this.CurrentAction = Action.PerformAction;
            }
            else
            {
                this.CurrentAction = Action.NoAction;
            }
        }
    }
}
