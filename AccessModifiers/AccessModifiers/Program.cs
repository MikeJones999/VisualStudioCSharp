using System;


namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablet tb = new Tablet(10);
            tb.Read();
            Console.WriteLine(tb.caseColour);    

        }
    }
}
