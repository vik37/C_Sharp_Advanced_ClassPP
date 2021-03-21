using SEDC.TryBeingFit_.Domain.DB;
using SEDC.TryBeingFit_.Domain.Entities;
using SEDC.TryBeingFit_.Services.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TryBeingFit_.Services.Services
{
    public class UserService<T> : IUserService<T> where T : User
    {
        private IDb<T> _db;
        public UserService()
        {
            _db = new LocalDb<T>();
        }
        public void ChangeInfo(int userId, string firstName, string lastName)
        {
            T user = _db.GetById(userId);
            if (ValidationHelper.ValidateString(firstName) == null
                || ValidationHelper.ValidateString(lastName) == null)
            {
                //MessageHelper.Color("[Error] strings were not valid. Please try again!", ConsoleColor.Red);
                return;
            }
            user.FirstName = firstName;
            user.LastName = lastName;
            _db.Update(user);
        }

        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            T user = _db.GetById(userId);
            if (user.Password != oldPassword)
            {
                //MessageHelper.Color("[Error] Old password did not match", ConsoleColor.Red);
                return;
            }
            if (ValidationHelper.ValidatePassword(newPassword) == null)
            {
                //MessageHelper.Color("[Error] New password is not valid", ConsoleColor.Red);
                return;
            }
            user.Password = newPassword;
            _db.Update(user);
        }

        public T LogIn(string userName, string password)
        {
            T user = _db.GetAll().FirstOrDefault(x => x.UserName == userName && x.Password == password);
            if (user == null)
            {
                //MessageHelper.Color("[Error] Username or password did not match!", ConsoleColor.Red);
                return null;
            }
            return user;
        }

        public T Register(T user)
        {
            if (ValidationHelper.ValidateString(user.FirstName) == null
                || ValidationHelper.ValidateString(user.LastName) == null
                || ValidationHelper.ValidateUserName(user.UserName) == null
                || ValidationHelper.ValidatePassword(user.Password) == null)
            {
                //MessageHelper.Color("[Error] Invalid info!", ConsoleColor.Red);
                Console.ReadLine();
                return null;
            }
            int id = _db.Insert(user);
            return _db.GetById(id);
        }
    }
}
