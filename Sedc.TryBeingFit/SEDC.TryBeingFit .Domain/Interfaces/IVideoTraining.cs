using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit_.Domain.Interfaces
{
    public interface IVideoTraining
    {
        public int Raiting { get; set; }
        string GetRaiting();
    }
}
