using SEDC.IO.Logger.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.IO.Logger.Exceptions
{
    public class InvalidUserException : Exception
    {
        private LoggerServices _loggerService = new LoggerServices();

        public InvalidUserException()
            : base("Unknown for invalid user.")
        {
            _loggerService.Log("Invalid user", "Invalid user try log in");
        }
        public InvalidUserException(string message)
            : base(message)
        {
            _loggerService.Log("Invalid user", message);
        }
    }
}
