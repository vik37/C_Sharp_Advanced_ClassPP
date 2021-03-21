using SEDC.TryBeingFit_.Domain.Interfaces;
using SEDC.TryBeingFit_.Domain.Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit_.Domain.Entities
{
    public class Training : BaseEntity,ITrening
    {
        public string Description { get; set; }
        public int TimeInMinutes { get; set; }
        public TrainingDificult Dificulty { get; set; }

        public override string PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
