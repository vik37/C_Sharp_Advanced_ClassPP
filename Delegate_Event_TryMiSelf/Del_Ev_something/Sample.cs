using System;
using System.Collections.Generic;
using System.Text;

namespace Del_Ev_something
{
    
     public class Sample
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int GetNum()
        {
            return num;
        }
    }
   
}
