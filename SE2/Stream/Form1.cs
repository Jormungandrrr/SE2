using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stream
{
    public partial class Form1 : Form
    {
        private string FilePath = ("Default");


        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(GetFilepath()))
            {
                
                while (!reader.EndOfStream)
                {
                    rtbContent.Text += reader.ReadLine() + "\n";
                }
            }


        }

        public string GetFilepath()
        {
            System.Windows.Forms.OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FilePath = ofd.FileName;
                return FilePath;
            }
            else return "no file path";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!File.Exists(path))
            {
                File.Create(path + "Testfile");   
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine(rtbContent.Text);
                tw.Close();
            }
        }
    }
}
