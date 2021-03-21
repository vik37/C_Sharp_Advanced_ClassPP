using SEDC.Adv.TryBeingFit.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain.Entities
{
    public class StandardUser : User
    {
        public List<VideoTraining> VideoTrainings { get; set; }

        public StandardUser()
        {
            Role = UserRole.Standard;
            VideoTrainings = new List<VideoTraining>();
        }

        public override string PrintInfo()
        {
            return $"{FirstName} {LastName} - standard user!";
        }
    }
}
