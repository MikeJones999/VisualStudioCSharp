using System;
using System.Windows.Forms;

class TwoDPoint
{
    private int x, y;

    public TwoDPoint(int xCord, int yCord)
    {
        this.x = xCord;
        this.y = yCord;
    }


    public override bool Equals(object obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }
        else
        {
            TwoDPoint temp = (TwoDPoint)obj;
            return this.x == temp.x && this.y == temp.y;
        }
     
    }

    public override int GetHashCode()
    {
        //xor
        return x ^ y;
    }

}

class Program
{

    static Form form = new Form();
    static TextBox tb1 = new TextBox();
    static TextBox tb2 = new TextBox();
    static Label lbl = new Label();
    static Button btn = new Button();



    public static void Init()
    {
        form.Controls.Add(tb1);
        form.Controls.Add(tb2);
        form.Controls.Add(lbl);
        form.Controls.Add(btn);

        int topPos = 50;
        foreach(Control c in form.Controls)
        {
            c.Left = 50;
            c.Top = topPos;
            topPos += 25;
        }
        btn.Text = "Compare";
        btn.Click += Btn_CLick;
    }

   


    public static void Btn_CLick(object sender, EventArgs e)
    {
        Console.WriteLine("button clicked");

        if (tb1.Text != "" || tb2.Text !)
        {

            String[] first = tb1.Text.Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
            String[] second = tb2.Text.Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);

            int p1x = int.Parse(first[0]);
            int p1y = int.Parse(first[1]);

            int p2x = int.Parse(second[0]);
            int p2y = int.Parse(second[1]);

            TwoDPoint p1 = new TwoDPoint(p1x, p1y);
            TwoDPoint p2 = new TwoDPoint(p2x, p2y);
            lbl.Text = p1.Equals(p2).ToString();
        }
        else
        {
            lbl.Text = "Enter coordinates";
        }

    }


    static void Main()
    {
        Init();
        Application.Run(form);
    }
}
