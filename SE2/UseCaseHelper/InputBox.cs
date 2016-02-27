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
    public partial class InputBox : Form
    {
        public string Answer { get; private set; }
        public InputBox(string question)
        {
            InitializeComponent();
            this.CenterToScreen();
            lbQuestion.Text = question;
        }

        private void BtnOke_Click(object sender, EventArgs e)
        {
            Answer = tbActorName.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
