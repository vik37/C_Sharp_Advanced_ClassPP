using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services.Helpers
{
    public static class ValidationHelper
    {
        public static int ValidateNumber(string number, int range)
        {
            bool isNumber = int.TryParse(number, out int num);
            if (!isNumber) return -1;
            if (num < 0 || num > range) return -1;
            return num;
        }
        public static string ValidateString(string str, int count)
        {
            if (str.Length < count) return null;
            int num;
            if (int.TryParse(str, out num)) return null;
            return str;
        }
        public static string ValidatePassword(string password)
        {
            if (password.Length < 6) return null;
            bool isNum = false;
            foreach (char item in password)
            {
                isNum = int.TryParse(item.ToString(), out int num);
                if (isNum)
                {
                    break;
                }
            }
            if (!isNum) return null;
            return password;
        }
    }
}
