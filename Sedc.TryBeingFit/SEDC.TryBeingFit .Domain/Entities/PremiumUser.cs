using SEDC.TryBeingFit_.Domain.Interfaces;
using SEDC.TryBeingFit_.Domain.Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit_.Domain.Entities
{
    public class PremiumUser : User, IPremiumUser
    {
        public ILiveTraining liveTrainingSession { get; set; }
        public PremiumUser()
        {
            Role = UserRoll.PremiumUser;
        }

        public override string PrintInfo()
        {
            return $"Live training session: {liveTrainingSession}";
        }
    }
}
