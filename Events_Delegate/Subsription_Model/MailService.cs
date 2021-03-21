using System;
using System.Collections.Generic;
using System.Text;

namespace Subsription_Model
{
    public class MailService
    {
        public void Send(object source,VideoEventArgs args)
        {
            Console.WriteLine($"Mail Service: Video: {args.Video.Title} is encoded succesifully");
        }
      
    }
}
