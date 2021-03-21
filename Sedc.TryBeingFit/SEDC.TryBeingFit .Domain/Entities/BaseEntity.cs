using SEDC.TryBeingFit_.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit_.Domain.Entities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }

        public abstract string PrintInfo();
       
    }
}
