using System;

namespace Subscription
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 01" };
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            var messageService = new MessageService();
            videoEncoder.VideoEncodedEventHandler += mailService.Send;
            videoEncoder.VideoEncodedEventHandler += messageService.Send;
            videoEncoder.Encode(video);
            
        }
    }
}
