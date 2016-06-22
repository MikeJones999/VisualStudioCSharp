using System;
using System.Collections.Generic;
using System.IO;


namespace ReadFileFolderStructre
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"C:\data\VSTesting");
            string[] folders = Directory.GetDirectories(@"C:\data\VSTesting");

            foreach (String s in files)
            {
                Console.WriteLine("File {0} is located at {1}", Path.GetFileName(s), Path.GetDirectoryName(s));
            }


            foreach (string s in folders)
            {
                Console.WriteLine("Directory is {0} ", s.ToString());
            }
        }
    }
}
