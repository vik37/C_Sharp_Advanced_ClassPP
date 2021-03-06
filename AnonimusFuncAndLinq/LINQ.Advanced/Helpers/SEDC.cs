using LINQ.Advanced.Entities;
using System;
using System.Collections.Generic;
using LINQ.Advanced.Enum;
using System.Text;

namespace LINQ.Advanced.Helpers
{
    public static class SEDC
    {
        public static List<Students> Students = new List<Students>()
    {
        new Students(12, "Bob", "Bobsky", 29, false),
        new Students(22, "Jill", "Wayne", 36, true),
        new Students(27, "Greg", "Gregsky", 45, false),
        new Students(29, "Anne", "Willson", 31, true),
        new Students(30, "Liana", "Wurtz", 25, false),
        new Students(41, "Bill", "Zu", 38, false)
    };
        public static List<Subject> Subjects = new List<Subject>()
    {
        new Subject(15, "C# Basic", 10, 24, Academy.Programming ),
        new Subject(16,"C# Advanced", 15, 26, Academy.Programming ),
        new Subject(44, "JavaScript", 25, 22, Academy.Programming ),
        new Subject(67, "Photoshop", 12, 18, Academy.Design ),
        new Subject(88, "Illustrator", 12, 18, Academy.Design ),
        new Subject(97,"Networks Basic", 8, 12, Academy.Network ),
        new Subject(98, "Networks Advanced", 16, 10, Academy.Network )
    };
        static SEDC()
        {
            Students[0].Subjects = new List<Subject>() { Subjects[0], Subjects[2], Subjects[3], Subjects[4] };
            Students[1].Subjects = new List<Subject>() { Subjects[3], Subjects[4], Subjects[5], Subjects[1] };
            Students[2].Subjects = new List<Subject>() { Subjects[5], Subjects[6] };
            Students[3].Subjects = new List<Subject>() { Subjects[3], Subjects[4] };
            Students[4].Subjects = new List<Subject>() { Subjects[1], Subjects[2], Subjects[3], Subjects[5] };
            Students[5].Subjects = new List<Subject>() { Subjects[2] };
        }
    }
}
