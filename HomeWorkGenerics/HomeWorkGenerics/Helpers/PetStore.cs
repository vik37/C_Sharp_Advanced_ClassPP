using HomeWorkGenerics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWorkGenerics.Helpers
{
    public class PetStore<T> where T : Pet
    {
        private List<T> Pdb;
        public PetStore()
        {
            Pdb = new List<T>();
        }

        public void PrintAll()
        {
            foreach (T pet in Pdb)
            {
                Console.WriteLine(pet.PrintInfo());
            }
        }
        public void printsPets(T item)
        {
            Pdb.Add(item);
        }
       
        public void RemovePetName(string name)
        {
            T item = Pdb.SingleOrDefault(item => item.Name == name);
            if(item == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There is not pet with {name} name");

            }
            else
            {
                Pdb.Remove(item);
            }
        }
    }
}
