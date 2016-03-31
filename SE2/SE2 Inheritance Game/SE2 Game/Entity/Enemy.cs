using System.Drawing;
using SE2_Game.Game;

namespace SE2_Game.Entity
{
    public class Enemy : Character
    {
        // The lower this value is, the faster the enemy moves
        private int msBetweenMoves = 100;
        private long previousMoveTime;
        private SolidBrush Brush = new SolidBrush(Color.FromArgb(255, 0, 0));
        // We need a font and formatter to draw strings. Instead of creating
        // them on each drawing call, we define them once here.

        public Enemy(Point position)
        {
            this.Position = position;
            this.HitPoints = 100;

            // Make drawn string appear centered in the positioning rectangle.
            World.stringFormat.Alignment = StringAlignment.Center;
            World.stringFormat.LineAlignment = StringAlignment.Center;
        }

        public override void Draw(Graphics g)
        {
            Rectangle r = new Rectangle(
            this.Position + new Size(World.borderSize * 2, World.borderSize * 2),
            World.Instance.Grid.CellSize - new Size(World.borderSize * 4, World.borderSize * 4));
            g.FillEllipse(this.Brush, r);
            g.DrawEllipse(World.pen, r);
            g.DrawString(System.Convert.ToString(this.HitPoints),
            World.font, Brushes.White, r, World.stringFormat);
        }
        public override void Update()
        {
            if (World.Instance.Time - this.previousMoveTime >= this.msBetweenMoves)
            {
                Action[] moves = new Action[5]
                {
                    Action.MoveUp, Action.MoveRight, Action.MoveDown, Action.MoveLeft,
                    Action.NoAction
                };
                Action action = moves[Random.Next(moves.Length)];

                this.Position = this.UpdatePosition(this.Position, action);
                this.previousMoveTime = World.Instance.Time;
            }
        }
    }
}
