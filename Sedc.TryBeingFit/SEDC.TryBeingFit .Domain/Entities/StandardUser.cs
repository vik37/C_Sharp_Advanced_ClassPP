using SEDC.TryBeingFit_.Domain.Interfaces;
using System;
using System.Collections.Generic;
using SEDC.TryBeingFit_.Domain.Interfaces.Enums;
using System.Text;

namespace SEDC.TryBeingFit_.Domain.Entities
{
    public class StandardUser : User, IStandardUser
    {
        
        
        public List<IVideoTraining> VideoTrainingSessions { get; set; }
       

        public StandardUser()
        {
            Role = UserRoll.StandardUser;
        }

        public override string PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
