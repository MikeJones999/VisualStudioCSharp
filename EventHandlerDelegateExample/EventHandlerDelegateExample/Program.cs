using System;
namespace SimpleEvent
{
    using System;

    public class EventTest
    {
        private int value;
        public delegate void NumManipulationHandler();
        public event NumManipulationHandler ChangeNum;
        protected virtual void OnNumChanged()
        {
            if (ChangeNum != null)
            {
                Console.WriteLine("Event NOT fired!");
                ChangeNum();
            }
            else
            {
                ChangeNum();
                Console.WriteLine("Event fired!");
            }
        }

        public EventTest(int n)
        {
            SetValue(n);
        }

        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                OnNumChanged();
            }
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            EventTest e = new EventTest(5);
            e.SetValue(7);
            e.SetValue(11);
            Console.ReadKey();
        }
    }
}