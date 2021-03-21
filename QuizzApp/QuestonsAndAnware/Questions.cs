using QuestonsAndAnware.Helpers;
using System;
using System.Collections.Generic;

namespace QuestonsAndAnware
{
    public class Questions 
    {
        private Answare answare;
        private Quest quest;
        public Dictionary<string, Dictionary<int, string>> Quests { get; set; } = new Dictionary<string, Dictionary<int, string>>();

        public Questions()
        {
            answare = new Answare();
            quest = new Quest();
            Quests.Add(quest.question[0], answare.AnswereOne);
            Quests.Add(quest.question[1], answare.AnswereTwo);
            Quests.Add(quest.question[2], answare.AnswereThree);
            Quests.Add(quest.question[3], answare.AnswereFour);
            Quests.Add(quest.question[4], answare.AnswereFive);
        }

        

    }
}
