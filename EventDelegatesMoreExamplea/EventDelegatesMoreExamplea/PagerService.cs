using System;


namespace EventDelegatesMoreExamplea
{
    class PagerService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Pager Service: sending page..." + e.Video.Title);
        }

    }
}
