using SEDC.Adv.TryBeingFit.Domain.Enums;
using SEDC.Adv.TryBeingFit.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain.Entities
{
    public class TrainerUser : User, ITrainerUser
    {
        public int YearsExperience { get; set; }

        public TrainerUser()
        {
            Role = UserRole.Trainer;
        }

        public bool ChangeSchedule(LiveTraining liveTraining, int days)
        {
            if (days <= 0) return false;
            liveTraining.NextSession.AddDays(days);
            return true;
        }

        public override string PrintInfo()
        {
            return $"{FirstName} {LastName} - {YearsExperience} experience";
        }


    }
}
