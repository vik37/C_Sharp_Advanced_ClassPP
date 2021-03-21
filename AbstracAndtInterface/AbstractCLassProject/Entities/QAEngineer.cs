using AbstractCLassProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractCLassProject.Entities
{
    public class QAEngineer : Human, IDeveloper,ITester
    {
        public List<string> TestingFrameworks { get; set; }
        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - Knows {(TestingFrameworks.Count != 0 ? TestingFrameworks[0] : "unknown")} testing frameworks!";
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak...");
            Console.WriteLine("Open StackEchange SQA...");
            Console.WriteLine("tak tak tak tak tak...");
        }

        public void TestFeature(string feature)
        {
            Console.WriteLine("Run Unit Tests...");
            Console.WriteLine("Run Automated Tests...");
            Console.WriteLine($"Tests for the {feature} feature are done!");
        }

        public QAEngineer(string fullname, int age, long phone,List<string> tastingFrameworks)
             : base(fullname, age, phone)
        {
            TestingFrameworks = tastingFrameworks;
        }
    }
}
