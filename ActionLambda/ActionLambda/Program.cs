using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Utils
{
    public static void Print(string s)
    {
        Console.WriteLine(s);
    }

    public static void ReversePrint(string s)
    {
     
        for(int i = s.Length-1; i>=0; i--)
        {
           Console.Write(s.Substring(i, 1));
        }
        Console.WriteLine();
    }
}


    class Program
    {
        static void Main(string[] args)
        {
        //dont have return types - only void
        Action<string> PrintIt = Utils.Print;
        Action<string> ReverseIt = Utils.ReversePrint;
        List<string> ls = new List<string>();
        ls.Add("dog");
        ls.Add("cat");
        ls.Add("mouse");
        ls.ForEach(ReverseIt);
        ls.ForEach(PrintIt);
        //lambda streams
        ls.ForEach(x => Console.WriteLine("** " + x));
        }
    }



