using Delegate.Entities.Inherite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate.Interface
{
    public interface IStudents
    {
        public Teachers Teacher { get; set; }
        public int Grades { get; set; }
        void ShowGrades();
    }
}
