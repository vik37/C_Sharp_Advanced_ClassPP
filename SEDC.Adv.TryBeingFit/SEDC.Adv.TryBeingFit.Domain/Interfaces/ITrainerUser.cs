using SEDC.Adv.TryBeingFit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain.Interfaces
{
    public interface ITrainerUser
    {
        bool ChangeSchedule(LiveTraining liveTraining,int days);
    }
}
