using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegate_Exercise2
{
    public class MessageService
    {
        public void OnVideoEncoded(object source,VideoEventArgs args)
        {
            Console.WriteLine($"Message services: Sending a text message... {args.Video.Title}");
        }
    }
}
