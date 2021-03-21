using SEDC.TryBeingFit_.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit_.Domain.Entities
{
    public class LiveTraining : Training, ILiveTraining
    {
        public int HoursToNextSession()
        {
            throw new NotImplementedException();
        }
    }
}
