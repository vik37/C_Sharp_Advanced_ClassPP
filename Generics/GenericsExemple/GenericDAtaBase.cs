using GenericsExemple.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsExemple
{
    public class GenericDAtaBase<T> where T : BaseEntity
    {
        private List<T> Db;
        public GenericDAtaBase()
        {
            Db = new List<T>();
        }
        public void PrintAll()
        {
            foreach (T item in Db)
            {
                Console.WriteLine(item.GetInfo());
            }
        }
        public void Insert(T item)
        {
            Db.Add(item);
        }
        public T GetByIndex(int index)
        {
            return Db[index];
        }
        public T GetElementById(int id)
        {
            return Db.SingleOrDefault(item => item.Id == id);
        }
        public void RemoveById(int id)
        {
            T item = Db.SingleOrDefault(item => item.Id == id);
            if(item == null)
            {
                Console.WriteLine($"No item found with{id}");
                return;
            }
            Db.Remove(item);
        }
    }
}
