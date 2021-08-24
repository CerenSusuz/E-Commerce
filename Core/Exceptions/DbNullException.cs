using System;

namespace Core.Exceptions
{
    public class DbNullException : Exception
    {
        public DbNullException(string message):base(message)
        {
            
        }
    }
}