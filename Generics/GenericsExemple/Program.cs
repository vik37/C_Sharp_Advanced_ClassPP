using GenericsExemple.Entities;
using System;

namespace GenericsExemple
{
    class Program
    {
        public static GenericDAtaBase<Order> Orders = new GenericDAtaBase<Order>();
        public static GenericDAtaBase<Product> Product = new GenericDAtaBase<Product>();
        static void Main(string[] args)
        {
            Orders.Insert(new Order() { Id = 1, Adress = "Bob street 29", Receiver = "Bob" });
            Orders.Insert(new Order() { Id = 2, Adress = "Jill street 31", Receiver = "Jill" });
            Orders.Insert(new Order() { Id = 3, Adress = "Greg street 11", Receiver = "Greg" });
            Product.Insert(new Product() { Id = 1, Description = "For gaming", Title = "Mouse" });
            Product.Insert(new Product() { Id = 2, Description = "Mechanical", Title = "Keyboard" });
            Product.Insert(new Product() { Id = 3, Description = "64GB", Title = "USB" });

            Order orderId = Orders.GetElementById(1);
            Orders.PrintAll();
            Product.PrintAll();
            Console.ReadLine();
        }
    }
}
