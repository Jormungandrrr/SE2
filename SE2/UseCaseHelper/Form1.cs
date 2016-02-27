using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper
{
    public partial class Form1 : Form
    {
        UseCaseProperties UseCase = new UseCaseProperties();
        List<Actor> ActorList = new List<Actor>();
        private Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
        private Graphics grap;
        private int actorcount = 0;
        public Form1()
        {
            InitializeComponent();
            UseCase.Enabled = false;  
        }
        
        private void pbUseCase_Click(object sender, EventArgs e)
        {
            
            if (UseCase.Enabled == false)
            {
                UseCase.Show();
                UseCase.Enabled = true;
                UseCase.Location = new Point(this.Left + this.Width, this.Top);
                UseCase.Height = this.Height;
                enableRadioButtons();
            }
            else
            {
                if ((rbCreate.Checked == true) && (rbActor.Checked == true))
                {
                    InputBox inputform = new InputBox("Wat is de naam van de actor?");
                    inputform.ShowDialog();
                    string actorname = inputform.Answer;

                    if (ActorList.Count < 3 && actorname != null)
                    {
                        actorcount++;
                        switch (actorcount)
                        {
                            case 1:
                                ActorList.Add(new Actor(25, 50, actorname, actorcount));
                                break;
                            case 2:
                                ActorList.Add(new Actor(25, 150, actorname, actorcount));
                                break;
                            case 3:
                                ActorList.Add(new Actor(25, 250, actorname, actorcount));
                                break;
                            default:
                                break;
                        }
                        
                        drawActor();
                        
                    }
                }
            }
        }

        private void enableRadioButtons()
        {
            rbActor.Enabled = true;
            rbCreate.Enabled = true;
            rbLine.Enabled = true;
            rbSelect.Enabled = true;
            rbUseCase.Enabled = true;
        }
        
        private void drawActor()
        {
            foreach ( Actor a in ActorList)
            {
                if (a.Actorcount == ActorList.Count)
                {
                    grap = pbUseCase.CreateGraphics();
                    grap.DrawEllipse(pen, (a.X - 12), (a.Y - 25), 25,25); //head
                    grap.DrawLine(pen, a.X,a.Y, 25, (a.Y + 25)); // body
                    grap.DrawLine(pen, a.X,(a.Y + 25), 35, a.Y + 40); //right foot
                    grap.DrawLine(pen, a.X, (a.Y + 25), 15, a.Y + 40); //left foot
                    grap.DrawLine(pen, a.X, (a.Y + 15), 35, a.Y); //right hand
                    grap.DrawLine(pen, a.X, (a.Y + 15), 15, a.Y); //left hand
                    //grap.DrawRectangle(pen, (a.X - 20), (a.Y - 35), 40, (a.Y + 35));
                    a.Box = new Rectangle((a.X - 20), (a.Y - 35), 40, (a.Y + 35));
                }
            }
                
        }

        private void pbUseCase_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbSelect.Checked == true && ActorList.Count > 0)
            {
                foreach (Actor a in ActorList)
                {
                    if (a.Box.Contains(e.Location))
                    {
                        MessageBox.Show(a.Name);
                    }
                }
            }
        }
    }
}
