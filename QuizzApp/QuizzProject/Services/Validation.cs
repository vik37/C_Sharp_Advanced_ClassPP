using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using QuestonsAndAnware;
using QuizzProject.DB;
using QuizzProject.Entities;
using QuizzProject.Enums;
using QuizzProject.Interface;

namespace QuizzProject.Services
{
    public class Validation 
    {
        public static int Points { get; set; }

        public static bool IsStringLessThen(string name,string pass)
        {
            if(name.Length >= 2 && pass.Length >= 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void FirstAnsware(Questions quest)
        {         
            var a = quest.Quests.Values.FirstOrDefault().Take(2).LastOrDefault();
            var b = quest.Quests.Values.Take(2).LastOrDefault().LastOrDefault();
            var c = quest.Quests.Values.Take(3).LastOrDefault().LastOrDefault();
            var d = quest.Quests.Values.Take(4).LastOrDefault().Take(2).LastOrDefault();
            var e = quest.Quests.Values.LastOrDefault().FirstOrDefault();

            Console.WriteLine($"\r Answare 1 - {a} \n\r Answare 2 - {b} \n\r Answare 3 - {c} \n\r Answare 4 - {d} \n\r Answare 5 - {e}");
        }
        public static int ReturnPoints(int quest, int numOne,int point)
        {
            switch (quest)
            {
                case 1:
                    if (numOne == 2) Points = point + Points;
                    return Points;
                   
                case 2:
                    if (numOne == 4) Points = point + Points;
                    return Points;
                    
                case 3:
                    if (numOne == 4) Points = point + Points;
                    return Points;
                    
                case 4:
                    if (numOne == 2) Points = point + Points;
                    return Points;
                    
                case 5:
                    if (numOne == 1) Points = point + Points;
                    return Points;
                   
                default:
                    return Points = 0;
                    
            }
           
        }
        public static void PrintStudentDidQuezzOrNot<T>(List<T> item) where T : Students
        {
           //List<T> item = new List<T>();
            var finishedStudents = item.Where(s => s.IsItFinished == true).Select(s => s.Username).ToList();
            var notFinished = item.Where(n => n.IsItFinished == false).Select(s => s.Username).ToList();
           
            finishedStudents.ForEach(f => Messages.ShowMessages(f,ConsoleColor.Green));
            notFinished.ForEach(n => Messages.ShowMessages(n, ConsoleColor.Red));
        }
       
    }
}
