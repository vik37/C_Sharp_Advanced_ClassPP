using System;
using System.Collections.Generic;
using System.Text;

namespace Class04_Static.Entities
{
    public class User
    {
        private int v1;
        private string v2;
        private string v3;

        public int Id { get; set; }
        public string UserName  { get; set; }
        public string Adress { get; set; }
        public List<Order> Orders { get; set; }
        public User(int id, string userName, string adress, List<Order> order)
        {
            Id = id;
            UserName = userName;
            Adress = adress;
            Orders = new List<Order>();
        }

        public User(int v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public void PrintOrders()
        {
            for (int i = 1; i < Orders.Count; i++)
            {
                Console.WriteLine($"{i}) {Orders[i - 1].Print()}");
            }
        }
    }
}
