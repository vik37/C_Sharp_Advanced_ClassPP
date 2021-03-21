using System;

namespace Subsription_Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video() { Title = "Video_01" };
            VideoEncoder videoEncoder = new VideoEncoder();            
            var mailService = new MailService();
            var messageService = new MessageService();
            videoEncoder.VideoEncodedEventHandler += mailService.Send;
            videoEncoder.VideoEncodedEventHandler += messageService.Send;
            videoEncoder.Encode(video);
            Console.ReadLine();
        }
    }
}
