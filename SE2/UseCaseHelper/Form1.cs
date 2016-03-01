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
        UseCaseProperties UseCaseForm = new UseCaseProperties();
        List<Actor> ActorList = new List<Actor>();
        List<UseCase> UsecaseList = new List<UseCase>();
        private Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
        SolidBrush DrawBrush = new SolidBrush(Color.Black);
        private Graphics grap;
        Font DrawFont = new Font("Arial", 12);
        private int actorcount = 0;
        Point pActor;
        Point pCase;
        public Form1()
        {
            InitializeComponent();
            UseCaseForm.Enabled = false;  
        }
        
        private void pbUseCase_Click(object sender, EventArgs e)
        {
            
            if (UseCaseForm.Enabled == false)
            {
                UseCaseForm.Show();
                UseCaseForm.Enabled = true;
                UseCaseForm.Location = new Point(this.Left + this.Width, this.Top);
                UseCaseForm.Height = this.Height;
                enableRadioButtons();
            }
            else
            {
                #region CreateActor
                if ((rbCreate.Checked == true) && (rbActor.Checked == true))
                {
                    string actorname = input("Wat is de naam van de actor?");
                    if (ActorList.Count < 3 && actorname != null && actorname != "")
                    {
                        #region AddActorToList
                        actorcount++;
                        switch (actorcount)
                        {
                            
                            case 1:
                                ActorList.Add(new Actor(25, 50, actorname));
                                break;
                            case 2:
                                ActorList.Add(new Actor(25, 150, actorname));
                                break;
                            case 3:
                                ActorList.Add(new Actor(25, 250, actorname));
                                break;
                            default:
                                break;
                        }
                        #endregion
                        Actor currentActor = ActorList.Find(a => a.Name == actorname);
                        drawActor(currentActor);
                    }
                }
                #endregion
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
        
        private void drawActor(Actor a)
        {
            grap = pbUseCase.CreateGraphics();
            grap.DrawEllipse(pen, (a.X - 12), (a.Y - 25), 25,25); //head
            grap.DrawLine(pen, a.X,a.Y, 25, (a.Y + 25)); // body
            grap.DrawLine(pen, a.X,(a.Y + 25), 35, a.Y + 40); //right foot
            grap.DrawLine(pen, a.X, (a.Y + 25), 15, a.Y + 40); //left foot
            grap.DrawLine(pen, a.X, (a.Y + 15), 35, a.Y); //right hand
            grap.DrawLine(pen, a.X, (a.Y + 15), 15, a.Y); //left hand
            grap.DrawString(a.Name, DrawFont, DrawBrush, (a.X - 20), (a.Y + 38));
            //grap.DrawRectangle(pen, (a.X - 20), (a.Y - 35), 43, 90);
            a.Box = new Rectangle((a.X - 20), (a.Y - 35), 43, 90);       
        }

        private void DrawCase(UseCase u)
        {
            grap = pbUseCase.CreateGraphics();
            grap.DrawEllipse(pen, (u.x - 75), (u.y - 45), 200, 100);
            grap.DrawString(u.name, DrawFont, DrawBrush, u.x, u.y);
            u.box = new Rectangle((u.x - 80), (u.y - 50), 220, 110);
            //grap.DrawRectangle(pen,(u.x - 80), (u.y - 50), 220, 110);
        }
        bool actorSelected = false;
        bool caseSelected = false;
        private void pbUseCase_MouseClick(object sender, MouseEventArgs e)
        {
            #region createUseCase
            if (rbCreate.Checked == true && rbUseCase.Checked ==true)
            {
                string UseCaseName = input("Wat is de naam van de usecase?");
                UsecaseList.Add(new UseCase(UseCaseName,e.X, e.Y));
                UseCase currentusecase = UsecaseList.Find(u => u.name == UseCaseName);
                DrawCase(currentusecase);
            }
            #endregion
            if (rbCreate.Checked == true && rbLine.Checked == true)
            {
                if (SelectActor(e.Location) != null)
                {
                    Actor a = SelectActor(e.Location);
                    pActor.X = a.X;
                    pActor.Y = a.Y;
                    actorSelected = true;
                }
                if (SelectCase(e.Location) != null)
                {
                    UseCase u = SelectCase(e.Location);
                    pCase.X = u.x;
                    pCase.Y = u.y;
                    caseSelected = true;
                }
                if (actorSelected && caseSelected)
                {
                    grap.DrawLine(pen, pActor, pCase);
                    pCase.X = 0;
                    pCase.Y = 0;
                    pActor.Y = 0;
                    pActor.X = 0;
                    caseSelected = false;
                    actorSelected = false;
                }
                

            }
        }

        private string input(string question)
        {
            InputBox inputform = new InputBox(question);
            inputform.ShowDialog();
            return inputform.Answer;
        }

        private Actor SelectActor(Point mouseloc)
        {
            Actor selectedactor = null;
            if (ActorList.Count > 0)
            {
                foreach (Actor a in ActorList)
                {
                    if (a.Box.Contains(mouseloc))
                    {
                        selectedactor = a;
                    }
                }
            }
            return selectedactor;
        }
        private UseCase SelectCase(Point mouseloc)
        {
            UseCase selectedCase = null;
            if (UsecaseList.Count > 0)
            {
                foreach (UseCase u in UsecaseList)
                {
                    if (u.box.Contains(mouseloc))
                    {
                        selectedCase = u;
                    }
                }
            }
            return selectedCase;
        }
    }
}
