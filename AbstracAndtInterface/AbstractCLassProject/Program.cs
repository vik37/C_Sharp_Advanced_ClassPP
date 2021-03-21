using AbstractCLassProject.Entities;
using System.Collections.Generic;
using System;
using System.Linq;

namespace AbstractCLassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Developer("Viktor Zafirovski", 38, 077252525,new List<string>{"HTML","CSS","JavaScript","C-Sharp" },4);
           Developer dev = new Developer("Aleksandra Hristovska",24,071666927,new List<string> { "HTML","CSS","JavaScript","PHP"},2);

            human.Greet("Viktor");
            

            dev.Greet("Aleksandra");
            dev.Code();
            QAEngineer eng = new QAEngineer("Petar Pan",42,078555444,new List<string> { ".Net ","Ract","Angular","Bootrstrap"});
            eng.TestFeature("something");
            eng.Code();
            eng.Greet("ANA");

            Console.ReadLine();
        }
    }
}
