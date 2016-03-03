using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper
{
    public partial class Form1 : Form
    {
        List<Actor> ActorList = new List<Actor>();
        static List<UseCase> UsecaseList = new List<UseCase>();
        List<Line> LineList = new List<Line>();
        public static Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
        public static SolidBrush DrawBrush = new SolidBrush(Color.Black);
        public static Font DrawFont = new Font("Arial", 12);
        private int actorcount = 0;
        Actor selectedActor = null;
        UseCase selectedCase = null;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void pbUseCase_Click(object sender, EventArgs e)
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
                        pbUseCase.Invalidate();
                    }
                }
                #endregion
            }

        private void pbUseCase_MouseClick(object sender, MouseEventArgs e)
        {
            #region createUseCase
            if (rbCreate.Checked && rbUseCase.Checked)
            {
                string UseCaseName = input("Wat is de naam van de usecase?");
                UsecaseList.Add(new UseCase(UseCaseName,e.X, e.Y));
                pbUseCase.Invalidate();
            }
            #endregion
            #region DrawLine
            else if (rbCreate.Checked && rbLine.Checked)
            {
                if (SelectActor(e.Location) != null)
                {
                    selectedActor = SelectActor(e.Location);
                    
                }
                else if (SelectCase(e.Location) != null)
                {
                    selectedCase = SelectCase(e.Location);
                    
                }
                if (selectedActor != null && selectedCase != null)
                {
                    LineList.Add(new Line(selectedActor,selectedCase));
                    pbUseCase.Invalidate();
                    selectedCase.Actors.Add(selectedActor);
                    selectedActor = null; selectedCase = null;
                }
            }
            #endregion
            else if (rbRename.Checked)
            {
                if (SelectActor(e.Location) != null)
                {
                    Actor a = (SelectActor(e.Location));
                    a.Name = input("Wat is de naam van de actor?");
                    pbUseCase.Invalidate();
                }
                else if (SelectCase(e.Location) != null)
                {
                    UseCase u = (SelectCase(e.Location));
                    u.name = input("Wat is de naam van de Usecase?");
                    pbUseCase.Invalidate();
                }
            }
            else if (rbSelect.Checked)
            {
                if (SelectCase(e.Location) != null)
                {
                    UseCase u = (SelectCase(e.Location));
                    UseCaseProperties UseCaseForm = new UseCaseProperties(u);
                    UseCaseForm.ShowDialog();
                    UseCaseForm.Location = new Point(this.Left + this.Width, this.Top);
                    UseCaseForm.Height = this.Height;
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

        private void pbUseCase_Paint(object sender, PaintEventArgs e)
        {
            foreach (Actor a in ActorList)
            {
                a.Draw(e.Graphics);
            }
            foreach (UseCase u in UsecaseList)
            {
                u.Draw(e.Graphics);
            }
            foreach (Line l in LineList)
            {
                l.Draw(e.Graphics);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ActorList.Clear();
            UsecaseList.Clear();
            LineList.Clear();
            pbUseCase.Invalidate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Bitmap bm = new Bitmap(pbUseCase.Image);
            //bm.Save(@"E:\Temp", ImageFormat.Jpeg);
        }
    }
}
