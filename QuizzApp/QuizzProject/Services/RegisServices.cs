using QuizzProject.DB;
using QuizzProject.Entities;
using QuizzProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace QuizzProject.Services
{
    public class RegisServices<T> where T : User
    {
        private ILocalDb<T> _dv;

        public RegisServices()
        {
            _dv = new LocalDb<T>();
        }
        public  T Register(string username, string password, T user)
        {
            
            user.Username = username;
            user.Password = password;
            int userId = _dv.insert(user);
            return _dv.GetById(userId);
           
        }
        public void LogIn(string userName, string password,T user)
        {
            
            if (userName == user.Username && password == user.Password)
            {
                Messages.ShowMessages("Log in is succesifully", ConsoleColor.Green);
            }
            else
            {
                Messages.ShowMessages("Invalid User name or Password", ConsoleColor.Red);
            }
            
        }
    }
}
