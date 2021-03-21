﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractCLassProject.Entities
{
    public class Developer : Human
    {
        public List<string> ProgrammingLanguages { get; set; } = new List<string>();
        public int YearsExperience { get; set; }
        public void Code()
        {
            Console.WriteLine("tak tak tak...");
            Console.WriteLine("*Opens Stack Overflow...");
            Console.WriteLine("tak tak tak tak tak...");
        }
        public Developer(string fullname, int age, long phone, List<string> languages, int experience)
            : base(fullname, age, phone)
        {
            ProgrammingLanguages = languages;
            YearsExperience = experience;
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - {YearsExperience} years of experience!";
        }
    }
}
