using System;
using System.Collections.Generic;
using System.Text;

namespace Subscription
{
    public class MailService
    {
       public void Send(object source, VideoEventArgs args)
       {
            Console.WriteLine($"MailService: Video: {args.Video.Title} is encoded successfully!");
       }

    }
}
