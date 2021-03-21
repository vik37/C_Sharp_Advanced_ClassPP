using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    public delegate bool IsPromotable(Employee emp);
    public class Employee
    {
        
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public static void PromtOfEmployee(List<Employee> employeeList,IsPromotable isEligPromotable)
        {
            foreach (var employee in employeeList)
            {
                if(isEligPromotable(employee))
                {
                    Console.WriteLine($"{employee.Name} is promoted");
                }
            }
        }
    }
}
