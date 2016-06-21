using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegatesMoreExamplea
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var messageService = new MessageService();
            var mailService = new MailService(); //subscriber
            var pagerService = new PagerService();

            //instantiating/ adding one to the VideoEncoded Event Handler
                                            //pointer to methods
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            //add another subscriber to VideoEncoded
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            //add another subscriber to the VideoEncoded evh
            videoEncoder.VideoEncoded += pagerService.OnVideoEncoded;





            videoEncoder.Encode(video);

        }
    }

  

}
