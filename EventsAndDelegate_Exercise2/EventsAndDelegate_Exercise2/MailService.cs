using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndDelegate_Exercise2
{
    public class MailService
    {
        public void OnVideoEncoded(object source,VideoEventArgs args)
        {
            Console.WriteLine($"Mail Services: Sending an email... {args.Video.Title}");
        }
    }
}
