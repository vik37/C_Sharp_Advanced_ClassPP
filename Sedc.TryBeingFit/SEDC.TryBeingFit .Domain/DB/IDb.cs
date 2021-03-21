using SEDC.TryBeingFit_.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit_.Domain.DB
{
    public interface IDb<T> where T : IBaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        int Insert(T entity);
       bool RemoveById(int id);
        void Update(T newEntity);
    }
}
