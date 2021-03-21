using SEDC.TryBeingFit_.Domain.Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit_.Domain.Interfaces
{
    public interface IUser
    {
        string FirstName { get; set; }
         string LastName { get; set; }
        string UserName { get; set; }
         string Password { get; set; }
        UserRoll Role { get; set; }
    }
}
