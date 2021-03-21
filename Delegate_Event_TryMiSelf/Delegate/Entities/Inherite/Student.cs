using Delegate.Helpers;
using Delegate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate.Entities.Inherite
{
    public class Student : User,IStudents
    {
        public Teachers Teacher { get; set; }
        public int Grades { get; set; }

        public override void ShowAllUsers()
        {
            Console.WriteLine($"Student: Id = {Id} | Full Name {UserName} ");
        }

        public void ShowGrades()
        {
            //var sub = HelperClass.ReturnSubject()
            //var sub = Teacher.Subject.SingleOrDefault(s => s == choiceSub);
            Console.WriteLine($"Subject - ");
        }
    }
}
