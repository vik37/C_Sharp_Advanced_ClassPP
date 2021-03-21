using SEDC.Adv.TryBeingFit.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain.Entities
{
    public class LiveTraining : Training, ILiveTraining
    {
        public DateTime NextSession { get; set; }

        public TrainerUser Trainer { get; set; }

        public int HoursToNextSession()
        {
            if(NextSession < DateTime.Now)
            {
                return -1;
            }
            return (NextSession - DateTime.Now).Hours;
        }

        public override string PrintInfo()
        {
            return $"[{Difficulty}] {Title} {Description} - Live training";
        }
    }
}
