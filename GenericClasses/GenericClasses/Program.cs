using System;

class GenericSwapper<T>
{
    public T x;
    public T y;

    public GenericSwapper(T val1, T val2)
    {
        this.x = val1;
        this.y = val2;
    }


    public void Switch()
    {
        T temp = this.x;
        this.x = this.y;
        this.y = temp;
    }

}

class SwapUser
{
    static void Main()
    {
        GenericSwapper<string> gs = new GenericSwapper<string>("hello", "world");
        Console.WriteLine("{0}, {1}", gs.x, gs.y);
        gs.Switch();
        Console.WriteLine("{0}, {1}", gs.x, gs.y);

        GenericSwapper<Double> gs1 = new GenericSwapper<double>(2, 10);
        Console.WriteLine("{0}, {1}", gs1.x, gs1.y);
        gs1.Switch();
        Console.WriteLine("{0}, {1}", gs1.x, gs1.y);
    }
}