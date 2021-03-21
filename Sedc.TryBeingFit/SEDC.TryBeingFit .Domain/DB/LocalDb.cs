using SEDC.TryBeingFit_.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TryBeingFit_.Domain.DB
{
    public class LocalDb<T> : IDb<T> where T : BaseEntity
    {
        public  int IdCount{ get; private set;  }
        private List<T> _db;
        public LocalDb()
        {
            _db = new List<T>();
            IdCount = 1;
        }
        public List<T> GetAll()
        {
            return _db;
        }

        public T GetById(int id)
        {
            return _db.SingleOrDefault(d => d.Id == id);
        }

        public int Insert(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentException("Entity can't be null.");
            }
            entity.Id = IdCount;
            _db.Add(entity);
            IdCount++;
            return entity.Id;

        }

        public bool RemoveById(int id)
        {
            var entity = _db.SingleOrDefault(d => d.Id == id);
           
           
            return _db.Remove(entity);
        }

        public void Update(T newEntity)
        {
            T entityToUpdate = _db.SingleOrDefault(d => d.Id == newEntity.Id);
        }
    }
}
