using ConsoleApp1.Entities;
using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class DataBase<T> where T : Wheecles
    {
        private List<T> Db;
        public int Count { get; set; }
        public DataBase()
        {
            Db = new List<T>();
            Count = 1;
            
        }
        public void PrintAll()
        {
            foreach (T item in Db)
            {
                item.ShowInfo();
               
            }
        }
        public int Insert(T item)
        {
           
            item.Id = Count;
            Db.Add(item);
            Count = Count + 1;
            
            return item.Id;
        }
        public T GetElementByIndex(int index)
        {
            return Db[index];
        }
        public T GetElementById(int id)
        {
            return Db.SingleOrDefault(item => item.Id == id);
        }
        public void RemoveElementById(int id)
        {
            T item = Db.SingleOrDefault(item => item.Id == id);
            if(item == null)
            {
                Console.WriteLine($"No item found with {id} id");
            }
            else
            {
                Db.Remove(item);
            }
        }
       
      

    }
}
