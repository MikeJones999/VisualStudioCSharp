using System;

delegate double Multiply(double x, double y);
delegate double CompareFirstTwo(double x, double y);

class Program
{

    static void Main()
    {
        Multiply mult = (x, y) => (x * y);
        Console.WriteLine(mult(4,6));

        CompareFirstTwo cft = (xin, yin) =>
        {
            double x = xin;
            double y = yin;
            return x > y ? x : y;
        };

        Console.WriteLine("comapre 4 and 6 - biggest is: " + cft(4, 6));
        Console.WriteLine("comapre 10 and 6 and 7- biggest is: " + CompareThird( cft, 10) );
    }

    private static double CompareThird(CompareFirstTwo cf, double x)
    {
        return x > cf(6,7) ? x : cf(6,7);
    }
}