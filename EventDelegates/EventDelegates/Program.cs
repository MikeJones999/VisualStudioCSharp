using System;
public delegate void ChangedEventHandler();

class EventsExample
{
    public static event ChangedEventHandler windowChanged;

    //function that gets called
    public static void ChangedWindowSize(int height)
    {
        windowChanged += showEventMessage;
        windowChanged.Invoke();
    }

    public static void showEventMessage()
    {
        Console.WriteLine("Window Resized");
    }

    static void Main()
    {
        EventsExample.ChangedWindowSize(int.Parse(Console.ReadLine()));
    }
}