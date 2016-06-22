using System;
using CompServices;

namespace CompServicesLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine(cal.Add(4,5));
            Console.WriteLine(cal.Divide(25, 5));

        }
    }
}
