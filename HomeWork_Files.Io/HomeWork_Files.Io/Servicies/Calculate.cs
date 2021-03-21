using HomeWork_Files.Io.ExceptionsText;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Files.Io.Servicies
{
    public static class Calculate
    {
        public static Errors errors = new Errors();
        public static int Result { get; set; }
        public static int CalculateTwoNums(string num1,string num2)
        {                           
            try
            {
                int numOne = int.Parse(num1);
                int numTwo = int.Parse(num2);
                 Result = numOne + numTwo;
                
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                errors.ErrorsCathText(ex.StackTrace);
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                errors.ErrorsCathText(ex.StackTrace);
            }

            return Result;        
            
        }
    }
}
