using QuizzProject.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzProject.Entities
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserEntities userEntitie;

        public abstract string ShowInfo();
    }
}
