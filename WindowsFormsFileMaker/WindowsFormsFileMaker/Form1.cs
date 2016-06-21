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

namespace WindowsFormsFileMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //eventHandler for button clicked
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //use and clean up resource
                //text box 1 = top left box
                //gets filename from text box then creates/updates that file
                using (FileStream fStream = File.Create(textBox1.Text))
                {
                    Byte[] text = new UTF8Encoding(true).GetBytes(richTextBox1.Text);
                    //write to hard drive via file stream
                    fStream.Write(text, 0, text.Length);
                }
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sReader = File.OpenText(textBox2.Text))
                {
                    string linesToPrint;
                    while((linesToPrint=sReader.ReadLine()) != null)
                    {
                        richTextBox2.Text += linesToPrint + "\n"; 
                    }
                }


            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}
