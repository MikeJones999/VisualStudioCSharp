using System;
using System.Windows.Forms;


    partial class Program
    {
        static Form  myForm = new Form();
        static Button butt = new Button();
        static Label lbl = new Label();
        static TextBox box1 = new TextBox();
        static TextBox box2 = new TextBox();

        

        //event handler
        static void butt_Click(object sender, EventArgs e)
        {
         lbl.Text = (double.Parse(box1.Text) + double.Parse(box2.Text)).ToString();
        }


    }


