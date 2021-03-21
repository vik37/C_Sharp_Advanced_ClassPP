using SEDC.Adv.TryBeingFit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain.Db
{
    public interface IDb<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
        void Remove(int id);
        void Update(T entity);
    }
}
