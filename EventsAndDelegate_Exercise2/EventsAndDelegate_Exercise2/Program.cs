using System;

namespace EventsAndDelegate_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncode = new VideoEncoder();  // PUBLISHER - izdavac

            var mailService = new MailService(); //SUBSCRIBER - pretplatnik

            videoEncode.VideoEncoding += mailService.OnVideoEncoded;

            var messageService = new MessageService();
            videoEncode.VideoEncoding += messageService.OnVideoEncoded;



            videoEncode.Encode(video);
            Console.ReadLine();
        }
    }
}
