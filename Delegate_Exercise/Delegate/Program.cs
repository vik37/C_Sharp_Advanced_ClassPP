using System;
using System.Collections.Generic;

namespace Delegate
{
    class Program
    {
        public delegate void HelloFunctionDelegate(string message);
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(SayHallo);
            del("Hello from delegate");

            List<Employee> empList = new List<Employee>()
            {
                new Employee(){Id = 1,Name = "Vanco",Experience = 4,Salary = 1200},
                new Employee(){Id = 2,Name = "Viktor",Experience = 1,Salary = 800},
                new Employee(){Id = 3,Name = "Vaska",Experience = 8,Salary = 10000},
            };
            empList.Add(new Employee() { Id = 4, Name = "Hristo", Experience = 20, Salary = 1600 });
            empList.Add(new Employee() { Id = 5, Name = "Krsto", Experience = 26, Salary = 16500 });

            //IsPromotable isPromote = new IsPromotable(Promote);
           // Employee.PromtOfEmployee(empList,isPromote);
            Employee.PromtOfEmployee(empList, emp => emp.Experience >= 5);
            Console.ReadLine();
        }
        //public static bool Promote(Employee emp)
        //{
        //    if(emp.Experience >= 5)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}
        public static void SayHallo(string message)
        {
            Console.WriteLine(message);
        }
    }
}
