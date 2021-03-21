using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interface
{
    public interface ITruck
    {
        decimal Weight { get; set; }

        string Classes();
        void ShowClass();

    }
}
