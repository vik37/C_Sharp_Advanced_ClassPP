using SEDC.TryBeingFit_.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit_.Services.Services
{
    public interface IUserService<T> where T : User
    {
        void ChangePassword(int userId, string oldPassword, string newPassword);
        void ChangeInfo(int userId, string firstNAme, string lastName);
        T LogIn(string userName, string password);
        T Register(T user);
    }
}
