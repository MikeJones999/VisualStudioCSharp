using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaces
{
    class Document : IEquatable<Document>
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public bool Equals(Document other)
        {
            
            if (other != null && other.text.Equals(this.text))
                return true;
            else return false;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Document d1, d2;
            Console.WriteLine("enter text one: ");
            d1 = new Document();
            d2 = new Document();
            d1.Text = Console.ReadLine();
            Console.WriteLine("enter text two: ");
            d2.Text = Console.ReadLine();

            if(d1.Equals(d2))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
;        }
    }
}
