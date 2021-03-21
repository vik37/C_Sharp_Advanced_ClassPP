using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonimus
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> names = new List<string>()
            //{
            //    "Bob", "Jill", "Wayne", "Greg", "John", "Anne"
            // };
            //string foundBob = names.Find(x => x == "Bob");

            //List<string> empty = new List<string>();
            //Func<bool> isNamesEmpty = () => names.Count == 0;
            //Console.WriteLine($"IsNamesEmpty: {isNamesEmpty()}");
            List<Employee> listEmployee = new List<Employee>()
            {
                new Employee(){Id = 101,Name = "Mark"},
                new Employee(){Id = 102,Name = "John"},
                new Employee(){Id = 103,Name = "Mary"}
            };
            Func<Employee, string> selector = employee => "Name = " + employee.Name;
            IEnumerable<string> names = listEmployee.Select(selector);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
