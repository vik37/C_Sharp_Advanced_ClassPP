using SEDC.TryBeingFit_.Domain.Interfaces;
using SEDC.TryBeingFit_.Domain.Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit_.Domain.Entities
{
    public abstract class User : BaseEntity, IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserRoll Role { get; set; }
    }
}
