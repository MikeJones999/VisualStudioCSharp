using System;
using System.Threading;

namespace EventDelegatesMoreExamplea
{
  


    public class VideoEncoder
    {
        //define delegate - determines signature of method     
        public delegate void VideoEncodedEVH(object source, VideoEventArgs args);

        //define event based on above delegate - not instantiated at present
        public event VideoEncodedEVH VideoEncoded;

        //or can just use built in event handler with .net
        //public event EventHandler<VideoEventArgs> VideoEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("***LOG*** Encoding Video...");
            Thread.Sleep(3000);
            //once finished encoding after 3 secs - call onVideoEncoded

            OnVideoEncoded(video);
        }

        //raise the event - method that is responsible for event
        protected virtual void OnVideoEncoded(Video Vid)
        {
            //notify subscribers if it has some - check 
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = Vid });
            }

        }




    }
}
