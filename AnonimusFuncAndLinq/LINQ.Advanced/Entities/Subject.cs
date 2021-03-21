using System;
using System.Collections.Generic;
using System.Text;
using LINQ.Advanced.Enum;

namespace LINQ.Advanced.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Modules { get; set; }
        public int StudentsAttending { get; set; }
        public Academy Type { get; set; }
        public Subject(int id, string title, int modules, int students, Academy type)
        {
            Id = id;
            Title = title;
            Modules = modules;
            StudentsAttending = students;
            Type = type;
        }
    }
}
