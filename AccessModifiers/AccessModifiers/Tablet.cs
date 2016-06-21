using System;

    class Tablet: ComputingDevice
    {
        private int screenSize;

        public Tablet(int size)
        {
            screenSize = size;
        }

    public string caseColour
    {
        get { return base.caseColour; }
    }

    public override void Read()
    {
        Console.WriteLine("Reading finger trace");
    }


}

