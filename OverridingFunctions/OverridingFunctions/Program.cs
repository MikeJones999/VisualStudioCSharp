using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1, 2, 3);
            Vector v2 = new Vector(2, 3, 4);
            Vector res = v1 + v2;
            Console.WriteLine(res);

        }
    }


    class Vector
    {
        private double x, y, z;
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public override string ToString()
        {
            return "<" + x + "," + y + "," + z + ">";
        }

    }



}
