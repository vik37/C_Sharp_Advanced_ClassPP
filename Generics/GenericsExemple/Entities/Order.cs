using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExemple.Entities
{
    public class Order : BaseEntity
    {
        public string Receiver { get; set; }
        public string Adress  { get; set; }
        public override string GetInfo()
        {
            return $"{Id} {Receiver} - {Adress}";
        }
    }
}
