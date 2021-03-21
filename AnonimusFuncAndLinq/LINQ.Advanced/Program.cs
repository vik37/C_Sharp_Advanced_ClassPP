using LINQ.Advanced.Entities;
using LINQ.Advanced.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Students> sqlStudents = from x in SEDC.Students
                                                where x.FirstName == "Bill"
                                                select x;
            

            foreach (var item in sqlStudents)
            {
                Console.WriteLine(item.FirstName);
            }
           

            Console.ReadLine();
        }
    }
}
