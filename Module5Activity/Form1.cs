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
        List<String> fileContents = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                inputfile = File.OpenText(openFileDialog1.FileName);
                while (!inputfile.EndOfStream)
                {
                    fileContents.Add(inputfile.ReadLine());
                }
                inputfile.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                
            }
            else
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            
            int currLine = 0; 
            if (fileContents.Count == 0)
            {
                return;
            } else
            {
                listBox1.Items.Clear();
                while (currLine < fileContents.Count) 
                {
                    if (fileContents[currLine].Contains(textBox2.Text))
                    {
                        listBox1.Items.Insert(listBox1.Items.Count,fileContents[currLine]);
                    }
                    currLine++;
                }
                
            }
           
        }
    }
}
