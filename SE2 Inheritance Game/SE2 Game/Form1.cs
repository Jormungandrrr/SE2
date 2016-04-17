using System;
using System.Windows.Forms;
using SE2_Game.Game;
using System.IO;
using System.Runtime.Serialization;
using System.Drawing;

namespace SE2_Game
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Inputbox InputBox = new Inputbox();
            InputBox.ShowDialog();
            if (InputBox.Loadmap)
            {
                World.Instance.Create(picGame.Size, InputBox.enemieCount,InputBox.Content);
            }
            else
            {
                World.Instance.Create(picGame.Size, new System.Drawing.Size(9, 9), 10, InputBox.enemieCount);

            }

        }

        private void picGame_Paint(object sender, PaintEventArgs e)
        {
            // This code smooths the drawing done on the picture box.
            e.Graphics.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // The game world is responible for the actual drawing.
            World.Instance.Draw(e.Graphics);
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            // First update the game world, that trigger a refresh on the
            // picturebox so that the new state will be displayed.
            if (World.Exists)
            {
                World.Instance.Update();
                picGame.Refresh();

                if (World.Instance.GameOver)
                {
                    timerAnimation.Enabled = false;
                    MessageBox.Show("Game Over!");
                    this.Close();
                }

                if (World.Instance.GameWon)
                {
                    timerAnimation.Enabled = false;
                    MessageBox.Show("Game Won!");
                    this.Close();
                }
            }
            else { }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            World.Instance.Player.Interaction(e.KeyCode);
        }
        private void btnSaveMap_Click(object sender, EventArgs e)
        {
            int count = 1;
            string filename = "Map";
            while (File.Exists(filename + ".txt"))
            {
                filename = "Map" + count;
                count++;
            }


            using (StreamWriter sw = new StreamWriter(filename +".txt"))
            {
                foreach (String s in World.Instance.Grid.MapLayout())
                {
                    sw.WriteLine(s);
                }    
            }
        }
    }
}
