using SEDC.Adv.TryBeingFit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services.Services
{
    public interface IUserService<T> where T : User
    {
        void ChangePassword(int userId, string oldPassword, string newPassword);
        void ChangeInfo(int userId, string firstName, string lastName);
        T LogIn(string username, string password);
        T Register(T user);

        T GetById(int id);
    }
}
