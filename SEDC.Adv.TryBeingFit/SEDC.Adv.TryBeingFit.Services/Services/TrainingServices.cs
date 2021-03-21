using SEDC.Adv.TryBeingFit.Domain.Db;
using SEDC.Adv.TryBeingFit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services.Services
{
    public class TrainingServices<T> : ITreningService<T> where T : Training
    {
        private IDb<T> _db;
        public TrainingServices()
        {
            _db = new LocalDb<T>();
        }
        public void AddTraining(T Training)
        {
            _db.Insert(Training);
        }

        public T GetSingleTrainig(int id)
        {
            return _db.GetById(id);
        }

        public List<T> GetTrainings()
        {
            return _db.GetAll();
        }
    }
}
