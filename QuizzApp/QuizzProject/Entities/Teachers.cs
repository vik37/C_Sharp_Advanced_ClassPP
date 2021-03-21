using QuizzProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using QuizzProject.Enums;
using System.Text;

namespace QuizzProject.Entities
{
    public class Teachers : User, ITeachers
    {
        public List<Students> students { get; set; }
        public Teachers()
        {
            students = new List<Students>();
            userEntitie = UserEntities.Teacher;
        }

        public override string ShowInfo()
        {
            return $"    -    {userEntitie}    -    \nID = {Id} | User name = {Username} | ";
        }

        public void ShowStudents()
        {
            foreach (var item in students)
            {
                Console.WriteLine($"NAME: {item.Username}");

            }
        }
    }
}
