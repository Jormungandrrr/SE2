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
    partial class UseCaseProperties : Form
    {
        UseCase u;
        public UseCaseProperties(UseCase u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void UseCaseProperties_Load(object sender, EventArgs e)
        {
            tbNaam.Text = u.name;
            if (u.summary != null){ tbSamenvatting.Text = u.summary; }
            if (u.result != null) { tbResultaat.Text = u.result; }
            if (u.aannamen != null) { tbAannamen.Text = u.aannamen; }
            if (u.discription != null) { rtbBeschrijving.Text = u.discription; }
            if (u.exceptions != null) { rtbUitzonderingen.Text = u.exceptions; }
            foreach (Actor a in u.Actors)
            {
                tbActoren.Text += a.Name + ",";
            }
        }

        private void tbSamenvatting_Validating(object sender, CancelEventArgs e)
        {
            u.summary = tbSamenvatting.Text;
        }

        private void tbAannamen_Validating(object sender, CancelEventArgs e)
        {
            u.aannamen = tbAannamen.Text;
        }

        private void rtbBeschrijving_Validating(object sender, CancelEventArgs e)
        {
            u.discription = rtbBeschrijving.Text;
        }

        private void rtbUitzonderingen_Validating(object sender, CancelEventArgs e)
        {
            u.exceptions = rtbUitzonderingen.Text;
        }

        private void tbResultaat_Validating(object sender, CancelEventArgs e)
        {
            u.result = tbResultaat.Text;
        }
    }
}
