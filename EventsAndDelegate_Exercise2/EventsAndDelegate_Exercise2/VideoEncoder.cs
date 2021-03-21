using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegate_Exercise2
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
       // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoding;

        public event EventHandler<VideoEventArgs> VideoEncoding;
        //public event EventHandler VideoEncoding;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
             if (VideoEncoding != null)
                VideoEncoding(this, new VideoEventArgs() { Video = video});
        }
    }
}
