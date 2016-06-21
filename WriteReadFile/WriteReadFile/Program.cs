using System;

using System.IO;

class Program
{

   
    static void Main()
    {

        readFile();
       // StreamWriter sw = new StreamWriter(@"C:\Users\jonesm9\Documents\Visual Studio 2015\SampleText.txt");

        try
        { 
        //{
        //    Console.WriteLine("enter something");
        //    sw.Write(Console.ReadLine());
        //    sw.Close();

            //StreamReader sr = new StreamReader(@"C:\Users\jonesm9\Documents\Visual Studio 2015\SampleText.txt");
            //Console.WriteLine(sr.ReadLine());
            //sr.Close();
        }
        finally
        {
           
        }

   }
       static void readFile()
        {
        string line = "";
        StreamReader sr = new StreamReader(@"C:\Users\jonesm9\Documents\Visual Studio 2015\SampleText.txt");
        while((line = sr.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
        sr.Close();

        }

}