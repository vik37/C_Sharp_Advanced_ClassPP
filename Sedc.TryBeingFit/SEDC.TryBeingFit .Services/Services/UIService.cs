using SEDC.TryBeingFit_.Domain.Entities;
using SEDC.TryBeingFit_.Domain.Interfaces;
using SEDC.TryBeingFit_.Domain.Interfaces.Enums;
using SEDC.TryBeingFit_.Services.Helper;

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SEDC.TryBeingFit_.Services.Services
{
    public class UIService : IUIService
    {
        public int ChoiseEntitiesMany<T>(List<T> entities) where T : IBaseEntity
        {
            while (true)
            {
                Console.WriteLine("Enter a number to choose one of the following:");
                for (int i = 0; i < entities.Count; i++)
                {
                    Console.WriteLine($"{i + 1} {entities[i].PrintInfo()}");
                   
                }
                int choise = ValidationHelper.ValidateNumber(Console.ReadLine(), entities.Count);
                if (choise == -1)
                {
                    Console.ReadLine();
                    continue;
                }
                return choise;
            }
        }

        public int ChooseMany<T>(List<T> items)
        {
            while (true)
            {
                Console.WriteLine("Enter a number to choose one of the following:");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {items[i]}");
                }
                int choice = ValidationHelper.ValidateNumber(Console.ReadLine(), items.Count);
                if (choice == -1)
                {
                    //MessageHelper.Color("[Error] Input incorrect. Please try again", ConsoleColor.Red);
                    Console.ReadLine();
                    continue;
                }
                return choice;

            }
        }

        public int LogInMany()
        {
            List<string> menuItems = new List<string>() { "LogIn", "Register" };
            return ChooseMany(menuItems);
        }

        public int MainMany(UserRoll roll)
        {
            List<string> menuItems = new List<string>() { "Account", "Log Out" };
            switch (roll)
            {
                case UserRoll.StandardUser:
                    menuItems.Insert(0, "Train");
                    menuItems.Insert(0, "Upgrade to Premium");
                    break;
                case UserRoll.PremiumUser:
                    menuItems.Insert(0, "Train");
                    break;
                case UserRoll.TrainerUser:
                    menuItems.Insert(0, "Reschedule training");
                    break;
            }
            return ChooseMany(menuItems);
        }

        public int RoleMany()
        {
            List<string> menuItems = new List<string>() { "LogIn", "Register" };
            return ChooseMany(menuItems);
        }

        public void Welcome(User user)
        {
            Console.WriteLine($"Welcome to the fitness app {user.UserName}!");
            switch (user.Role)
            {
                case UserRoll.StandardUser:
                    Console.WriteLine("If you enjoy the app, consider our Premium subscription!");
                    break;
                case UserRoll.PremiumUser:
                    Console.WriteLine("We are so glad you are part of our community!");
                    break;
                case UserRoll.TrainerUser:
                    Console.WriteLine("We are so glad to have you as a partner!");
                    break;
            }
        }
    }
}
