using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module5Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StreamReader inputfile;
        String fileContents = "";

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                inputfile = File.OpenText(openFileDialog1.FileName);
                while (!inputfile.EndOfStream)
                {
                    fileContents = fileContents + (inputfile.ReadLine());
                }
            }
            else if (result == DialogResult.Cancel)
            {
                
            }
            else
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool done = false;
            string currLine; 
            if (fileContents == "")
            {
                return;
            } else
            {
                while (!done)
                {
                    currLine = 
                }
            }
        }
    }
}
