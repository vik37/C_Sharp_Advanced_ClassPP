using QuizzProject.Interface;
using QuizzProject.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using QuizzProject.Services;

namespace QuizzProject.Entities
{
    
    public class Students : User, IStudents
    {
        public int _grades;

        public bool IsItFinished { get; set; }

        public Students()
        {
            userEntitie = UserEntities.Student;                       
        }

        public override string ShowInfo()
        {
            SetGrades();
            return $"    -   {userEntitie}    -    \nID: {Id} | User Name {Username} | Grade: {_grades}  |  "; 
        }

        public int SetGrades()
        {
            if(Validation.Points > 1 && Validation.Points < 5)
            {
                return _grades = 1;
            }
            else if(Validation.Points >= 5 && Validation.Points < 9)
            {
                return _grades = 2;
            }
            else if (Validation.Points >= 9 && Validation.Points < 14)
            {
                return _grades = 3;
            }
            else if (Validation.Points >= 14 && Validation.Points < 18)
            {
                return _grades = 4;
            }
            else if (Validation.Points >= 18 && Validation.Points <= 21)
            {
                return _grades = 5;
            }
            else
            {
                if(Validation.Points > 21)
                    return _grades = 0;
            }
            return _grades = 0;
        }

        public bool SetIsFinishedTest()
        {
            if (_grades == 0) return IsItFinished = false;

            return IsItFinished = true;
        }  
    }
}
