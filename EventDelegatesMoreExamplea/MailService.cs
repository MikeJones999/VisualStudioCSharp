namespace EventDelegatesMoreExamplea
{

    public class MailService
    {

        //eventhandler
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Mailservice - sending email...");
        }
    }
}