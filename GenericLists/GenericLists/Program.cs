using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLists
{
    class Program
    {
        static void Case(string p)
        {
            Console.WriteLine(p.ToLower());
        }

        static void Main()
        {
            Console.WriteLine("enter a list of animals");
            List<string> myWords = new List<string>();
            string s = Console.ReadLine();
            while (s != "Exit")
            {
                myWords.Add(s);
                s = Console.ReadLine();
            }

            myWords.ForEach(x => Case(x));

            Console.WriteLine("***************");
            myWords.ForEach(Case);
            myWords.Reverse();
            myWords.ForEach(Case);

            Console.WriteLine("***************");
            foreach (String str in myWords)
            {
                Console.WriteLine("Animal: " + str);
            }
        }
    }
}
