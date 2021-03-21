using System;
using System.Collections.Generic;
using System.Text;

namespace SerializeDeserialize
{
    public class SaveClasses
    {
        public List<Students> Students { get; set; }
        public Students students;
        public SaveClasses()
        {
            Students = new List<Students>();
        }

        public List<Students> ReturnStudents(Students student)
        {
            Students.Add(student);

            return Students;
        }
    }
}
