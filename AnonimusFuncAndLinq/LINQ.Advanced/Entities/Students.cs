using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Advanced.Entities
{
    public class Students
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsPartTime { get; set; }
        public List<Subject> Subjects { get; set; }
        public Students()
        {

        }
        public Students(int id,string firstNAme, string lastName, int age,bool isPartTime)
        {
            Id = id;
            FirstName = firstNAme;
            LastName = lastName;
            Age = age;
            IsPartTime = isPartTime;
        }

       
    }
}
