using SEDC.Adv.TryBeingFit.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain.Entities
{
    public class VideoTraining : Training, IVideoTraining
    {
        public string Link { get; set; }

        public int Rating { get; set; }

        public string CheckRating()
        {
            var result = "";
            for (int i = 0; i < Rating; i++)
            {
                result += "*";
            }
            return result;
        }

        public override string PrintInfo()
        {
            return $"[{Difficulty}] {Title} {Description} - video training";
        }
    }
}
