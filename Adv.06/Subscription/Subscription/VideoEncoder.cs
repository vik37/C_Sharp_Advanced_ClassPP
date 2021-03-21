using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Subscription
{
    public class VideoEventArgs : EventArgs
    {
       public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // define delagate
        // define event based on that delegate
        // raise the event

        public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);
        public event VideoEncoderEventHandler VideoEncodedEventHandler;

        // EventHandler - return type = void, (object sender, EventArgs args)
        // EventHandler<TEventArgs> - return type = void, (object sender, TEventArgs args)

        //public EventHandler EncodeVideo;
        //public EventHandler<TEventArgs> EncodeVideoGeneric;

        // EventHandler
        // EventHandler<TEventArgs>

        //public event EventHandler<VideoEventArgs> VideoEncoded;
        //public event EventHandler VideoEncoded;

        //public event EventHandler<VideoEventArgs> VideoEncodedEventHandler;
        public void Encode(Video video)
        {
            // encoding logic

            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncodedEventHandler?.Invoke(this, new VideoEventArgs() { Video = video });
        }
    }
}
