using QuizzProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzProject.Interface
{
    public interface ILocalDb<T> where T : User
    {
        List<T> GetAll();
        T GetById(int id);
        int insert(T entity);
        void RemoveById(int id);
        void Update(T entity);

    }
}
