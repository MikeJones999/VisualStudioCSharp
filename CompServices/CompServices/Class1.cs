using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompServices
{
    public class Calculator
    {
        public dynamic Add(dynamic x, dynamic y)
        {
            return x + y;
        }

        public dynamic Divide(dynamic x, dynamic y)
        {
            return y != 0 ? x / y : 0;
        }
    }
}
