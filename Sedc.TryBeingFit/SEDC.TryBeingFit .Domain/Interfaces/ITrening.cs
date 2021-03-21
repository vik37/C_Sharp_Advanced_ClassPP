using SEDC.TryBeingFit_.Domain.Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit_.Domain.Interfaces
{
    public interface ITrening
    {
        string Description { get; set; }
        int TimeInMinutes { get; set; }
        TrainingDificult Dificulty { get; set; }
    }
}
