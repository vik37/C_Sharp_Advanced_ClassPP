using Struct.Entities;
using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress("Finska", 178);
            // Address address = new Address() { Street = "Bob Street", Number = 11 }; // This also works
            User user = new User("Viktor", 38, adress);
            // User bob = new User() { Username = "BobBest", Age = 21, Address = address }; // This does not work
            Console.WriteLine(user.GetInfo());
            Console.WriteLine(adress.GetFullAddress());
            Adress newAddress = adress;
            newAddress.Number = 50;
            newAddress.Street = "New Street";
            User bobTwin = user;
            bobTwin.UserName = "BobSuper";
            bobTwin.Age = 45;
            Console.WriteLine("----------after changes-----------");
            Console.WriteLine(user.GetInfo());
            Console.WriteLine(adress.GetFullAddress());
            Console.WriteLine("====================================================");

            int score = 95;
            int score2 = score;
            
            Console.WriteLine($"score = {score}, score 2 = {score2}");
            Report report = new Report()
            {
                Title = "First Report",
                Desc = "This is the first report",
                Pages = 11
            };
            Report report2 = report;
            Console.WriteLine(report.Display());
            Console.WriteLine(report2.Display());

            report2.Pages = 999;
            Console.WriteLine(report.Display());
            Console.WriteLine(report2.Display());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Score = {score}");
            Console.WriteLine($"Object Pages = {report.Pages}");
            ProccessIt(score, report);
            Console.WriteLine($"Score = {score}");
            Console.WriteLine($"Object Pages = {report.Pages}");
            Console.ReadLine();
        }
        static void ProccessIt(int s, Report r)
        {
            s = 111;
            r.Pages = 1111;
        }
    }
    public struct Report
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public int Pages { get; set; }
        public string Display()
        {
            return String.Format("{0}: {1}: pp. {2}", Title, Desc, Pages);
        }
    }
}
