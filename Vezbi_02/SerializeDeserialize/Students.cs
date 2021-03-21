using System;
using System.Collections.Generic;
using System.Text;

namespace SerializeDeserialize
{
    public class Students
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public List<string> Subject { get; set; }
        public Students()
        {
            Subject = new List<string>();
        }
    }
}
