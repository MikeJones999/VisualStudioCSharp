using System;
using System.Windows.Forms;

namespace SimpleWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Load button
        private void button1_Click(object sender, EventArgs e)
        {
            if(addressBox.Text == "")
            {
                MessageBox.Show("Please enter and address");
            }
            else
            {
                webBrowser1.Navigate(new Uri(addressBox.Text));
            }
        }

        private void addressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
    }
}
