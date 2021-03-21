using SEDC.Adv.TryBeingFit.Domain.Enums;
using SEDC.Adv.TryBeingFit.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain.Entities
{
    public class PremiumUser : User, IPremiumUser
    {
        public List<VideoTraining> VideoTrainings { get; set; }
        public LiveTraining LiveTraining { get; set; }

        public PremiumUser()
        {
            Role = UserRole.Premium;
            VideoTrainings = new List<VideoTraining>();
        }

        public override string PrintInfo()
        {
            return $"{FirstName} {LastName} - a premium user!";
        }
    }
}
