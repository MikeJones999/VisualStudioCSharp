using System;

namespace EventDelegatesMoreExamplea
{

    public class MailService
    {

        //eventhandler
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mailservice - sending email..." + e.Video.Title);
        }
    }
}