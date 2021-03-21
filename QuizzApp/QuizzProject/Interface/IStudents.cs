using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzProject.Interface
{
    public interface IStudents
    {
        public bool IsItFinished { get; set; }
        int SetGrades();
        bool SetIsFinishedTest();

    }
}
