﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit_.Domain.Interfaces
{
    public interface IPremiumUser
    {
        ILiveTraining liveTrainingSession { get; set; }
        
    }
}
