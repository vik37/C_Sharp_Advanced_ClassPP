using System;
using System.Collections.Generic;
using System.Text;
using SEDC.Adv.TryBeingFit.Domain.Entities;

namespace SEDC.Adv.TryBeingFit.Services.Services
{
    public interface ITreningService<T> where T : Training
    {
        List<T> GetTrainings();
        T GetSingleTrainig(int id);
        void AddTraining(T Training);
        
    }
}
