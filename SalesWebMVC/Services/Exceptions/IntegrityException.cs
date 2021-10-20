using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class IntegrityException : Exception
    {
        public IntegrityException(string message) : base(message)
        {
        }
    }
}
