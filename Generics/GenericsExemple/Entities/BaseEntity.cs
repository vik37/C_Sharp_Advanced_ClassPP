using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExemple.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public abstract string GetInfo();
        

        
    }
}
