using SEDC.TryBeingFit_.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit_.Domain.Entities
{
    public class VideoTraining : Training, IVideoTraining
    {
        public int Raiting { get; set; }

        public string GetRaiting()
        {
            return $"Rating: {Raiting} stars";
        }
    }
}
