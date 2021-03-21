using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate.Entities
{
    public abstract class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        private string Password { get; set; }

        public abstract void ShowAllUsers();
    }
}
