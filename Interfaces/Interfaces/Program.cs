using System;


namespace Interfaces
{

    interface ISaveable
    {
        void SaveToPdf();
        void SaveToWorld();
    }


    class Invoice : ISaveable
    {

        private object[] details;

        public Invoice(object[] dets)
        {
            this.details = dets;
        }

        public void SaveToPdf()
        {
            Console.WriteLine("Saving to Pdf");
        }

        public void SaveToWorld()
        {
            Console.WriteLine("Saving to World");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Invoice iv = new Invoice(new object[]{"garbage", 4500M});
            iv.SaveToPdf();

        }
    }
}
