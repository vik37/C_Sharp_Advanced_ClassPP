
using System;
using System.Collections.Generic;
using System.Linq;
using QuestonsAndAnware;
using QuestonsAndAnware.Services;
using QuizzProject.DB;
using QuizzProject.Entities;
using QuizzProject.Enums;
using QuizzProject.Services;

namespace QuizzProject
{
    class Program
    {
        public static LocalDb<Students> studentDb = new LocalDb<Students>();
        public static LocalDb<Teachers> teachersDb = new LocalDb<Teachers>();
        public delegate int GetPoints(int quest,int numOne, int point);
        static void Main(string[] args)
        {
            studentDb.insert(new Students() { Username = "Bravo", Password = "123456",IsItFinished = false });
            studentDb.insert(new Students() { Username = "Marko", Password = "Polo_2",IsItFinished = false });
            studentDb.insert(new Students() { Username = "Greta", Password = "2_pe_3",IsItFinished = true });
            studentDb.insert(new Students() { Username = "Goce", Password = "Plav1", IsItFinished = false });
            studentDb.insert(new Students() { Username = "Marija", Password = "2020", IsItFinished = false });
            studentDb.insert(new Students() { Username = "Rambo", Password = "karpos4", IsItFinished = true });
            studentDb.insert(new Students() { Username = "Baraka", Password = "123_M", IsItFinished = false });
            studentDb.insert(new Students() { Username = "Margarita", Password = "Stef_anovska", IsItFinished = true });
            studentDb.insert(new Students() { Username = "Gajba", Password = "sto_le", IsItFinished = true });
           
            GetPoints getPoin = new GetPoints(Validation.ReturnPoints);
 
            Questions questions = new Questions();

            RegisServices<Students> registerStudent = new RegisServices<Students>();
            RegisServices<Teachers> registerTeacher = new RegisServices<Teachers>();

            
            Console.WriteLine("ENTER: 1 - student | 2 - teacher");
            int num;
            
            bool isItSTudentOrTeacher = int.TryParse(Console.ReadLine(), out num);
            if(isItSTudentOrTeacher && num == 1)
            {
                Students studentOne = new Students();
             logs:
                Console.WriteLine("Register: Press 1, Log in Press 2");
                int logNum;
                bool isItRegister = int.TryParse(Console.ReadLine(), out logNum);
                if (isItRegister && logNum == 1)
                {
                    
                    string username;
                    string password;
                    bool IsLessThen = true;
                    while (IsLessThen)
                    {
                        Console.WriteLine("- REGISTER -");
                        Console.WriteLine("=========================");
                        Console.WriteLine("Enter UserName");
                        username = Console.ReadLine().Trim();
                        Console.WriteLine("Enter Password");
                        password = Console.ReadLine().Trim();

                        IsLessThen = Validation.IsStringLessThen(username, password);
                        if (IsLessThen == false) 
                        {
                            registerStudent.Register(username, password, studentOne);
                            studentDb.insert(studentOne);                           
                            goto logs;
                        }                       
                    }
                }
                else if(isItRegister && logNum == 2)
                {
                    
                    Console.WriteLine("- LOG IN -");
                    Console.WriteLine("=========================");
                    string username;
                    string password;
                    Console.WriteLine("Enter UserName");
                    username = Console.ReadLine().Trim();
                    Console.WriteLine("Enter Password");
                    password = Console.ReadLine().Trim();
                    registerStudent.LogIn(username, password, studentOne);
                    var student10 = studentDb.GetById(10);
                    Console.ResetColor();
                    Console.WriteLine("   PRESS ENTER: \n - START TEST -");
                    Console.WriteLine("=========================");
                    Console.ReadLine();

                    Console.WriteLine(" QUESTION 1");
                    Console.WriteLine("____________________");
                    ExamQuestions.ShowQuestions(0, 1);

                    Console.WriteLine("-------------------------");
                    Console.Write(" Answare: ");                    
                    getPoin(1, int.Parse(Console.ReadLine()), 2);
                    Console.WriteLine("-------------------------");
                    Console.ReadLine();

                    Console.WriteLine(" QUESTION 2");
                    Console.WriteLine("____________________");
                    ExamQuestions.ShowQuestions(1, 2);

                    Console.WriteLine("-------------------------");
                    Console.Write(" Answare: ");
                    getPoin(2, int.Parse(Console.ReadLine()), 7);
                    Console.WriteLine("-------------------------");
                    Console.ReadLine();

                    Console.WriteLine(" QUESTION 3");
                    Console.WriteLine("____________________");
                    ExamQuestions.ShowQuestions(2, 3);

                    Console.WriteLine("-------------------------");
                    Console.Write(" Answare: ");
                    getPoin(3, int.Parse(Console.ReadLine()), 4);
                    Console.WriteLine("-------------------------");
                    Console.ReadLine();

                    Console.WriteLine(" QUESTION 4");
                    Console.WriteLine("____________________");
                    ExamQuestions.ShowQuestions(3, 4);

                    Console.WriteLine("-------------------------");
                    Console.Write(" Answare: ");
                    getPoin(4, int.Parse(Console.ReadLine()), 5);
                    Console.WriteLine("-------------------------");
                    Console.ReadLine();

                    Console.WriteLine(" QUESTION 5");
                    Console.WriteLine("____________________");
                    ExamQuestions.ShowQuestions(4, 5);

                    Console.WriteLine("-------------------------");
                    Console.Write(" Answare: ");
                    getPoin(5, int.Parse(Console.ReadLine()), 3);
                    Console.WriteLine("-------------------------");
                    Console.ReadLine();

                    Console.WriteLine("TEST END");
                    Console.WriteLine("Thank you about your time and finished the test");
                    Messages.ShowMessages($"Points = {Validation.Points}", ConsoleColor.Yellow);
                   
                    Messages.ShowMessages(student10.ShowInfo(), ConsoleColor.DarkCyan);
                    Console.ResetColor();
                    Console.WriteLine("++++++++++++++++++++++++++++++++");
                    Console.WriteLine("TRUE ANSWARES");
                    Validation.FirstAnsware(questions);
                    Console.WriteLine("-------------------------");
                    Console.BackgroundColor = ConsoleColor.White;
                    Messages.ShowMessages("LOG OUT", ConsoleColor.DarkMagenta);
                    Console.ResetColor();
                    
                }
                else
                {
                    Messages.ShowMessages("ERROR - Incorect input", ConsoleColor.Red);
                }                              
            }
            else if(isItSTudentOrTeacher && num == 2)
            {
            
                Teachers teacherOne = new Teachers();
            logs:
                
                Console.WriteLine("Register: Press 1, Log in Press 2");
                int logNum;
                bool isItRegister = int.TryParse(Console.ReadLine(), out logNum);
                if (isItRegister && logNum == 1)
                {
                
                    string username;
                    string password;
                    bool IsLessThen = true;
                    while (IsLessThen)
                    {
                        Console.WriteLine("- REGISTER -");
                        Console.WriteLine("=========================");
                        Console.WriteLine("Enter UserName");
                        username = Console.ReadLine().Trim();
                        Console.WriteLine("Enter Password");
                        password = Console.ReadLine().Trim();

                        IsLessThen = Validation.IsStringLessThen(username, password);
                        if (IsLessThen == false)
                        {
                            registerTeacher.Register(username, password, teacherOne);
                            teachersDb.insert(teacherOne);
                            goto logs;
                        }
                    }
                }
                else if (isItRegister && logNum == 2)
                {

                    Console.WriteLine("- LOG IN -");
                    Console.WriteLine("=========================");
                    string username;
                    string password;
                    Console.WriteLine("Enter UserName");
                    username = Console.ReadLine().Trim();
                    Console.WriteLine("Enter Password");
                    password = Console.ReadLine().Trim();
                    registerTeacher.LogIn(username, password, teacherOne);
                    var teacher1 = teachersDb.GetById(1);
                    teacherOne.students.AddRange(studentDb.GetAll());
                    Console.WriteLine(teacher1.ShowInfo());
                    Console.ResetColor();
                    Console.WriteLine("============================");
                    Console.WriteLine("Your students");
                    teacher1.ShowStudents();
                    Console.WriteLine("Do you want see wich and how many finished queez? Y/N");
                    char yesNo = char.Parse(Console.ReadLine().ToUpper().Trim());
                    
                    if(yesNo == 'Y')
                    {
                        var std = studentDb.GetAll();
                        Validation.PrintStudentDidQuezzOrNot<Students>(std);
                    }
                    else if(yesNo == 'N')
                    {
                        Messages.ShowMessages("Have a nice day professor. \n  \r \r  LOG OUT", ConsoleColor.Yellow);
                        Console.ReadLine();
                    }
                    else
                    {
                        Messages.ShowMessages("ERROR - Invalide Charackter", ConsoleColor.Red);
                    }
                    Messages.ShowMessages("Have a nice day professor. \n  \r \r  LOG OUT", ConsoleColor.Yellow);
                    Console.ResetColor();
                    
                }
                else
                {
                    Messages.ShowMessages("ERROR - Incorect input", ConsoleColor.Red);
                    
                }
            }
            else
            {
                Messages.ShowMessages("ERROR - Incorect input", ConsoleColor.Red);
            }
            Console.ReadLine();
        }
    }
}
