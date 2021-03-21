using Delegate.Entities.Inherite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate.Interface
{
    public interface ITeacher
    {
         Student Student { get; set; }
         List<string> Subject { get; set; }
        void ShowSubject();
        
    }
}
