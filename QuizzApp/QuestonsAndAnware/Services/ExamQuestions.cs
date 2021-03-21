using System;
using System.Collections.Generic;
using QuestonsAndAnware;
using System.Text;
using QuestonsAndAnware.Helpers;
using System.Linq;

namespace QuestonsAndAnware.Services
{
    public class ExamQuestions
    {
        public static Questions questions = new Questions();
        private static Answare ans = new Answare();
        
        public static void ShowQuestions(int num1,int num2)
        {           
            var quest = questions.Quests;
            
            Console.WriteLine($"{quest.Keys.ElementAtOrDefault(num1)} ");
            foreach (KeyValuePair<int, string> answare in ans.GetAnsware(num2))
            {
                Console.WriteLine($"{answare.Key} {answare.Value}");
            }
        }

    }
}
