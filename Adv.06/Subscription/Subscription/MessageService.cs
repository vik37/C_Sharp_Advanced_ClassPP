using System;
using System.Collections.Generic;
using System.Text;

namespace Subscription
{
    public class MessageService
    {
        public void Send(object source, VideoEventArgs args)
        {
            Console.WriteLine($"MessageService: Video: {args.Video.Title} is encoded successfully!");
        }
    }
}
