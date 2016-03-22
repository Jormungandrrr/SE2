using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE2_Game
{
    public partial class Inputbox : Form
    {
        public int enemieCount;
        public Inputbox()
        {
            InitializeComponent();
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            enemieCount = (int)nudEnemies.Value;
            this.Close();
        }
    }
}
