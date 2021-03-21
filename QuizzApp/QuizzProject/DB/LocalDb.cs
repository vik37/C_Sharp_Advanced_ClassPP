using QuizzProject.Entities;
using QuizzProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizzProject.DB
{
    public class LocalDb<T> : ILocalDb<T> where T : User
    {
        public int IdCount { get; set; }
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
            return _db.SingleOrDefault(user => user.Id == id);
        }

        public int insert(T entity)
        {
            entity.Id = IdCount;
            _db.Add(entity);
            IdCount++;
            return entity.Id;
        }

        public void RemoveById(int id)
        {
            T item = _db.FirstOrDefault(user => user.Id == id);
            if (item != null) _db.Remove(item);
        }

        public void Update(T entity)
        {
            T item = _db.FirstOrDefault(user => user.Id == entity.Id);
            item = entity;
        }
    }
}
