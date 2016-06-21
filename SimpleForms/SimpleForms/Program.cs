using System;

using System.Windows.Forms;

partial class Program
{
    static void Main(string[] args)
    {
        lbl.Top = 50; lbl.Left = 50;
        box1.Top = 75; box1.Left = 50;
        box2.Top = 100; box2.Left = 50;


        butt.Text = "+";

        butt.Click += butt_Click;
        myForm.Controls.Add(butt);
        myForm.Controls.Add(lbl);
        myForm.Controls.Add(box1);
        myForm.Controls.Add(box2);


        Application.Run(myForm);

    }
}

