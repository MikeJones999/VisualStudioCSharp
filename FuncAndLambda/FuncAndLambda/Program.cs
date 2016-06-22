using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAndLambda
{
    class Program
    {

        public static Func<dynamic, dynamic, int, dynamic> Add = (x, y, round) => Math.Round(x + y, round);


        static void Main(string[] args)
        {
            Console.WriteLine(Add(3.8,5.6,2));

        }
    }
}
