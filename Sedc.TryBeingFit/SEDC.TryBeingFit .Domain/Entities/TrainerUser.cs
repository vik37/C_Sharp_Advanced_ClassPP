using SEDC.TryBeingFit_.Domain.Interfaces;
using SEDC.TryBeingFit_.Domain.Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit_.Domain.Entities
{
    public class TrainerUser : User, ITrainer
    {
        public TrainerUser()
        {
            Role = UserRoll.TrainerUser;
        }
        public bool ChangeLiveTRainingSchedule(ILiveTraining liveTraining)
        {
            throw new NotImplementedException();
        }

        public override string PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
