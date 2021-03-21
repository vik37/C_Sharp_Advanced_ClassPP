using QuizzProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzProject.Interface
{
    public interface ITeachers
    {
        List<Students> students { get; set; }

        void ShowStudents();
    }
}
