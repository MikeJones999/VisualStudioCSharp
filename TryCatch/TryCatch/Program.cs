using System;
using System.Windows.Forms;

class Programm
{
    private static Form form = new Form();
    private static Label lbl = new Label();
    private static Button btn = new Button();
    private static TextBox tb1 = new TextBox();
    private static TextBox tb2 = new TextBox();


    public static void setComps()
    {
        //add buttons, labels etc to the actual form - held in a collection
        form.Controls.Add(btn);
        form.Controls.Add(tb1);
        form.Controls.Add(tb2);
        form.Controls.Add(lbl);

        int topPos = 50;
        foreach(Control c in form.Controls)
        {
            c.Left = 50;
            c.Top = topPos;
            topPos += 50;
        }
        //.Click is an eventhandler
        btn.Click += Btn_Click;
        //autosize - text in label is not cut off - wrap around almost
        lbl.AutoSize = false;
        lbl.MaximumSize = new System.Drawing.Size(160, 0);
        lbl.AutoSize = true;
        btn.Text = "Add";

    }

    //when button is clicked - eventhandler
    static void Btn_Click(object sender, EventArgs e)
    {
        try
        {
            lbl.Text = (double.Parse(tb1.Text) + double.Parse(tb2.Text)).ToString() + "\n";
        }
        catch (FormatException ex)
        {
            lbl.Text = ex.Message;
        }
        finally
        {
            lbl.Text += " Your input has been processed" + "\n";
        }
    }

    static void Main()
    {
        setComps();
        Application.Run(form);
    }

}
