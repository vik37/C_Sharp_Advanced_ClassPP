using SEDC.Adv.TryBeingFit.Domain.Db;
using SEDC.Adv.TryBeingFit.Domain.Entities;
using SEDC.Adv.TryBeingFit.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services.Services
{
	public class UserService<T> where T : User
	{
		private IDb<T> _db;
		public UserService()
		{
			_db = new LocalDb<T>();
		}
		public void changeInfo(int userId, string firstName, string lastName)
        {
			var user = _db.GetById(userId);
            if (ValidationHelper.ValidateString(firstName,2) == null
				|| ValidationHelper.ValidateString(lastName,2) == null)
            {
				MessageHelper.Color("[Error] firstname or lastname is invalid!", ConsoleColor.Red);
				return;
			}
			user.FirstName = firstName;
			user.LastName = lastName;
			MessageHelper.Color("User successfully updated!", ConsoleColor.Green);
        }
		public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
			var user = _db.GetById(userId);
			if(user.Password != oldPassword)
            {
				MessageHelper.Color("[Error] passwords did not match!", ConsoleColor.Red);
				return;
            }
			if(oldPassword == newPassword)
            {
				MessageHelper.Color("[Error] you can not set old password as new one!", ConsoleColor.Red);
				return;
			}
			if(ValidationHelper.ValidatePassword(newPassword) == null)
            {
				MessageHelper.Color("[Error] New password is not valid!", ConsoleColor.Red);
				return;
			}
			user.Password = newPassword;
			MessageHelper.Color("Password changed successfully", ConsoleColor.Green);
		}
		public T LogIn(string username,string password)
        {
			T user = _db.GetAll().SingleOrDefault(x => x.Username == username && x.Password == password);
			if(user == null)
            {
				MessageHelper.Color("[Error] username or password did not match", ConsoleColor.Red);
			}
			return user;
        }
		public T Register(T user)
        {
			if (ValidationHelper.ValidateString(user.FirstName, 2) == null
				|| ValidationHelper.ValidateString(user.LastName, 2) == null
				|| ValidationHelper.ValidateString(user.Username, 6) == null
				|| ValidationHelper.ValidatePassword(user.Password) == null)
			{
				MessageHelper.Color("[Error] Invalid info!", ConsoleColor.Red);
				return null;
			}
			int userId = _db.Insert(user);
			return _db.GetById(userId);
		}
		public T GetById(int id)
		{
			return _db.GetById(id);
		}
	}
}
