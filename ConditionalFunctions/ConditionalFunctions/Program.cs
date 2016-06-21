using System;
using System.Diagnostics;

class Trace
{
    #region
    [Conditional ("DEBUG")]
    public static void Message(String traceMessage)
    {
        Console.WriteLine("Trace: " + traceMessage);
    }
    #endregion


}

namespace ConditionalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Message("Main function is starting");
            if(args.Length==0)
            {
                Console.WriteLine("No Arguments have been passed");
            }
            else
            {
                for(int i=0; i< args.Length; i++)
                {
                    Console.WriteLine("arg[" + i + "] is [" + args[i] + "]");
                }
            }
            Trace.Message("Main has now completed");

        }
    }
}
