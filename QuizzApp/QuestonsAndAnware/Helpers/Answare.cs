using System;
using System.Collections.Generic;
using System.Text;

namespace QuestonsAndAnware.Helpers
{
    internal class Answare
    {
        public Dictionary<int, string> AnswereOne = new Dictionary<int, string>();
        public Dictionary<int, string> AnswereTwo = new Dictionary<int, string>();
        public Dictionary<int, string> AnswereThree = new Dictionary<int, string>();
        public Dictionary<int, string> AnswereFour = new Dictionary<int, string>();
        public Dictionary<int, string> AnswereFive = new Dictionary<int, string>();
        public Dictionary<int, string> Error = new Dictionary<int, string>();

        public Answare()
        {
            AnswereOne.Add(1, "Dodoma");
            AnswereOne.Add(2, "Hobart");
            AnswereOne.Add(3, "Launceston");
            AnswereOne.Add(4, "Wellington");

            AnswereTwo.Add(1, "Kinshasa Democratic Republic of the Congo Temple");
            AnswereTwo.Add(2, "Palais de la Nation");
            AnswereTwo.Add(3, "Kongo Trade Centre");
            AnswereTwo.Add(4, "Nabemba Tower");

            AnswereThree.Add(1, "Styx");
            AnswereThree.Add(2, "Hydra");
            AnswereThree.Add(3, "Nix");
            AnswereThree.Add(4, "Lugia");

            AnswereFour.Add(1, "Onega Lake");
            AnswereFour.Add(2, "Benxi Lake");
            AnswereFour.Add(3, "Kivu Lake");
            AnswereFour.Add(4, "Wakatipu Lake");

            AnswereFive.Add(1, "Peru");
            AnswereFive.Add(2, "Chad");
            AnswereFive.Add(3, "Australia");
            AnswereFive.Add(4, "Niger");
            Error.Add(-1, "Wrong Answer");
        }
        public Dictionary<int, string> GetAnsware(int number)
        {
            switch (number)
            {
                case 1:
                    return AnswereOne;

                case 2:
                    return AnswereTwo;


                case 3:
                    return AnswereThree;

                case 4:
                    return AnswereFour;

                case 5:
                    return AnswereFive;
                default:
                    return Error;

            }
        }
    }
}
