using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit_.Domain.Interfaces
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        string PrintInfo();
    }
}
