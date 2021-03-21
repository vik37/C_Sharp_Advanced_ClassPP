using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Subsription_Model
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        public delegate void VideoEncodeEventHandler(object Source, VideoEventArgs args);
        public event VideoEncodeEventHandler VideoEncodedEventHandler;
        public void Encode(Video video)
        {
            //MailService.Send(new Mail())
            //MessageService.Send();
            // onVideoEncoded()
            
            Console.WriteLine($"Encoding Video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncodedEventHandler != null)
            {
                VideoEncodedEventHandler(this,new VideoEventArgs() {Video = video });
            }
        }
    }
}
