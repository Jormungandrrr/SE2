using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SE2_Game.Entity;
using SE2_Game.Game;

namespace SE2_Game
{
    public partial class Inputbox : Form
    {
        public int enemieCount;
        public bool Loadmap;
        public List<String> Content = new List<string>();
        public Inputbox()
        {
            InitializeComponent();
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            enemieCount = (int)nudEnemies.Value;
            this.Close();
        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {
            FileStream file;
            try
            {
                file = new FileStream(GetFilepath(), FileMode.Open, FileAccess.Read);

                using (StreamReader r = new StreamReader(file))
                {
                    List<string> content = new List<string>();
                    while (!r.EndOfStream)
                    {
                        Content.Add(r.ReadLine());
                    }
                    
                    this.Loadmap = true;
                }
            }
            catch (IOException) { }
        }

        public string GetFilepath()
        {
            System.Windows.Forms.OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (ofd.ShowDialog() == DialogResult.OK)
            {   
                return ofd.FileName;
            }
            else { return "Geen bestand gekozen"; }
        }
    }
}
