using System;
using System.Collections.Generic;
using System.Text;

namespace Subsription_Model
{
    public class MessageService
    {
        public void Send(object source, VideoEventArgs args)
        {
            Console.WriteLine($"Message Servise: Video: {args.Video.Title} is encoded sucessfully");
        }
    }
}
