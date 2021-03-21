using Delegate.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate.Entities.Inherite
{
    public class Teachers : User, ITeacher
    {
        public Student Student { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> Subject { get; set; }

        public override void ShowAllUsers()
        {
            Console.WriteLine($"Teacher: Id = {Id} | Full Name {UserName} ");
        }

        public void ShowSubject()
        {
            
            Subject.ForEach(s => Console.WriteLine(s));
        }
    }
}
