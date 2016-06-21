using System;


namespace EventDelegatesMoreExamplea
{
    class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Message Service: Sending text message..." + e.Video.Title);
        }

    }
}
