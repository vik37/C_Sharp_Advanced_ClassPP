using Delegate.Entities.Inherite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate.Helpers
{
    public static class HelperClass
    {
        public static string ReturnSubject(string str,Teachers teacher)
        {
            string subject = teacher.Subject.Where(s => s == str).FirstOrDefault();
            
            return subject;
        }
    }
}
